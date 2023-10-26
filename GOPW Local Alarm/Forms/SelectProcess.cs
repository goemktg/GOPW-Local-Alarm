using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GOPW.Alarm.Forms
{
    public partial class SelectProcess : Form
    {
        internal delegate void EventHandler(Process process, string text);
        internal event EventHandler WriteClientSelectFin;

        public SelectProcess()
        {
            InitializeComponent();

            Process[] processesByName = Process.GetProcessesByName("exefile");
            //Process[] processesByName = Process.GetProcessesByName("notepad");
            List<ListboxData> listboxDataList = new List<ListboxData>();
            foreach (Process process in processesByName)
            {
                listboxDataList.Add(new ListboxData()
                {
                    Value = process.Id.ToString(),
                    Text = process.MainWindowTitle
                });
                //MessageBox.Show(process.MainWindowTitle);
            }
            listBox_ClientList.DisplayMember = "Text";
            listBox_ClientList.DataSource = listboxDataList;
        }

        private void listBox_ClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pictureBox_ClientPreview.Image != null)
                pictureBox_ClientPreview.Dispose();
            Process p = Process.GetProcessById(int.Parse((listBox_ClientList.SelectedItem as ListboxData).Value));
            IntPtr windowHandle = p.MainWindowHandle;
            var Capture = new CaptureLib();
            Bitmap bmp = Capture.CaptureWindow(windowHandle);
            pictureBox_ClientPreview.Image = bmp;
            pictureBox_ClientPreview.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void listBox_ClientList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_ClientList.IndexFromPoint(e.Location) == -1)
                return;
            WriteClientSelectFin(Process.GetProcessById(int.Parse((listBox_ClientList.SelectedItem as ListboxData).Value)), (listBox_ClientList.SelectedItem as ListboxData).Text);
            
            pictureBox_ClientPreview.Dispose();

            //GC.Collect();
            GC.WaitForPendingFinalizers();

            Dispose();
            Close();
        }
    }
}
