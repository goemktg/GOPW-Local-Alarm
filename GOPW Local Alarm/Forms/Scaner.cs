using AForge.Imaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace GOPW.Alarm.Forms
{
    public partial class Scaner : Form
    {
        internal delegate void SettingSaveEventHandler(Scaner scaner, int[] CoordnatesArray, string ClientTitle,Size ClientSize);
        internal event SettingSaveEventHandler WriteScanerSettingSave;
        internal delegate void FormEndedEventHandler(Scaner scaner);
        internal event FormEndedEventHandler WriteFormEnded;

        internal bool ScanerSeted = false;
        internal List<Bitmap> ScanerTargetBitmaps;
        internal string ScanerMode, ScanerAlertLoc;
        internal int xstart, xend, ystart, yend;
        internal Process proc;
        internal int interval;

        private SoundPlayer wav = new SoundPlayer();
        private bool reloadscaned = false;
        private int reloadsec = 35;
        
        public Scaner()
        {
            InitializeComponent();
        }
        private void Scaner_Load(object sender, EventArgs e)
        {
            maintimer.Interval = interval;
            // 사운드파일 로드
            if (ScanerAlertLoc == "자체 파일 사용")
            {
                wav.Dispose();
                wav = new SoundPlayer(Properties.Resources.Eve_warning_hull);
            }
            else wav.SoundLocation = ScanerAlertLoc;
            // ==================

            // 경보기 모드 확인
            if (ScanerMode == "neut")
            {
                ScanerTargetBitmaps = new List<Bitmap>
                {
                    new Bitmap(Properties.Resources.standing_terrible),
                    new Bitmap(Properties.Resources.standing_bad),
                    new Bitmap(Properties.Resources.standing_war),
                    new Bitmap(Properties.Resources.standing_neut)
                };

                Name = Name + " - 뉴트 알림";
            }
            else if (ScanerMode == "reload")
            {
                ScanerTargetBitmaps = new List<Bitmap>
                {
                    new Bitmap(Properties.Resources.Loading)
                };

                Name = Name + " - 재장전 알림";
            }
            else if (ScanerMode == "rat")
            {
                // notimplemented
                Name = Name + " - 랫 알림";
            }

            if (ScanerSeted)
            {
                textBox_ProcessSelect.ReadOnly = true;
                button_SetAreaAndReset.Text = Properties.Resources.Text_Reset;
                button_SetAreaAndReset.Enabled = true;
                textBox_ProcessSelect.Text = proc.MainWindowTitle;
                maintimer.Start();
            }
            // ===============================
        }
        // 클라이언트 저장 방식
        // 클라이언트 title 이름 저장 후, 차후 실행시 그 title에 맞는 클라이언트를 찾아줌.

        // 프로세스 선택 접속 후 데이터 받아옴
        private void TextBox_ProcessSelect_Click(object sender, EventArgs e)
        {
            if (button_SetAreaAndReset.Enabled && button_SetAreaAndReset.Text == "재설정")
            {
                return;
            }
            SelectProcess select_Process = new SelectProcess();
            select_Process.WriteClientSelectFin += new SelectProcess.EventHandler(Select_Process_WriteClientSelectFin);
            if (TopMost)
                select_Process.TopMost = true;
            select_Process.ShowDialog();
        }
        private void Select_Process_WriteClientSelectFin(Process p, string str)
        {
            textBox_ProcessSelect.ReadOnly = true;
            textBox_ProcessSelect.Text = str;
            button_SetAreaAndReset.Enabled = true;

            proc = p;
        }
        // ======================================

        // 저장 =================================
        private void Scaner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ScanerSeted)
            {
                int[] CoordnatesArray = {xstart, xend, ystart, yend};
                string ClientTitle = proc.MainWindowTitle.Substring(6);
                Size SizeArray = Size;
                WriteScanerSettingSave(this,CoordnatesArray,ClientTitle,SizeArray);
            }
        }

        private void Scaner_FormClosed(object sender, FormClosedEventArgs e)
        {
            WriteFormEnded(this);
        }
        // =====================================

        // 영역 설정 접속 후 데이터 받아옴 or 재설정
        private void Button_SetArea_Click(object sender, EventArgs e)
        {
            if (button_SetAreaAndReset.Text == "영역 설정")
            {
                var Capture = new CaptureLib();
                Bitmap bmp = Capture.CaptureWindow(proc.MainWindowHandle);

                if (bmp == null)
                {
                    MessageBox.Show(Properties.Resources.Message_EVE_Client_Is_min_stat,
                                        Properties.Resources.Error_Error,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    return;
                }
                    
                SelectArea select_Area = new SelectArea()
                {
                    bitmap = bmp
                };
                select_Area.WriteAreaSelectFin += new SelectArea.EventHandler(Select_Area_WriteAreaSelectFin);
                if (TopMost)
                    select_Area.TopMost = true;
                select_Area.ShowDialog();

                bmp.Dispose();
            }
            else if (button_SetAreaAndReset.Text == "재설정")
            {
                ScanerSeted = false;
                maintimer.Stop();
                button_SetAreaAndReset.Enabled = false;
                button_SetAreaAndReset.Text = "영역 설정";
                textBox_ProcessSelect.Text = "";
                textBox_ProcessSelect.ReadOnly = false;
                pictureBox_Preview.Image = null;
                label_Status.Text = "preparing";
            }
        }
        private void Select_Area_WriteAreaSelectFin(int xStart, int xEnd, int yStart, int yEnd)
        {
            xstart = xStart;
            xend = xEnd;
            ystart = yStart;
            yend = yEnd;
            ScanerSeted = true;
            button_SetAreaAndReset.Enabled = true;
            button_SetAreaAndReset.Text = Properties.Resources.Text_Reset;
            maintimer.Start();
        }
        // =======================================

        // 뉴트 스캔 핸들링
        private void OldNeutScanHandler()
        {
            int num = 0;
            var Capture = new CaptureLib();

            Bitmap bmp = Capture.CaptureWindow(proc.MainWindowHandle);
            if (bmp == null) // 이브 최소화상태
            {
                label_Status.Text = Properties.Resources.Text_Minimized;
                if (label_Status.ForeColor == Color.Red)
                    label_Status.ForeColor = Color.Black;
                else
                    label_Status.ForeColor = Color.Red;
            }
            else if (bmp.Height < 700 | bmp.Width < 1000) // 이브 최소화상태
            {
                label_Status.Text = Properties.Resources.Text_Minimized;
                if (label_Status.ForeColor == Color.Red)
                    label_Status.ForeColor = Color.Black;
                else
                    label_Status.ForeColor = Color.Red;
            }
            else
            {
                if (label_Status.Text == Properties.Resources.Text_Working)
                    label_Status.Text = Properties.Resources.Text_Working_2;
                else
                    label_Status.Text = Properties.Resources.Text_Working;
                bmp = bmp.Clone(new Rectangle(xstart, ystart, xend - xstart, yend - ystart), bmp.PixelFormat);
                if (pictureBox_Preview.Image != null)
                {
                    pictureBox_Preview.Image.Dispose();
                }
                pictureBox_Preview.Image = bmp;
                pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;

                Bitmap img_original = bmp;

                /*
                Bitmap image = new Bitmap(img_original.Width, img_original.Height, PixelFormat.Format24bppRgb);
                using (Graphics graphics = Graphics.FromImage(image))
                    graphics.DrawImage(img_original, new Rectangle(0, 0, image.Width, image.Height));
                */
                Bitmap image = img_original.Clone(new Rectangle(0, 0, img_original.Width, img_original.Height),PixelFormat.Format24bppRgb);
                foreach (Bitmap bitmap in ScanerTargetBitmaps)
                {
                    /*
                    Bitmap template = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format24bppRgb);
                    using (Graphics graphics = Graphics.FromImage(template))
                        graphics.DrawImage(bitmap, new Rectangle(0, 0, template.Width, template.Height));
                    */
                    Bitmap template = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format24bppRgb);
                    TemplateMatch[] templateMatchArray = new ExhaustiveTemplateMatching(0.921f).ProcessImage(image, template);
                    //MessageBox.Show("templateMatchArrayfin");
                    BitmapData bitmapData = img_original.LockBits(new Rectangle(0, 0, img_original.Width, img_original.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);

                    foreach (TemplateMatch templateMatch in templateMatchArray)
                    {
                        ++num;
                    }

                    img_original.UnlockBits(bitmapData);
                    template.Dispose();
                    bitmapData = null;
                    templateMatchArray = null;

                    if (num > 0) break;
                }
                //img_original.Dispose();
                if (num <= 0)
                {
                    image.Dispose();
                    return;
                }

                image.Dispose();
                if (label_Status.Text != Properties.Resources.Text_NeutScaned)
                    label_Status.Text = Properties.Resources.Text_NeutScaned;
                wav.Play();
            }
            //bmp.Dispose();
            GC.Collect(0, GCCollectionMode.Optimized);
            GC.WaitForFullGCComplete();
        }
        // ========================================
        
        // 재장전 스캔 핸들링
        private void OldReloadScanHandler()
        {
            if (reloadscaned)
            {
                return;
            }
            int num = 0;
            var Capture = new CaptureLib();

            Bitmap bmp = Capture.CaptureWindow(proc.MainWindowHandle);
            if (bmp == null) // 이브 최소화상태
            {
                label_Status.Text = Properties.Resources.Text_Minimized;
                if (label_Status.ForeColor == Color.Red)
                    label_Status.ForeColor = Color.Black;
                else
                    label_Status.ForeColor = Color.Red;
            }
            else if (bmp.Height < 700 | bmp.Width < 1000) // 이브 최소화상태
            {
                label_Status.Text = Properties.Resources.Text_Minimized;
                if (label_Status.ForeColor == Color.Red)
                    label_Status.ForeColor = Color.Black;
                else
                    label_Status.ForeColor = Color.Red;
            }
            else
            {
                label_Status.Text = Properties.Resources.Text_Working;
                bmp = bmp.Clone(new Rectangle(xstart, ystart, xend - xstart, yend - ystart), bmp.PixelFormat);
                if (pictureBox_Preview.Image != null)
                {
                    pictureBox_Preview.Image.Dispose();
                }
                pictureBox_Preview.Image = bmp;
                pictureBox_Preview.SizeMode = PictureBoxSizeMode.StretchImage;

                Bitmap img_original = bmp;
                /*
                Bitmap image = new Bitmap(img_original.Width, img_original.Height, PixelFormat.Format24bppRgb);
                using (Graphics graphics = Graphics.FromImage(image))
                    graphics.DrawImage(img_original, new Rectangle(0, 0, image.Width, image.Height));
                */
                Bitmap image = img_original.Clone(new Rectangle(0, 0, img_original.Width, img_original.Height), PixelFormat.Format24bppRgb);

                foreach (Bitmap bitmap in ScanerTargetBitmaps)
                {
                    /*
                    Bitmap template = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format24bppRgb);
                    using (Graphics graphics = Graphics.FromImage(template))
                        graphics.DrawImage(bitmap, new Rectangle(0, 0, template.Width, template.Height));
                    */
                    Bitmap template = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format24bppRgb);

                    TemplateMatch[] templateMatchArray = new ExhaustiveTemplateMatching(0.921f).ProcessImage(image, template);
                    //MessageBox.Show("templateMatchArrayfin");
                    BitmapData bitmapData = img_original.LockBits(new Rectangle(0, 0, img_original.Width, img_original.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);

                    foreach (TemplateMatch templateMatch in templateMatchArray)
                    {
                       ++num;
                    }

                    img_original.UnlockBits(bitmapData);
                    template.Dispose();
                    bitmapData = null;
                    templateMatchArray = null;

                    if (num > 0) break;
                }
                //img_original.Dispose();
                if (num <= 0)
                {
                    image.Dispose();
                    return;
                }

                image.Dispose();
                label_Status.Text = "RLScaned";
                if (reloadscaned) return;
                //MessageBox.Show("리로드 인식");
                ThreadStart th = new ThreadStart(RattleReloadAlertSoundPlayHandler);
                Thread thread = new Thread(th);
                thread.Start();
                //wav.Play();
            }
            GC.Collect(0, GCCollectionMode.Optimized);
            GC.WaitForFullGCComplete();
        }
        // =========================================

        // 랫 스캔 핸들링
        private void OldRatScanHandler()
        {
        }
        // ========================================

        // 서치 이벤트 시작
        private void Maintimer_Tick(object sender, EventArgs e)
        {
            if (ScanerMode == "neut")
                OldNeutScanHandler();
            else if (ScanerMode == "reload")
                OldReloadScanHandler();
            else if (ScanerMode == "rat")
                OldRatScanHandler();
        }
        // ========================================


        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

        private void RattleReloadAlertSoundPlayHandler()
        {
            reloadscaned = true;
            Delay(reloadsec * 1000);
            reloadscaned = false;
            wav.Play();
        }
    }
}