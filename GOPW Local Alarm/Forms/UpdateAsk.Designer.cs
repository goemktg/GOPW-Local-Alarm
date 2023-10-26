namespace GOPW.Alarm.Forms
{
    partial class UpdateAsk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAsk));
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.gb_PatchNote = new System.Windows.Forms.GroupBox();
            this.textBox_Patchnote = new System.Windows.Forms.TextBox();
            this.label_LatestVersion = new System.Windows.Forms.Label();
            this.label_CurrentVersion = new System.Windows.Forms.Label();
            this.lab_NewVerAvailAlert = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.gb_PatchNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(517, 84);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(99, 34);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = global::GOPW.Alarm.Properties.Resources.Button_Update_Text;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(643, 84);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(99, 34);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = global::GOPW.Alarm.Properties.Resources.Button_Close_Text;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // gb_PatchNote
            // 
            this.gb_PatchNote.Controls.Add(this.textBox_Patchnote);
            this.gb_PatchNote.Location = new System.Drawing.Point(12, 114);
            this.gb_PatchNote.Name = "gb_PatchNote";
            this.gb_PatchNote.Size = new System.Drawing.Size(736, 314);
            this.gb_PatchNote.TabIndex = 11;
            this.gb_PatchNote.TabStop = false;
            this.gb_PatchNote.Text = "패치 노트";
            // 
            // textBox_Patchnote
            // 
            this.textBox_Patchnote.Location = new System.Drawing.Point(6, 27);
            this.textBox_Patchnote.Multiline = true;
            this.textBox_Patchnote.Name = "textBox_Patchnote";
            this.textBox_Patchnote.ReadOnly = true;
            this.textBox_Patchnote.Size = new System.Drawing.Size(746, 297);
            this.textBox_Patchnote.TabIndex = 0;
            // 
            // label_LatestVersion
            // 
            this.label_LatestVersion.AutoSize = true;
            this.label_LatestVersion.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_LatestVersion.Location = new System.Drawing.Point(114, 84);
            this.label_LatestVersion.Name = "label_LatestVersion";
            this.label_LatestVersion.Size = new System.Drawing.Size(112, 18);
            this.label_LatestVersion.TabIndex = 10;
            this.label_LatestVersion.Text = "최신 버전 : ";
            // 
            // label_CurrentVersion
            // 
            this.label_CurrentVersion.AutoSize = true;
            this.label_CurrentVersion.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_CurrentVersion.Location = new System.Drawing.Point(114, 52);
            this.label_CurrentVersion.Name = "label_CurrentVersion";
            this.label_CurrentVersion.Size = new System.Drawing.Size(112, 18);
            this.label_CurrentVersion.TabIndex = 9;
            this.label_CurrentVersion.Text = "현재 버전 : ";
            // 
            // lab_NewVerAvailAlert
            // 
            this.lab_NewVerAvailAlert.AutoSize = true;
            this.lab_NewVerAvailAlert.Cursor = System.Windows.Forms.Cursors.Default;
            this.lab_NewVerAvailAlert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lab_NewVerAvailAlert.Location = new System.Drawing.Point(114, 22);
            this.lab_NewVerAvailAlert.Name = "lab_NewVerAvailAlert";
            this.lab_NewVerAvailAlert.Size = new System.Drawing.Size(634, 18);
            this.lab_NewVerAvailAlert.TabIndex = 8;
            this.lab_NewVerAvailAlert.Text = "새로운 버전의 고퓨 알람을 사용할 수 있습니다. 업데이트 하시겠습니까?";
            // 
            // pb_Logo
            // 
            this.pb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_Logo.Image")));
            this.pb_Logo.Location = new System.Drawing.Point(12, 12);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(96, 96);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 6;
            this.pb_Logo.TabStop = false;
            // 
            // UpdateAsk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.gb_PatchNote);
            this.Controls.Add(this.label_LatestVersion);
            this.Controls.Add(this.label_CurrentVersion);
            this.Controls.Add(this.lab_NewVerAvailAlert);
            this.Controls.Add(this.pb_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateAsk";
            this.Text = "고퓨 경보기 업데이트";
            this.Load += new System.EventHandler(this.UpdateAsk_Load);
            this.gb_PatchNote.ResumeLayout(false);
            this.gb_PatchNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox gb_PatchNote;
        private System.Windows.Forms.TextBox textBox_Patchnote;
        private System.Windows.Forms.Label label_LatestVersion;
        private System.Windows.Forms.Label label_CurrentVersion;
        private System.Windows.Forms.Label lab_NewVerAvailAlert;
        private System.Windows.Forms.PictureBox pb_Logo;
    }
}