namespace GOPW.Alarm.Forms
{
    partial class SelectProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProcess));
            this.listBox_ClientList = new System.Windows.Forms.ListBox();
            this.label_SelectEVEClientText = new System.Windows.Forms.Label();
            this.pictureBox_ClientPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClientPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_ClientList
            // 
            this.listBox_ClientList.FormattingEnabled = true;
            this.listBox_ClientList.ItemHeight = 18;
            this.listBox_ClientList.Location = new System.Drawing.Point(12, 30);
            this.listBox_ClientList.Name = "listBox_ClientList";
            this.listBox_ClientList.Size = new System.Drawing.Size(477, 166);
            this.listBox_ClientList.TabIndex = 0;
            this.listBox_ClientList.SelectedIndexChanged += new System.EventHandler(this.listBox_ClientList_SelectedIndexChanged);
            this.listBox_ClientList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_ClientList_MouseDoubleClick);
            // 
            // label_SelectEVEClientText
            // 
            this.label_SelectEVEClientText.AutoSize = true;
            this.label_SelectEVEClientText.Font = new System.Drawing.Font("굴림", 9F);
            this.label_SelectEVEClientText.Location = new System.Drawing.Point(9, 9);
            this.label_SelectEVEClientText.Name = "label_SelectEVEClientText";
            this.label_SelectEVEClientText.Size = new System.Drawing.Size(320, 18);
            this.label_SelectEVEClientText.TabIndex = 1;
            this.label_SelectEVEClientText.Text = Properties.Resources.Message_Please_Select_EVE_Client;
            // 
            // pictureBox_ClientPreview
            // 
            this.pictureBox_ClientPreview.Location = new System.Drawing.Point(12, 202);
            this.pictureBox_ClientPreview.Name = "pictureBox_ClientPreview";
            this.pictureBox_ClientPreview.Size = new System.Drawing.Size(480, 270);
            this.pictureBox_ClientPreview.TabIndex = 2;
            this.pictureBox_ClientPreview.TabStop = false;
            // 
            // SelectProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 479);
            this.Controls.Add(this.pictureBox_ClientPreview);
            this.Controls.Add(this.label_SelectEVEClientText);
            this.Controls.Add(this.listBox_ClientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectProcess";
            this.Text = Properties.Resources.Text_Select_Cilent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ClientPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_ClientList;
        private System.Windows.Forms.Label label_SelectEVEClientText;
        private System.Windows.Forms.PictureBox pictureBox_ClientPreview;
    }
}