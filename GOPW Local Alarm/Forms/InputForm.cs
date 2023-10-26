using System;
using System.Windows.Forms;

namespace GOPW.Alarm
{
    public partial class InputForm : Form
    {
        internal delegate void TextEventHandler(string text);
        internal event TextEventHandler WriteTextEvent;

        public InputForm()
        {
            InitializeComponent();

            ActiveControl = textboxInput;
            textboxInput.Focus();
        }

        private void ButtonConfirmClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxInput.Text))
            {
                MessageBox.Show(Properties.Resources.Error_Scaner_Name_Cannot_be_empty,
                            Properties.Resources.Error_Error,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            } else
            {
                WriteTextEvent(textboxInput.Text);
                Close();
                Dispose();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & textboxInput.Text != "")
            {
                buttonConfirm.PerformClick();
            }
        }
        
        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            if (textboxInput.Text.Contains("|") | textboxInput.Text.Contains("#"))
            {
                MessageBox.Show(Properties.Resources.Error_Scaner_Name_Cannot_include_special_letter,
                            Properties.Resources.Error_Error,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                textboxInput.Text = "";
            } 
        }
    }
}
