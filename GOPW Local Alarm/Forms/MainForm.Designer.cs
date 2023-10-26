namespace GOPW.Alarm
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl_MainControl = new System.Windows.Forms.TabControl();
            this.tabPage_AlertManage = new System.Windows.Forms.TabPage();
            this.cLB_NeutAlertLIst = new System.Windows.Forms.CheckedListBox();
            this.buttonpanel = new System.Windows.Forms.Panel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Terminate = new System.Windows.Forms.Button();
            this.button_Execute = new System.Windows.Forms.Button();
            this.tabPage_AlertSetting = new System.Windows.Forms.TabPage();
            this.groupBox_AlertInfomation = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.AlertSettingpanel = new System.Windows.Forms.Panel();
            this.groupBox_SoundFileSetting = new System.Windows.Forms.GroupBox();
            this.button_UsePreInstalledFile = new System.Windows.Forms.Button();
            this.textBox_AlertSoundFileLoc = new System.Windows.Forms.TextBox();
            this.groupBox_AlertTypeSet = new System.Windows.Forms.GroupBox();
            this.checkBox_TopMost = new System.Windows.Forms.CheckBox();
            this.checkBox_AlertSetReload = new System.Windows.Forms.CheckBox();
            this.checkBox_AlertSetRat = new System.Windows.Forms.CheckBox();
            this.checkBox_AlertSetNeut = new System.Windows.Forms.CheckBox();
            this.tabPage_ProgramSetting = new System.Windows.Forms.TabPage();
            this.groupBox_AlertSetting = new System.Windows.Forms.GroupBox();
            this.checkBox_AlertAutoUpdateCheck = new System.Windows.Forms.CheckBox();
            this.checkBox_AlertAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.groupBox_AlertDefaultSetting = new System.Windows.Forms.GroupBox();
            this.groupBox_DefaultAlertsetting = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DefaultAlertInterval = new System.Windows.Forms.TextBox();
            this.checkBox_DefaultSettingAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.groupBox_DefaultAlertModeSetting = new System.Windows.Forms.GroupBox();
            this.checkBox_DefaultSettingReload = new System.Windows.Forms.CheckBox();
            this.checkBox_DefaultSettingRat = new System.Windows.Forms.CheckBox();
            this.checkBox_DefaultSettingNeut = new System.Windows.Forms.CheckBox();
            this.groupBox_AlertSoundDefault = new System.Windows.Forms.GroupBox();
            this.textBoxDefaultSoundFileLoc = new System.Windows.Forms.TextBox();
            this.button_UsePreInstalledFileAsDefault = new System.Windows.Forms.Button();
            this.tabPage_ChangeLog = new System.Windows.Forms.TabPage();
            this.textBox_ChangeLog = new System.Windows.Forms.TextBox();
            this.tabControl_MainControl.SuspendLayout();
            this.tabPage_AlertManage.SuspendLayout();
            this.buttonpanel.SuspendLayout();
            this.tabPage_AlertSetting.SuspendLayout();
            this.groupBox_AlertInfomation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.AlertSettingpanel.SuspendLayout();
            this.groupBox_SoundFileSetting.SuspendLayout();
            this.groupBox_AlertTypeSet.SuspendLayout();
            this.tabPage_ProgramSetting.SuspendLayout();
            this.groupBox_AlertSetting.SuspendLayout();
            this.groupBox_AlertDefaultSetting.SuspendLayout();
            this.groupBox_DefaultAlertsetting.SuspendLayout();
            this.groupBox_DefaultAlertModeSetting.SuspendLayout();
            this.groupBox_AlertSoundDefault.SuspendLayout();
            this.tabPage_ChangeLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_MainControl
            // 
            this.tabControl_MainControl.Controls.Add(this.tabPage_AlertManage);
            this.tabControl_MainControl.Controls.Add(this.tabPage_AlertSetting);
            this.tabControl_MainControl.Controls.Add(this.tabPage_ProgramSetting);
            this.tabControl_MainControl.Controls.Add(this.tabPage_ChangeLog);
            this.tabControl_MainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_MainControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl_MainControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl_MainControl.Name = "tabControl_MainControl";
            this.tabControl_MainControl.SelectedIndex = 0;
            this.tabControl_MainControl.Size = new System.Drawing.Size(332, 341);
            this.tabControl_MainControl.TabIndex = 0;
            // 
            // tabPage_AlertManage
            // 
            this.tabPage_AlertManage.Controls.Add(this.cLB_NeutAlertLIst);
            this.tabPage_AlertManage.Controls.Add(this.buttonpanel);
            this.tabPage_AlertManage.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AlertManage.Name = "tabPage_AlertManage";
            this.tabPage_AlertManage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage_AlertManage.Size = new System.Drawing.Size(324, 315);
            this.tabPage_AlertManage.TabIndex = 0;
            this.tabPage_AlertManage.Text = "경보기 관리";
            this.tabPage_AlertManage.UseVisualStyleBackColor = true;
            // 
            // cLB_NeutAlertLIst
            // 
            this.cLB_NeutAlertLIst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLB_NeutAlertLIst.FormattingEnabled = true;
            this.cLB_NeutAlertLIst.Location = new System.Drawing.Point(3, 3);
            this.cLB_NeutAlertLIst.Name = "cLB_NeutAlertLIst";
            this.cLB_NeutAlertLIst.Size = new System.Drawing.Size(318, 278);
            this.cLB_NeutAlertLIst.TabIndex = 0;
            // 
            // buttonpanel
            // 
            this.buttonpanel.Controls.Add(this.button_Delete);
            this.buttonpanel.Controls.Add(this.button_Add);
            this.buttonpanel.Controls.Add(this.button_Terminate);
            this.buttonpanel.Controls.Add(this.button_Execute);
            this.buttonpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonpanel.Location = new System.Drawing.Point(3, 281);
            this.buttonpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonpanel.Name = "buttonpanel";
            this.buttonpanel.Size = new System.Drawing.Size(318, 31);
            this.buttonpanel.TabIndex = 7;
            // 
            // button_Delete
            // 
            this.button_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Delete.Location = new System.Drawing.Point(237, 0);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(81, 31);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "제거";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.ButtonClickHandler);
            // 
            // button_Add
            // 
            this.button_Add.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Add.Location = new System.Drawing.Point(158, 0);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(79, 31);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "추가";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.ButtonClickHandler);
            // 
            // button_Terminate
            // 
            this.button_Terminate.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Terminate.Location = new System.Drawing.Point(79, 0);
            this.button_Terminate.Name = "button_Terminate";
            this.button_Terminate.Size = new System.Drawing.Size(79, 31);
            this.button_Terminate.TabIndex = 5;
            this.button_Terminate.Text = "종료";
            this.button_Terminate.UseVisualStyleBackColor = true;
            this.button_Terminate.Click += new System.EventHandler(this.ButtonClickHandler);
            // 
            // button_Execute
            // 
            this.button_Execute.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Execute.Location = new System.Drawing.Point(0, 0);
            this.button_Execute.Name = "button_Execute";
            this.button_Execute.Size = new System.Drawing.Size(79, 31);
            this.button_Execute.TabIndex = 1;
            this.button_Execute.Text = "실행";
            this.button_Execute.UseVisualStyleBackColor = true;
            this.button_Execute.Click += new System.EventHandler(this.ButtonClickHandler);
            // 
            // tabPage_AlertSetting
            // 
            this.tabPage_AlertSetting.Controls.Add(this.groupBox_AlertInfomation);
            this.tabPage_AlertSetting.Controls.Add(this.AlertSettingpanel);
            this.tabPage_AlertSetting.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AlertSetting.Name = "tabPage_AlertSetting";
            this.tabPage_AlertSetting.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage_AlertSetting.Size = new System.Drawing.Size(324, 315);
            this.tabPage_AlertSetting.TabIndex = 1;
            this.tabPage_AlertSetting.Text = "경보기 설정";
            this.tabPage_AlertSetting.UseVisualStyleBackColor = true;
            // 
            // groupBox_AlertInfomation
            // 
            this.groupBox_AlertInfomation.AutoSize = true;
            this.groupBox_AlertInfomation.Controls.Add(this.dataGridView);
            this.groupBox_AlertInfomation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_AlertInfomation.Location = new System.Drawing.Point(3, 106);
            this.groupBox_AlertInfomation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_AlertInfomation.Name = "groupBox_AlertInfomation";
            this.groupBox_AlertInfomation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_AlertInfomation.Size = new System.Drawing.Size(318, 206);
            this.groupBox_AlertInfomation.TabIndex = 3;
            this.groupBox_AlertInfomation.TabStop = false;
            this.groupBox_AlertInfomation.Text = "경보기 정보";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(2, 16);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(314, 188);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // AlertSettingpanel
            // 
            this.AlertSettingpanel.Controls.Add(this.groupBox_SoundFileSetting);
            this.AlertSettingpanel.Controls.Add(this.groupBox_AlertTypeSet);
            this.AlertSettingpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlertSettingpanel.Location = new System.Drawing.Point(3, 3);
            this.AlertSettingpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AlertSettingpanel.Name = "AlertSettingpanel";
            this.AlertSettingpanel.Size = new System.Drawing.Size(318, 103);
            this.AlertSettingpanel.TabIndex = 6;
            // 
            // groupBox_SoundFileSetting
            // 
            this.groupBox_SoundFileSetting.AutoSize = true;
            this.groupBox_SoundFileSetting.Controls.Add(this.button_UsePreInstalledFile);
            this.groupBox_SoundFileSetting.Controls.Add(this.textBox_AlertSoundFileLoc);
            this.groupBox_SoundFileSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_SoundFileSetting.Location = new System.Drawing.Point(144, 0);
            this.groupBox_SoundFileSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_SoundFileSetting.Name = "groupBox_SoundFileSetting";
            this.groupBox_SoundFileSetting.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_SoundFileSetting.Size = new System.Drawing.Size(174, 79);
            this.groupBox_SoundFileSetting.TabIndex = 4;
            this.groupBox_SoundFileSetting.TabStop = false;
            this.groupBox_SoundFileSetting.Text = "경보기 알림 설정";
            // 
            // button_UsePreInstalledFile
            // 
            this.button_UsePreInstalledFile.AutoSize = true;
            this.button_UsePreInstalledFile.Location = new System.Drawing.Point(3, 41);
            this.button_UsePreInstalledFile.Margin = new System.Windows.Forms.Padding(0);
            this.button_UsePreInstalledFile.Name = "button_UsePreInstalledFile";
            this.button_UsePreInstalledFile.Size = new System.Drawing.Size(166, 22);
            this.button_UsePreInstalledFile.TabIndex = 5;
            this.button_UsePreInstalledFile.Text = "기본 파일 사용";
            this.button_UsePreInstalledFile.UseVisualStyleBackColor = true;
            this.button_UsePreInstalledFile.Click += new System.EventHandler(this.Button_UsePreInstalledFile_Click_1);
            // 
            // textBox_AlertSoundFileLoc
            // 
            this.textBox_AlertSoundFileLoc.Location = new System.Drawing.Point(3, 16);
            this.textBox_AlertSoundFileLoc.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBox_AlertSoundFileLoc.Name = "textBox_AlertSoundFileLoc";
            this.textBox_AlertSoundFileLoc.ReadOnly = true;
            this.textBox_AlertSoundFileLoc.Size = new System.Drawing.Size(167, 21);
            this.textBox_AlertSoundFileLoc.TabIndex = 1;
            this.textBox_AlertSoundFileLoc.TabStop = false;
            this.textBox_AlertSoundFileLoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_AlertSoundFileLoc_MouseDown);
            // 
            // groupBox_AlertTypeSet
            // 
            this.groupBox_AlertTypeSet.Controls.Add(this.checkBox_TopMost);
            this.groupBox_AlertTypeSet.Controls.Add(this.checkBox_AlertSetReload);
            this.groupBox_AlertTypeSet.Controls.Add(this.checkBox_AlertSetRat);
            this.groupBox_AlertTypeSet.Controls.Add(this.checkBox_AlertSetNeut);
            this.groupBox_AlertTypeSet.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_AlertTypeSet.Location = new System.Drawing.Point(0, 0);
            this.groupBox_AlertTypeSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_AlertTypeSet.Name = "groupBox_AlertTypeSet";
            this.groupBox_AlertTypeSet.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_AlertTypeSet.Size = new System.Drawing.Size(144, 103);
            this.groupBox_AlertTypeSet.TabIndex = 3;
            this.groupBox_AlertTypeSet.TabStop = false;
            this.groupBox_AlertTypeSet.Text = "경보기 종류 설정";
            // 
            // checkBox_TopMost
            // 
            this.checkBox_TopMost.AutoSize = true;
            this.checkBox_TopMost.Location = new System.Drawing.Point(4, 72);
            this.checkBox_TopMost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_TopMost.Name = "checkBox_TopMost";
            this.checkBox_TopMost.Size = new System.Drawing.Size(76, 16);
            this.checkBox_TopMost.TabIndex = 3;
            this.checkBox_TopMost.Text = "항상 위로";
            this.checkBox_TopMost.UseVisualStyleBackColor = true;
            this.checkBox_TopMost.CheckedChanged += new System.EventHandler(this.checkBox_TopMost_CheckedChanged);
            // 
            // checkBox_AlertSetReload
            // 
            this.checkBox_AlertSetReload.AutoSize = true;
            this.checkBox_AlertSetReload.Location = new System.Drawing.Point(4, 53);
            this.checkBox_AlertSetReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_AlertSetReload.Name = "checkBox_AlertSetReload";
            this.checkBox_AlertSetReload.Size = new System.Drawing.Size(116, 16);
            this.checkBox_AlertSetReload.TabIndex = 0;
            this.checkBox_AlertSetReload.Text = "래틀 재장전 알림";
            this.checkBox_AlertSetReload.UseVisualStyleBackColor = true;
            this.checkBox_AlertSetReload.CheckedChanged += new System.EventHandler(this.AlertTypeSet_CheckBoxHandler);
            // 
            // checkBox_AlertSetRat
            // 
            this.checkBox_AlertSetRat.AutoSize = true;
            this.checkBox_AlertSetRat.Enabled = false;
            this.checkBox_AlertSetRat.Location = new System.Drawing.Point(4, 35);
            this.checkBox_AlertSetRat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_AlertSetRat.Name = "checkBox_AlertSetRat";
            this.checkBox_AlertSetRat.Size = new System.Drawing.Size(130, 16);
            this.checkBox_AlertSetRat.TabIndex = 1;
            this.checkBox_AlertSetRat.Text = "랫 알림 (추가 예정)";
            this.checkBox_AlertSetRat.CheckedChanged += new System.EventHandler(this.AlertTypeSet_CheckBoxHandler);
            // 
            // checkBox_AlertSetNeut
            // 
            this.checkBox_AlertSetNeut.AutoSize = true;
            this.checkBox_AlertSetNeut.Location = new System.Drawing.Point(4, 16);
            this.checkBox_AlertSetNeut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_AlertSetNeut.Name = "checkBox_AlertSetNeut";
            this.checkBox_AlertSetNeut.Size = new System.Drawing.Size(76, 16);
            this.checkBox_AlertSetNeut.TabIndex = 2;
            this.checkBox_AlertSetNeut.Text = "뉴트 알림";
            this.checkBox_AlertSetNeut.UseVisualStyleBackColor = true;
            this.checkBox_AlertSetNeut.CheckedChanged += new System.EventHandler(this.AlertTypeSet_CheckBoxHandler);
            // 
            // tabPage_ProgramSetting
            // 
            this.tabPage_ProgramSetting.Controls.Add(this.groupBox_AlertSetting);
            this.tabPage_ProgramSetting.Controls.Add(this.groupBox_AlertDefaultSetting);
            this.tabPage_ProgramSetting.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ProgramSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_ProgramSetting.Name = "tabPage_ProgramSetting";
            this.tabPage_ProgramSetting.Size = new System.Drawing.Size(320, 303);
            this.tabPage_ProgramSetting.TabIndex = 2;
            this.tabPage_ProgramSetting.Text = "프로그램 설정";
            this.tabPage_ProgramSetting.UseVisualStyleBackColor = true;
            // 
            // groupBox_AlertSetting
            // 
            this.groupBox_AlertSetting.Controls.Add(this.checkBox_AlertAutoUpdateCheck);
            this.groupBox_AlertSetting.Controls.Add(this.checkBox_AlertAlwaysOnTop);
            this.groupBox_AlertSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_AlertSetting.Location = new System.Drawing.Point(0, 193);
            this.groupBox_AlertSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_AlertSetting.Name = "groupBox_AlertSetting";
            this.groupBox_AlertSetting.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_AlertSetting.Size = new System.Drawing.Size(320, 67);
            this.groupBox_AlertSetting.TabIndex = 1;
            this.groupBox_AlertSetting.TabStop = false;
            this.groupBox_AlertSetting.Text = "경보기 설정";
            // 
            // checkBox_AlertAutoUpdateCheck
            // 
            this.checkBox_AlertAutoUpdateCheck.AutoSize = true;
            this.checkBox_AlertAutoUpdateCheck.Location = new System.Drawing.Point(6, 37);
            this.checkBox_AlertAutoUpdateCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_AlertAutoUpdateCheck.Name = "checkBox_AlertAutoUpdateCheck";
            this.checkBox_AlertAutoUpdateCheck.Size = new System.Drawing.Size(128, 16);
            this.checkBox_AlertAutoUpdateCheck.TabIndex = 1;
            this.checkBox_AlertAutoUpdateCheck.Text = "자동 업데이트 확인";
            this.checkBox_AlertAutoUpdateCheck.UseVisualStyleBackColor = true;
            // 
            // checkBox_AlertAlwaysOnTop
            // 
            this.checkBox_AlertAlwaysOnTop.AutoSize = true;
            this.checkBox_AlertAlwaysOnTop.Location = new System.Drawing.Point(6, 18);
            this.checkBox_AlertAlwaysOnTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_AlertAlwaysOnTop.Name = "checkBox_AlertAlwaysOnTop";
            this.checkBox_AlertAlwaysOnTop.Size = new System.Drawing.Size(76, 16);
            this.checkBox_AlertAlwaysOnTop.TabIndex = 0;
            this.checkBox_AlertAlwaysOnTop.Text = "항상 위로";
            this.checkBox_AlertAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // groupBox_AlertDefaultSetting
            // 
            this.groupBox_AlertDefaultSetting.Controls.Add(this.groupBox_DefaultAlertsetting);
            this.groupBox_AlertDefaultSetting.Controls.Add(this.groupBox_DefaultAlertModeSetting);
            this.groupBox_AlertDefaultSetting.Controls.Add(this.groupBox_AlertSoundDefault);
            this.groupBox_AlertDefaultSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_AlertDefaultSetting.Location = new System.Drawing.Point(0, 0);
            this.groupBox_AlertDefaultSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_AlertDefaultSetting.Name = "groupBox_AlertDefaultSetting";
            this.groupBox_AlertDefaultSetting.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_AlertDefaultSetting.Size = new System.Drawing.Size(320, 193);
            this.groupBox_AlertDefaultSetting.TabIndex = 0;
            this.groupBox_AlertDefaultSetting.TabStop = false;
            this.groupBox_AlertDefaultSetting.Text = "경보기 기본값 설정";
            // 
            // groupBox_DefaultAlertsetting
            // 
            this.groupBox_DefaultAlertsetting.Controls.Add(this.label1);
            this.groupBox_DefaultAlertsetting.Controls.Add(this.textBox_DefaultAlertInterval);
            this.groupBox_DefaultAlertsetting.Controls.Add(this.checkBox_DefaultSettingAlwaysOnTop);
            this.groupBox_DefaultAlertsetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_DefaultAlertsetting.Location = new System.Drawing.Point(2, 128);
            this.groupBox_DefaultAlertsetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_DefaultAlertsetting.Name = "groupBox_DefaultAlertsetting";
            this.groupBox_DefaultAlertsetting.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_DefaultAlertsetting.Size = new System.Drawing.Size(316, 61);
            this.groupBox_DefaultAlertsetting.TabIndex = 3;
            this.groupBox_DefaultAlertsetting.TabStop = false;
            this.groupBox_DefaultAlertsetting.Text = "기본 경보기 설정";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "경보기 스캔 주기 ( 밀리초 )";
            // 
            // textBox_DefaultAlertInterval
            // 
            this.textBox_DefaultAlertInterval.Location = new System.Drawing.Point(4, 37);
            this.textBox_DefaultAlertInterval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_DefaultAlertInterval.Name = "textBox_DefaultAlertInterval";
            this.textBox_DefaultAlertInterval.Size = new System.Drawing.Size(35, 21);
            this.textBox_DefaultAlertInterval.TabIndex = 1;
            this.textBox_DefaultAlertInterval.Text = "1000";
            this.textBox_DefaultAlertInterval.TextChanged += new System.EventHandler(this.textBox_DefaultAlertInterval_TextChanged);
            // 
            // checkBox_DefaultSettingAlwaysOnTop
            // 
            this.checkBox_DefaultSettingAlwaysOnTop.AutoSize = true;
            this.checkBox_DefaultSettingAlwaysOnTop.Location = new System.Drawing.Point(4, 18);
            this.checkBox_DefaultSettingAlwaysOnTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_DefaultSettingAlwaysOnTop.Name = "checkBox_DefaultSettingAlwaysOnTop";
            this.checkBox_DefaultSettingAlwaysOnTop.Size = new System.Drawing.Size(76, 16);
            this.checkBox_DefaultSettingAlwaysOnTop.TabIndex = 0;
            this.checkBox_DefaultSettingAlwaysOnTop.Text = "항상 위로";
            this.checkBox_DefaultSettingAlwaysOnTop.UseVisualStyleBackColor = true;
            this.checkBox_DefaultSettingAlwaysOnTop.CheckedChanged += new System.EventHandler(this.checkBox_DefaultSettingAlwaysOnTop_CheckedChanged);
            // 
            // groupBox_DefaultAlertModeSetting
            // 
            this.groupBox_DefaultAlertModeSetting.Controls.Add(this.checkBox_DefaultSettingReload);
            this.groupBox_DefaultAlertModeSetting.Controls.Add(this.checkBox_DefaultSettingRat);
            this.groupBox_DefaultAlertModeSetting.Controls.Add(this.checkBox_DefaultSettingNeut);
            this.groupBox_DefaultAlertModeSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_DefaultAlertModeSetting.Location = new System.Drawing.Point(2, 55);
            this.groupBox_DefaultAlertModeSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_DefaultAlertModeSetting.Name = "groupBox_DefaultAlertModeSetting";
            this.groupBox_DefaultAlertModeSetting.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_DefaultAlertModeSetting.Size = new System.Drawing.Size(316, 73);
            this.groupBox_DefaultAlertModeSetting.TabIndex = 1;
            this.groupBox_DefaultAlertModeSetting.TabStop = false;
            this.groupBox_DefaultAlertModeSetting.Text = "기본 경보기 모드 설정";
            // 
            // checkBox_DefaultSettingReload
            // 
            this.checkBox_DefaultSettingReload.AutoSize = true;
            this.checkBox_DefaultSettingReload.Location = new System.Drawing.Point(4, 55);
            this.checkBox_DefaultSettingReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_DefaultSettingReload.Name = "checkBox_DefaultSettingReload";
            this.checkBox_DefaultSettingReload.Size = new System.Drawing.Size(100, 16);
            this.checkBox_DefaultSettingReload.TabIndex = 2;
            this.checkBox_DefaultSettingReload.Text = "재장전 경보기";
            this.checkBox_DefaultSettingReload.UseVisualStyleBackColor = true;
            this.checkBox_DefaultSettingReload.CheckedChanged += new System.EventHandler(this.AlertDefaultTypeSet_CheckBoxHandler);
            // 
            // checkBox_DefaultSettingRat
            // 
            this.checkBox_DefaultSettingRat.AutoSize = true;
            this.checkBox_DefaultSettingRat.Enabled = false;
            this.checkBox_DefaultSettingRat.Location = new System.Drawing.Point(4, 37);
            this.checkBox_DefaultSettingRat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_DefaultSettingRat.Name = "checkBox_DefaultSettingRat";
            this.checkBox_DefaultSettingRat.Size = new System.Drawing.Size(142, 16);
            this.checkBox_DefaultSettingRat.TabIndex = 1;
            this.checkBox_DefaultSettingRat.Text = "랫 경보기 (사용 불가)";
            this.checkBox_DefaultSettingRat.UseVisualStyleBackColor = true;
            this.checkBox_DefaultSettingRat.CheckedChanged += new System.EventHandler(this.AlertDefaultTypeSet_CheckBoxHandler);
            // 
            // checkBox_DefaultSettingNeut
            // 
            this.checkBox_DefaultSettingNeut.AutoSize = true;
            this.checkBox_DefaultSettingNeut.Location = new System.Drawing.Point(4, 18);
            this.checkBox_DefaultSettingNeut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox_DefaultSettingNeut.Name = "checkBox_DefaultSettingNeut";
            this.checkBox_DefaultSettingNeut.Size = new System.Drawing.Size(88, 16);
            this.checkBox_DefaultSettingNeut.TabIndex = 0;
            this.checkBox_DefaultSettingNeut.Text = "뉴트 경보기";
            this.checkBox_DefaultSettingNeut.UseVisualStyleBackColor = true;
            this.checkBox_DefaultSettingNeut.CheckedChanged += new System.EventHandler(this.AlertDefaultTypeSet_CheckBoxHandler);
            // 
            // groupBox_AlertSoundDefault
            // 
            this.groupBox_AlertSoundDefault.Controls.Add(this.textBoxDefaultSoundFileLoc);
            this.groupBox_AlertSoundDefault.Controls.Add(this.button_UsePreInstalledFileAsDefault);
            this.groupBox_AlertSoundDefault.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_AlertSoundDefault.Location = new System.Drawing.Point(2, 16);
            this.groupBox_AlertSoundDefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_AlertSoundDefault.Name = "groupBox_AlertSoundDefault";
            this.groupBox_AlertSoundDefault.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_AlertSoundDefault.Size = new System.Drawing.Size(316, 39);
            this.groupBox_AlertSoundDefault.TabIndex = 0;
            this.groupBox_AlertSoundDefault.TabStop = false;
            this.groupBox_AlertSoundDefault.Text = "기본 사운드파일 설정";
            // 
            // textBoxDefaultSoundFileLoc
            // 
            this.textBoxDefaultSoundFileLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDefaultSoundFileLoc.Location = new System.Drawing.Point(2, 16);
            this.textBoxDefaultSoundFileLoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDefaultSoundFileLoc.Name = "textBoxDefaultSoundFileLoc";
            this.textBoxDefaultSoundFileLoc.ReadOnly = true;
            this.textBoxDefaultSoundFileLoc.Size = new System.Drawing.Size(204, 21);
            this.textBoxDefaultSoundFileLoc.TabIndex = 0;
            this.textBoxDefaultSoundFileLoc.TabStop = false;
            this.textBoxDefaultSoundFileLoc.Text = "자체 파일 사용";
            this.textBoxDefaultSoundFileLoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox_AlertSoundFileLoc_MouseDown);
            // 
            // button_UsePreInstalledFileAsDefault
            // 
            this.button_UsePreInstalledFileAsDefault.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_UsePreInstalledFileAsDefault.Location = new System.Drawing.Point(206, 16);
            this.button_UsePreInstalledFileAsDefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_UsePreInstalledFileAsDefault.Name = "button_UsePreInstalledFileAsDefault";
            this.button_UsePreInstalledFileAsDefault.Size = new System.Drawing.Size(108, 21);
            this.button_UsePreInstalledFileAsDefault.TabIndex = 1;
            this.button_UsePreInstalledFileAsDefault.Text = "내장 사운드 사용";
            this.button_UsePreInstalledFileAsDefault.UseVisualStyleBackColor = true;
            this.button_UsePreInstalledFileAsDefault.Click += new System.EventHandler(this.Button_UsePreInstalledFile_Click);
            // 
            // tabPage_ChangeLog
            // 
            this.tabPage_ChangeLog.Controls.Add(this.textBox_ChangeLog);
            this.tabPage_ChangeLog.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ChangeLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage_ChangeLog.Name = "tabPage_ChangeLog";
            this.tabPage_ChangeLog.Size = new System.Drawing.Size(320, 303);
            this.tabPage_ChangeLog.TabIndex = 3;
            this.tabPage_ChangeLog.Text = "ChangeLog";
            this.tabPage_ChangeLog.UseVisualStyleBackColor = true;
            // 
            // textBox_ChangeLog
            // 
            this.textBox_ChangeLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ChangeLog.Location = new System.Drawing.Point(0, 0);
            this.textBox_ChangeLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ChangeLog.Multiline = true;
            this.textBox_ChangeLog.Name = "textBox_ChangeLog";
            this.textBox_ChangeLog.ReadOnly = true;
            this.textBox_ChangeLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ChangeLog.Size = new System.Drawing.Size(320, 303);
            this.textBox_ChangeLog.TabIndex = 0;
            this.textBox_ChangeLog.Text = resources.GetString("textBox_ChangeLog.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 341);
            this.Controls.Add(this.tabControl_MainControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(348, 6680);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(348, 380);
            this.Name = "MainForm";
            this.Text = "GOPW Alarm Ver ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.tabControl_MainControl.ResumeLayout(false);
            this.tabPage_AlertManage.ResumeLayout(false);
            this.buttonpanel.ResumeLayout(false);
            this.tabPage_AlertSetting.ResumeLayout(false);
            this.tabPage_AlertSetting.PerformLayout();
            this.groupBox_AlertInfomation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.AlertSettingpanel.ResumeLayout(false);
            this.AlertSettingpanel.PerformLayout();
            this.groupBox_SoundFileSetting.ResumeLayout(false);
            this.groupBox_SoundFileSetting.PerformLayout();
            this.groupBox_AlertTypeSet.ResumeLayout(false);
            this.groupBox_AlertTypeSet.PerformLayout();
            this.tabPage_ProgramSetting.ResumeLayout(false);
            this.groupBox_AlertSetting.ResumeLayout(false);
            this.groupBox_AlertSetting.PerformLayout();
            this.groupBox_AlertDefaultSetting.ResumeLayout(false);
            this.groupBox_DefaultAlertsetting.ResumeLayout(false);
            this.groupBox_DefaultAlertsetting.PerformLayout();
            this.groupBox_DefaultAlertModeSetting.ResumeLayout(false);
            this.groupBox_DefaultAlertModeSetting.PerformLayout();
            this.groupBox_AlertSoundDefault.ResumeLayout(false);
            this.groupBox_AlertSoundDefault.PerformLayout();
            this.tabPage_ChangeLog.ResumeLayout(false);
            this.tabPage_ChangeLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_MainControl;
        private System.Windows.Forms.TabPage tabPage_AlertManage;
        private System.Windows.Forms.TabPage tabPage_AlertSetting;
        private System.Windows.Forms.Button button_Execute;
        private System.Windows.Forms.CheckedListBox cLB_NeutAlertLIst;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Terminate;
        private System.Windows.Forms.TabPage tabPage_ProgramSetting;
        private System.Windows.Forms.CheckBox checkBox_AlertSetNeut;
        private System.Windows.Forms.CheckBox checkBox_AlertSetRat;
        private System.Windows.Forms.CheckBox checkBox_AlertSetReload;
        private System.Windows.Forms.GroupBox groupBox_AlertTypeSet;
        private System.Windows.Forms.GroupBox groupBox_AlertInfomation;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox_SoundFileSetting;
        private System.Windows.Forms.TextBox textBox_AlertSoundFileLoc;
        private System.Windows.Forms.GroupBox groupBox_AlertDefaultSetting;
        private System.Windows.Forms.GroupBox groupBox_AlertSoundDefault;
        private System.Windows.Forms.Button button_UsePreInstalledFileAsDefault;
        private System.Windows.Forms.TextBox textBoxDefaultSoundFileLoc;
        private System.Windows.Forms.GroupBox groupBox_DefaultAlertModeSetting;
        private System.Windows.Forms.CheckBox checkBox_DefaultSettingReload;
        private System.Windows.Forms.CheckBox checkBox_DefaultSettingRat;
        private System.Windows.Forms.CheckBox checkBox_DefaultSettingNeut;
        private System.Windows.Forms.TabPage tabPage_ChangeLog;
        private System.Windows.Forms.TextBox textBox_ChangeLog;
        private System.Windows.Forms.Button button_UsePreInstalledFile;
        private System.Windows.Forms.Panel buttonpanel;
        private System.Windows.Forms.Panel AlertSettingpanel;
        private System.Windows.Forms.CheckBox checkBox_TopMost;
        private System.Windows.Forms.GroupBox groupBox_DefaultAlertsetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DefaultAlertInterval;
        private System.Windows.Forms.CheckBox checkBox_DefaultSettingAlwaysOnTop;
        private System.Windows.Forms.GroupBox groupBox_AlertSetting;
        private System.Windows.Forms.CheckBox checkBox_AlertAutoUpdateCheck;
        private System.Windows.Forms.CheckBox checkBox_AlertAlwaysOnTop;
    }
}

