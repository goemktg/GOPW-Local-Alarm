using GOPW.Alarm.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace GOPW.Alarm
{
    /* 현재 메인 데이터테이블 형식:
     * 경보기 이름 | 경보기 종류 | 경보기 오디오 파일 | 캐릭터 명    | 경보기 좌표   | 경보기 data
     * test        | reload      | test1.mp3          | Goem Funaila | 12,33,444,213 | top:true,time:1000,size:212.231
     * ttt         | rat         | test2.mp3          | Player Goem  | 34,23,123,123 | top:fasle,time:1000,size:33.31
     * 할일:
     * 래틀 재장전 알림 미사일 타입 추가 ( 크루즈 )
     * 재장전 알림 시간초 변경 가능하게.
     * 뉴트 / 랫 알림의 경우 새로운 방식으로 구현 ( 아마 램 누수? 문제를 해결할지도 )
     * 설정 파일 수정해서 이전 버전 설정 사용할 수 있게
     * 강한 규칙 적용해서 코드 스캔
     * 래틀 제장전 알림 구현방식 변경 (OCR 사용)
     */
    public partial class MainForm : Form
    {
        private DataTable dataTable = new DataTable();
        private List<Scaner> scanerListindex = new List<Scaner>();
        private bool formLoaded = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // 버전 정보 가져와서 메인 창에 넣음
            Version v = Assembly.GetExecutingAssembly().GetName().Version;
            Text = Text + v.Major + Properties.Resources.Text_Dot + v.Minor + Properties.Resources.Text_Dot + v.Build;
            // ================================

            Thread UpdateCheckThread = new Thread(new ThreadStart(UpdateCheck));
            UpdateCheckThread.Start();

            dataTable.Locale = CultureInfo.InvariantCulture;
            dataGridView.DataSource = dataTable;
            
            string rawdata = Properties.Settings.Default.maintable;

            dataTable.Columns.Add(Properties.Resources.Text_Scaner_name, typeof(string));
            dataTable.Columns.Add(Properties.Resources.Text_Scaner_type, typeof(string));
            dataTable.Columns.Add(Properties.Resources.Text_Scaner_Sound_File_location, typeof(string));
            dataTable.Columns.Add(Properties.Resources.Text_Scaner_EVE_Char_Name, typeof(string));
            dataTable.Columns.Add(Properties.Resources.Text_Scaner_Coordnate, typeof(string));
            dataTable.Columns.Add(Properties.Resources.Text_AlertData, typeof(string));

            if (!string.IsNullOrEmpty(rawdata))
            {
                string[] Rawrows = rawdata.Split('#');
                foreach (string strrows in Rawrows)
                {
                    string[] rawcolumns = strrows.Split('|');

                    dataTable.Rows.Add(
                        rawcolumns[0], 
                        rawcolumns[1], 
                        rawcolumns[2],
                        rawcolumns[3],
                        rawcolumns[4],
                        rawcolumns[5]
                        );
                    cLB_NeutAlertLIst.Items.Add(rawcolumns[0]);
                }
            }

            formLoaded = true;

            /* test
            maintable.Rows.Add("test", "reload", "test1.mp3");
            maintable.Rows.Add("test1", "reload", "test1.mp3");
            maintable.Rows.Add("test2", "reload", "test1.mp3");
            maintable.Rows.Add("test3", "reload", "test1.mp3");
            maintable.Rows.Add("test4", "reload", "test1.mp3");
            */

            textBoxDefaultSoundFileLoc.Text = Properties.Settings.Default.defaultsoundloc;

            if (Properties.Settings.Default.defaultalertmode == Properties.Resources.Text_Scaner_type_neut)
            {
                checkBox_DefaultSettingNeut.Checked = true;
            }
            else if (Properties.Settings.Default.defaultalertmode == Properties.Resources.Text_Scaner_type_reload)
            {
                checkBox_DefaultSettingReload.Checked = true;
            }
            else if (Properties.Settings.Default.defaultalertmode == Properties.Resources.Text_Scaner_type_rat)
            {
                checkBox_DefaultSettingRat.Checked = true;
            }

            foreach (string str in Properties.Settings.Default.checkedindexs.Split('\\'))
            {
                try
                {
                    cLB_NeutAlertLIst.SetItemChecked(int.Parse(str),true);
                } catch { }
            }

            string _Filestr = Directory.GetCurrentDirectory() + "\\" + "gopwalarm_exe_updated";
            System.IO.FileInfo fi = new System.IO.FileInfo(_Filestr);
            if (fi.Exists)
            {
                fi.Delete();
            }
        }

        //업데이트 확인 동작
        private void UpdateCheck()
        {
            // 버전 정보를 이용해 최신버전인지 체크
            string latestver = GetLatestVer();
            string nowver = Text.Substring(15);
            //MessageBox.Show(NowVersion);
            if (latestver == null) return;
            string[] latestverarr = new string[3];
            string[] nowverarr = new string[3];

            latestverarr = latestver.Split('.');
            nowverarr = nowver.Split('.');
            
            for (int i = 0; i < 3; i++)
            {
                //MessageBox.Show(LatestVersionArray[i] + "vs" + NowVersionArray[i]);
                if (int.Parse(latestverarr[i]) > int.Parse(nowverarr[i]))
                {
                    UpdateAsk updateAsk = new UpdateAsk
                    {
                        LatestVersion = latestver,
                        NowVersion = nowver
                    };
                    updateAsk.ShowDialog();
                    break;
                }
                else if (int.Parse(latestverarr[i]) == int.Parse(nowverarr[i]))
                {
                    continue;
                }
                else break;
            }
        }
        // =================

        // 최신 버전 가져옴
        private static string GetLatestVer()
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            var req = System.Net.WebRequest.CreateHttp(Properties.Resources.Address_Versionstring);

            var latestver= "";
            try
            {
                using (var res = req.GetResponse())
                {
                    var stream = res.GetResponseStream();
                    try
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            latestver = reader.ReadLine().TrimEnd();

                        }
                    }
                    finally
                    {
                        stream.Dispose();
                        res.Dispose();
                    }
                }
            } catch
            {
                return null;
            }
            return latestver;
        }
        // =================================

        // 버튼 클릭 처리 ================
        private void ButtonClickHandler(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "button_Execute")
            {
                int[] CheckedIndices = new int[cLB_NeutAlertLIst.CheckedItems.Count];
                cLB_NeutAlertLIst.CheckedIndices.CopyTo(CheckedIndices, 0);
                
                foreach (int index in CheckedIndices)
                {
                    while (index >= scanerListindex.Count)
                    {
                        // 0번째 경보기라 가정하면 -1번째. 즉 실행 안해야됨.
                        // index = 0, scanerlistindex.Count = 0, 실행 안됨.
                        // 2번째 경보기라 가정하면 0번, 1번을 만들어야 함.
                        // 1) index = 2, Count = 0 -> ( null )
                        // 2) index = 2, Count = 1 -> ( null, null )
                        // 3) index = 2, Count = 2 -> 실행 X
                        scanerListindex.Add(null);
                    }

                    if (dataTable.Rows[index][1].ToString() == "선택 안함")
                    {
                        MessageBox.Show(dataTable.Rows[index][0] +" "+ Properties.Resources.Message_Please_Select_Type_Of_Scaner);
                        continue;
                    }
                    if (scanerListindex[index] != null)
                    {
                        MessageBox.Show(dataTable.Rows[index][0] +" "+ Properties.Resources.Message_Scaner_Already_Running);
                        continue;
                    }

                    Scaner scaner = new Scaner

                    {
                        Text = dataTable.Rows[index][0].ToString()
                    };
                    scaner.WriteScanerSettingSave += new Scaner.SettingSaveEventHandler(Scaner_WriteScanerSettingSave);
                    scaner.WriteFormEnded += new Scaner.FormEndedEventHandler(Scaner_WriteFormEnded);
                    scaner.ScanerMode = dataTable.Rows[index][1].ToString();
                    scaner.ScanerAlertLoc = dataTable.Rows[index][2].ToString();

                    bool Process_Find = false;
                    if (dataTable.Rows[index][3].ToString() != "선택되지 않음")
                    {
                        Process[] processesByName = Process.GetProcessesByName("exefile");

                        foreach (Process process in processesByName)
                        {
                            if (process.MainWindowTitle == "EVE - " + dataTable.Rows[index][3].ToString())
                            {
                                scaner.proc = process;
                                Process_Find = true;
                                break;
                            }
                        }
                        if (!Process_Find)
                        {
                            MessageBox.Show(scaner.Name + Properties.Resources.Error_Cannot_Find_Selected_Client,
                                        Properties.Resources.Error_Error,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                            scanerListindex[index] = scaner;
                            scanerListindex[index].Close();
                            scanerListindex[index] = null;

                            continue;
                            //MessageBox.Show(scanerlistindex[index].ToString());
                        } 
                    }
                    if (dataTable.Rows[index][4].ToString() != "설정되지 않음")
                    {
                        string[] CoordnatesArray = dataTable.Rows[index][4].ToString().Split(',');

                        scaner.xstart = int.Parse(CoordnatesArray[0],CultureInfo.InvariantCulture);
                        scaner.xend = int.Parse(CoordnatesArray[1], CultureInfo.InvariantCulture);
                        scaner.ystart = int.Parse(CoordnatesArray[2], CultureInfo.InvariantCulture);
                        scaner.yend = int.Parse(CoordnatesArray[3], CultureInfo.InvariantCulture);
                    }
                    if (dataTable.Rows[index][3].ToString() != "선택되지 않음" && dataTable.Rows[index][4].ToString() != "설정되지 않음")
                        scaner.ScanerSeted = true;
                    
                    string[] rawdataarray = dataTable.Rows[index][5].ToString().Split(',');

                    string[] dataarray = { rawdataarray[0].Split(':')[1], rawdataarray[1].Split(':')[1], rawdataarray[2].Split(':')[1] };

                    scaner.TopMost = bool.Parse(dataarray[0]);
                    scaner.interval = int.Parse(dataarray[1]);

                    string[] sizearray = dataarray[2].Split('.');
                    scaner.Size = new System.Drawing.Size(int.Parse(sizearray[0]),int.Parse(sizearray[1]));

                    scanerListindex[index] = scaner;

                    scaner.Show();
                    //MessageBox.Show((scanerlistindex.Count - 1).ToString());
                    //MessageBox.Show(index.ToString());
                }
            }
            else if (button.Name == "button_Terminate")
            {
                int[] CheckedIndices = new int[cLB_NeutAlertLIst.CheckedItems.Count];
                cLB_NeutAlertLIst.CheckedIndices.CopyTo(CheckedIndices, 0);
                
                foreach (int index in CheckedIndices)
                {
                    if (scanerListindex.Count == 0)
                    {
                        MessageBox.Show(Properties.Resources.Message_Scaner_Already_Ended,
                                           Properties.Resources.Error_Error,
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
                        break;
                    }
                    else if (scanerListindex[index] == null)
                    {
                        MessageBox.Show(Properties.Resources.Message_Scaner_Already_Ended,
                                           Properties.Resources.Error_Error,
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
                        break;
                    }
                    //MessageBox.Show(index.ToString());
                    scanerListindex[index].Close();
                    //scanerlistindex[index].Dispose();
                    scanerListindex[index] = null;
                }
            }
            else if (button.Name == "button_Add")
            {
                InputHandler("경보기 이름 입력", "경보기 이름을 입력해주세요");
            }
            else if (button.Name == "button_Delete")
            {
                int[] CheckedIndices = new int[cLB_NeutAlertLIst.CheckedItems.Count];
                cLB_NeutAlertLIst.CheckedIndices.CopyTo(CheckedIndices, 0);

                int indexcorrection = 0;
                foreach ( int index in CheckedIndices )
                {
                    if (scanerListindex.Count != 0)
                    {
                        if (scanerListindex[index] != null)
                        {
                            scanerListindex[index].Close();
                            //scanerlistindex[index].Dispose();
                            scanerListindex[index] = null;
                        }
                    }
                    if (dataTable.Rows.Count == 1)
                    {
                        MessageBox.Show(Properties.Resources.Error_Cannot_Delete_Last_Alert,
                                           Properties.Resources.Error_Error,
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
                        break;
                    }
                    cLB_NeutAlertLIst.Items.RemoveAt(index - indexcorrection);
                    dataTable.Rows.RemoveAt(index);
                    indexcorrection++;
                }
            }
        }
        // ===============================

        // 경보기 스캐너 에서 정보 받아와서 저장
        private void Scaner_WriteScanerSettingSave(Scaner scaner, int[] CoordnatesArray, string ClientTitle,Size ClientSize)
        {
            int index = scanerListindex.IndexOf(scaner);
            dataTable.Rows[index][3] = ClientTitle;
            string Coordnates = 
                CoordnatesArray[0].ToString() + ',' +
                CoordnatesArray[1].ToString() + ',' +
                CoordnatesArray[2].ToString() + ',' +
                CoordnatesArray[3].ToString();
            dataTable.Rows[index][4] = Coordnates;
        }
        // =====================================

        // 경보기 스스로 종료 시 dispose 처리
        private void Scaner_WriteFormEnded(Scaner scaner)
        {
            int index = scanerListindex.IndexOf(scaner);
            scanerListindex[index].Dispose();
            scanerListindex[index] = null;
        }


        // 경보기 종류 설정에 사용되는 체크박스 처리
        private void AlertTypeSet_CheckBoxHandler(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                if (checkBox.Name == "checkBox_AlertSetNeut")
                {
                    try { dataTable.Rows[dataGridView.CurrentRow.Index][1] = "neut"; }
                    catch { checkBox_AlertSetNeut.Checked = false; }
                    
                    checkBox_AlertSetRat.Checked = false;
                    checkBox_AlertSetReload.Checked = false;
                }
                else if (checkBox.Name == "checkBox_AlertSetRat")
                {
                    try { dataTable.Rows[dataGridView.CurrentRow.Index][1] = "rat"; }
                    catch { checkBox_AlertSetRat.Checked = false; }

                    checkBox_AlertSetNeut.Checked = false;
                    checkBox_AlertSetReload.Checked = false;
                }
                else if (checkBox.Name == "checkBox_AlertSetReload")
                {
                    try { dataTable.Rows[dataGridView.CurrentRow.Index][1] = "reload"; }
                    catch { checkBox_AlertSetReload.Checked = false; }

                    checkBox_AlertSetNeut.Checked = false;
                    checkBox_AlertSetRat.Checked = false;
                }
            }
            // 체크박스 3개 다 체크 헤제시 문구를 선택 안함으로 수정
            if (!checkBox_AlertSetNeut.Checked & !checkBox_AlertSetRat.Checked & !checkBox_AlertSetReload.Checked)
                try { dataTable.Rows[dataGridView.CurrentRow.Index][1] = "선택 안함"; } catch { }
                
        }
        // =========================================

        // 경보기 기본 종류 설정에 사용되는 체크박스 처리
        private void AlertDefaultTypeSet_CheckBoxHandler(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                if (checkBox.Name == "checkBox_DefaultSettingNeut")
                {
                    Properties.Settings.Default.defaultalertmode = "neut";

                    checkBox_DefaultSettingRat.Checked = false;
                    checkBox_DefaultSettingReload.Checked = false;
                }
                else if (checkBox.Name == "checkBox_DefaultSettingRat")
                {
                    Properties.Settings.Default.defaultalertmode = "rat";

                    checkBox_DefaultSettingNeut.Checked = false;
                    checkBox_DefaultSettingReload.Checked = false;
                }
                else if (checkBox.Name == "checkBox_DefaultSettingReload")
                {
                    Properties.Settings.Default.defaultalertmode = "reload";

                    checkBox_DefaultSettingNeut.Checked = false;
                    checkBox_DefaultSettingRat.Checked = false;
                }
                Properties.Settings.Default.Save();
            }
            else if (!checkBox_DefaultSettingNeut.Checked & !checkBox_DefaultSettingRat.Checked & !checkBox_DefaultSettingReload.Checked)
            {
                Properties.Settings.Default.defaultalertmode = "선택 안함";
                Properties.Settings.Default.Save();
            }
        }
        // =========================================

        // InputForm에서 값을 받아와서 추가
        private void InputHandler( string FormName , string text )
        {
            InputForm inputForm = new InputForm();

            inputForm.WriteTextEvent += new InputForm.TextEventHandler(InputForm_Add_WriteTextEvent);
            inputForm.Text = FormName;
            inputForm.label_text.Text = text;
            inputForm.ShowDialog();
        }
        void InputForm_Add_WriteTextEvent (string text)
        {
            cLB_NeutAlertLIst.Items.Add(text);
            dataTable.Rows.Add(
                text,Properties.Settings.Default.defaultalertmode,
                Properties.Settings.Default.defaultsoundloc,
                "선택되지 않음",
                "설정되지 않음",
                "top:"+Properties.Settings.Default.defaultalerttopmost+",time:"+Properties.Settings.Default.defaultalertinterval+",size:"+Properties.Settings.Default.defaultalertsize);
        }
        // =====================================================

        // fileDialog 핸들러
        private void TextBox_AlertSoundFileLoc_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = Properties.Resources.Text_OFD_Filter
            };

            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                if (textBox.Name == "textBox_AlertSoundFileLoc")
                {
                    try {
                        dataTable.Rows[dataGridView.CurrentRow.Index][2] = fileDialog.FileName;
                        textBox_AlertSoundFileLoc.Text = fileDialog.FileName;
                    } catch { }
                }
                else if (textBox.Name == "textBox_DefaultSoundFileLoc")
                {
                    textBoxDefaultSoundFileLoc.Text = fileDialog.FileName;
                    Properties.Settings.Default.defaultsoundloc = fileDialog.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            fileDialog.Dispose();
        }
        // =========================================================

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string maintableRawdatatemp = "";

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string datatemp = dataTable.Rows[i][0].ToString() + '|' 
                    + dataTable.Rows[i][1].ToString() + '|'
                    + dataTable.Rows[i][2].ToString() + '|'
                    + dataTable.Rows[i][3].ToString() + '|'
                    + dataTable.Rows[i][4].ToString() + '|'
                    + dataTable.Rows[i][5].ToString() + '|';

                if (i == 0)
                    maintableRawdatatemp = datatemp;
                else maintableRawdatatemp += '#' + datatemp;
            }
            //MessageBox.Show(maintableRawdatatemp);

            string CheckedIndex = "";
            foreach (int index in cLB_NeutAlertLIst.CheckedIndices)
            {
                if (index != 0)
                    CheckedIndex += "\\";
                CheckedIndex += index.ToString();
            }
            //MessageBox.Show(CheckedIndex);

            Properties.Settings.Default.checkedindexs = CheckedIndex;
            Properties.Settings.Default.maintable = maintableRawdatatemp;
            Properties.Settings.Default.Save();
           
        }

        private void Button_UsePreInstalledFile_Click(object sender, EventArgs e)
        {
            textBoxDefaultSoundFileLoc.Text = "자체 파일 사용";
            Properties.Settings.Default.defaultsoundloc = "자체 파일 사용";
            Properties.Settings.Default.Save();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                try
                {
                    textBox_AlertSoundFileLoc.Text = dataTable.Rows[dataGridView.CurrentRow.Index][2].ToString();
                } catch
                {
                    textBox_AlertSoundFileLoc.Text = "선택 경보기 없음";
                }

                string AlertType;
                try { AlertType = dataTable.Rows[dataGridView.CurrentRow.Index][1].ToString(); }
                catch { AlertType = ""; }
                if (AlertType == "neut")
                {
                    checkBox_AlertSetNeut.Checked = true;
                }
                else if (AlertType == "rat")
                {
                    checkBox_AlertSetRat.Checked = true;
                }
                else if (AlertType == "reload")
                {
                    checkBox_AlertSetReload.Checked = true;
                }
                else if (AlertType == "선택 안함")
                {
                    checkBox_AlertSetNeut.Checked = false;
                    checkBox_AlertSetRat.Checked = false;
                    checkBox_AlertSetReload.Checked = false;
                }
                else
                {
                    checkBox_AlertSetNeut.Checked = false;
                    checkBox_AlertSetRat.Checked = false;
                    checkBox_AlertSetReload.Checked = false;
                }

                string TopMost = dataTable.Rows[dataGridView.CurrentRow.Index][5].ToString();
                if (TopMost == "true") checkBox_TopMost.Checked = true;
                else if (TopMost == "false") checkBox_TopMost.Checked = false;
            }
        }

        private void Button_UsePreInstalledFile_Click_1(object sender, EventArgs e)
        {
            try
            {
                dataTable.Rows[dataGridView.CurrentRow.Index][2] = "자체 파일 사용";
                textBox_AlertSoundFileLoc.Text = "자체 파일 사용";
            } catch { }
        }

        private void checkBox_TopMost_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_TopMost.Checked)
            {
                try { dataTable.Rows[dataGridView.CurrentRow.Index][5] = "true"; }
                catch { checkBox_TopMost.Checked = false; }
            }
            else
            {
                try { dataTable.Rows[dataGridView.CurrentRow.Index][5] = "false"; }
                catch { checkBox_TopMost.Checked = true; }
            }
        }

        private void checkBox_DefaultSettingAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DefaultSettingAlwaysOnTop.Checked)
                Properties.Settings.Default.defaultalerttopmost = "true";
            else Properties.Settings.Default.defaultalerttopmost = "false";

            Properties.Settings.Default.Save();
        }

        private void textBox_DefaultAlertInterval_TextChanged(object sender, EventArgs e)
        {
            int interval;
            try
            {
                interval = int.Parse(textBox_DefaultAlertInterval.Text);
            } catch
            {
                MessageBox.Show(Properties.Resources.Error_interval_must_be_number,
                                   Properties.Resources.Error_Error,
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
            Properties.Settings.Default.defaultalertinterval = interval.ToString();
            Properties.Settings.Default.Save();
        }
    }
}