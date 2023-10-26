namespace GOPW.Alarm.Forms
{
    partial class SelectArea
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
            this.pictureBox_SelectArea = new System.Windows.Forms.PictureBox();
            this.label_SelectArea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SelectArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_SelectArea
            // 
            this.pictureBox_SelectArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_SelectArea.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_SelectArea.Name = "pictureBox_SelectArea";
            this.pictureBox_SelectArea.Size = new System.Drawing.Size(800, 450);
            this.pictureBox_SelectArea.TabIndex = 0;
            this.pictureBox_SelectArea.TabStop = false;
            this.pictureBox_SelectArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_SelectArea_MouseDown);
            this.pictureBox_SelectArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_SelectArea_MouseMove);
            this.pictureBox_SelectArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_SelectArea_MouseUp);
            // 
            // label_SelectArea
            // 
            this.label_SelectArea.AutoSize = true;
            this.label_SelectArea.Location = new System.Drawing.Point(13, 12);
            this.label_SelectArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SelectArea.Name = "label_SelectArea";
            this.label_SelectArea.Size = new System.Drawing.Size(0, 18);
            this.label_SelectArea.TabIndex = 3;
            // 
            // SelectArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_SelectArea);
            this.Controls.Add(this.pictureBox_SelectArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectArea";
            this.Load += new System.EventHandler(this.Select_Area_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SelectArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_SelectArea;
        private System.Windows.Forms.Label label_SelectArea;
    }
}