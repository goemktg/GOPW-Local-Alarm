using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOPW.Alarm.Forms
{
    public partial class Updater : Form
    {
        private delegate void CSafeSetText(string text);
        private delegate void CSafeSetMaximum(Int32 value);
        private delegate void CSafeSetValue(Int32 value);

        private CSafeSetText csst;
        private CSafeSetMaximum cssm;
        private WebClient wc;
        private bool setBaseSize;

        public Updater()
        {
            // 대리자를 초기화한다.
            csst = new CSafeSetText(CrossSafeSetTextMethod);
            cssm = new CSafeSetMaximum(CrossSafeSetMaximumMethod);
            //cssv = new CSafeSetValue(CrossSafeSetValueMethod);

            // 웹 클라이언트 개체를 초기화하고,
            wc = new WebClient();

            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadCompleted);
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(FileDownloadProgressChanged);

            InitializeComponent();

            // 파일이 저장될 위치를 저장한다.
            String fileName = String.Format("{0}\\{1}", Directory.GetCurrentDirectory(), AppDomain.CurrentDomain.FriendlyName);
            //MessageBox.Show("1");

            string _Filestr = Directory.GetCurrentDirectory() + "\\" + "gopwalarm_exe_updated";
            System.IO.FileInfo fi = new System.IO.FileInfo(_Filestr);
            if (fi.Exists)
            {
                fi.Delete();
            }

            // 원래 파일 이름 변경
            string path = Directory.GetCurrentDirectory() + "\\" + AppDomain.CurrentDomain.FriendlyName;
            FileInfo file = new FileInfo(path);
            file.MoveTo(Directory.GetCurrentDirectory() + "\\" + "gopwalarm_exe_updated");
            //MessageBox.Show(path);

            //try
            //{
                // C 드라이브 밑의 downloadFiles 폴더에 파일 이름대로 저장한다.
                wc.DownloadFileAsync(new Uri(Properties.Resources.Address_UpdateTarget), fileName);

                // 다운로드 중이라는걸 알리기 위한 값을 설정하고,
                // 프로그레스바의 크기를 0으로 만든다.
                progressBar.Value = 0;
                setBaseSize = false;
           // }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, ex.GetType().FullName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        void CrossSafeSetValueMethod(Int32 value)
        {
            if (progressBar.InvokeRequired)
                progressBar.Invoke(cssm, value);
            else
                progressBar.Value = value;
        }
        void CrossSafeSetMaximumMethod(Int32 value)
        {
            if (progressBar.InvokeRequired)
                progressBar.Invoke(cssm, value);
            else
                progressBar.Maximum = value;
        }
        void CrossSafeSetTextMethod(String text)
        {
            if (this.InvokeRequired)
                this.Invoke(csst, text);
            else
            {
                label.Text = text;
                label.Left = (this.ClientSize.Width - label.Width) / 2;
                label.Top = (this.ClientSize.Height - label.Height) / 2;
            }
        }

        void FileDownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            // e.BytesReceived
            //   받은 데이터의 크기를 저장합니다.

            // e.TotalBytesToReceive
            //   받아야 할 모든 데이터의 크기를 저장합니다.

            // 프로그레스바의 최대 크기가 정해지지 않은 경우,
            // 받아야 할 최대 데이터 량으로 설정한다.
            if (!setBaseSize)
            {
                CrossSafeSetMaximumMethod((int)e.TotalBytesToReceive);
                setBaseSize = true;
            }

            // 받은 데이터 량을 나타낸다.
            CrossSafeSetValueMethod((int)e.BytesReceived);

            // 받은 데이터 / 받아야할 데이터 (퍼센트) 로 나타낸다.
            CrossSafeSetTextMethod(e.BytesReceived + " / " + e.TotalBytesToReceive + " " + "(" + Math.Truncate(e.BytesReceived / (double)e.TotalBytesToReceive) * 100 + ")");
            //CrossSafeSetTextMethod(string.Format("{0:N0} / {1:N0} ({2:P})", , e.TotalBytesToReceive, (Double)e.BytesReceived / (double)e.TotalBytesToReceive));
        }

        void FileDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
           Process.Start(Directory.GetCurrentDirectory() + "\\" + AppDomain.CurrentDomain.FriendlyName);
           Application.Exit();
        }
    }
}