using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOPW.Alarm.Forms
{
    public partial class UpdateAsk : Form
    {
        internal string LatestVersion;
        internal string NowVersion;

        public UpdateAsk()
        {
            InitializeComponent();
        }
        
        // 패치 내역을 받아옴
        private static List<string> GetPatchNote()
        {
            List<string> PatchNote = new List<string> { };

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            //var filename = Assembly.GetExecutingAssembly().Location;
            //var version = System.Diagnostics.FileVersionInfo.GetVersionInfo(filename).FileVersion;

            var req = System.Net.WebRequest.CreateHttp(Properties.Resources.Address_PatchnoteString);

            using (var res = req.GetResponse())
            {
                var stream = res.GetResponseStream();
                try
                {
                    using (var reader = new StreamReader(stream, Encoding.Default))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            PatchNote.Add(line);
                            //System.Console.WriteLine(line);
                        }
                    }
                }
                finally
                {
                    if (stream != null)
                        ((IDisposable)stream).Dispose();
                }
            }

            return PatchNote;
        }

        private void UpdateAsk_Load(object sender, EventArgs e)
        {
            textBox_Patchnote.Lines = GetPatchNote().ToArray();

            label_CurrentVersion.Text = Properties.Resources.Label_CurrentVersion + NowVersion;
            label_LatestVersion.Text = Properties.Resources.Label_LatestVersion + LatestVersion;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            Updater updater = new Updater();
            updater.ShowDialog();
        }
    }
}
