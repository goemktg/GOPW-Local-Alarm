namespace GOPW.Alarm.Forms
{
    partial class Scaner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scaner));
            this.pictureBox_Preview = new System.Windows.Forms.PictureBox();
            this.label_StatusText = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.textBox_ProcessSelect = new System.Windows.Forms.TextBox();
            this.button_SetAreaAndReset = new System.Windows.Forms.Button();
            this.maintimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_Preview
            // 
            this.pictureBox_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Preview.Location = new System.Drawing.Point(0, 19);
            this.pictureBox_Preview.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Preview.Name = "pictureBox_Preview";
            this.pictureBox_Preview.Size = new System.Drawing.Size(360, 201);
            this.pictureBox_Preview.TabIndex = 0;
            this.pictureBox_Preview.TabStop = false;
            // 
            // label_StatusText
            // 
            this.label_StatusText.AutoSize = true;
            this.label_StatusText.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_StatusText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_StatusText.Location = new System.Drawing.Point(264, 0);
            this.label_StatusText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_StatusText.Name = "label_StatusText";
            this.label_StatusText.Size = new System.Drawing.Size(48, 12);
            this.label_StatusText.TabIndex = 1;
            this.label_StatusText.Text = "Status :";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Status.Location = new System.Drawing.Point(312, 0);
            this.label_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(48, 12);
            this.label_Status.TabIndex = 2;
            this.label_Status.Text = "prepare";
            // 
            // textBox_ProcessSelect
            // 
            this.textBox_ProcessSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ProcessSelect.Location = new System.Drawing.Point(0, 0);
            this.textBox_ProcessSelect.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ProcessSelect.Name = "textBox_ProcessSelect";
            this.textBox_ProcessSelect.Size = new System.Drawing.Size(264, 21);
            this.textBox_ProcessSelect.TabIndex = 3;
            this.textBox_ProcessSelect.Text = "여기를 클릭하세요.";
            this.textBox_ProcessSelect.Click += new System.EventHandler(this.TextBox_ProcessSelect_Click);
            // 
            // button_SetAreaAndReset
            // 
            this.button_SetAreaAndReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_SetAreaAndReset.Enabled = false;
            this.button_SetAreaAndReset.Location = new System.Drawing.Point(197, 0);
            this.button_SetAreaAndReset.Margin = new System.Windows.Forms.Padding(2);
            this.button_SetAreaAndReset.Name = "button_SetAreaAndReset";
            this.button_SetAreaAndReset.Size = new System.Drawing.Size(67, 19);
            this.button_SetAreaAndReset.TabIndex = 4;
            this.button_SetAreaAndReset.Text = global::GOPW.Alarm.Properties.Resources.Text_Area_Setting;
            this.button_SetAreaAndReset.UseVisualStyleBackColor = true;
            this.button_SetAreaAndReset.Click += new System.EventHandler(this.Button_SetArea_Click);
            // 
            // maintimer
            // 
            this.maintimer.Interval = 1000;
            this.maintimer.Tick += new System.EventHandler(this.Maintimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_SetAreaAndReset);
            this.panel1.Controls.Add(this.textBox_ProcessSelect);
            this.panel1.Controls.Add(this.label_StatusText);
            this.panel1.Controls.Add(this.label_Status);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 19);
            this.panel1.TabIndex = 5;
            // 
            // Scaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 220);
            this.Controls.Add(this.pictureBox_Preview);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(376, 259);
            this.Name = "Scaner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scaner_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Scaner_FormClosed);
            this.Load += new System.EventHandler(this.Scaner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Preview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Preview;
        private System.Windows.Forms.Label label_StatusText;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.TextBox textBox_ProcessSelect;
        private System.Windows.Forms.Button button_SetAreaAndReset;
        private System.Windows.Forms.Timer maintimer;
        private System.Windows.Forms.Panel panel1;
    }
}