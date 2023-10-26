using System;

namespace GOPW.Alarm
{
    partial class InputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textboxInput = new System.Windows.Forms.TextBox();
            this.label_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Confirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(246, 65);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirm.Name = "button_Confirm";
            this.buttonConfirm.Size = new System.Drawing.Size(107, 34);
            this.buttonConfirm.TabIndex = 0;
            this.buttonConfirm.Text = global::GOPW.Alarm.Properties.Resources.Button_Confirm_Text;
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirmClick);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(361, 65);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(107, 34);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = global::GOPW.Alarm.Properties.Resources.Button_Cancel_Text;
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // textBox_Input
            // 
            this.textboxInput.Location = new System.Drawing.Point(12, 30);
            this.textboxInput.Name = "textBox_Input";
            this.textboxInput.Size = new System.Drawing.Size(457, 28);
            this.textboxInput.TabIndex = 2;
            this.textboxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            this.textboxInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxInput_KeyUp);
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(12, 9);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(0, 18);
            this.label_text.TabIndex = 3;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 112);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.textboxInput);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.buttonConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textboxInput;
        internal System.Windows.Forms.Label label_text;
    }
}