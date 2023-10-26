using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GOPW.Alarm
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 임베디드 dll 사용하기 위해 설정
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {

                Assembly thisAssembly = Assembly.GetExecutingAssembly();

                //Get the Name of the AssemblyFile
                var name = args.Name.Substring(0, args.Name.IndexOf(',')) + ".dll";

                //Load form Embedded Resources - This Function is not called if the Assembly is in the Application Folder
                var resources = thisAssembly.GetManifestResourceNames().Where(s => s.EndsWith(name));
                if (resources.Count() > 0)
                {
                    var resourceName = resources.First();
                    using (Stream stream = thisAssembly.GetManifestResourceStream(resourceName))
                    {
                        if (stream == null) return null;
                        var block = new byte[stream.Length];
                        stream.Read(block, 0, block.Length);
                        return Assembly.Load(block);
                    }
                }
                return null;
            };
            // ==============================


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class ListboxData
    {
        public string Value { get; set; }

        public string Text { get; set; }
    }

    internal class CaptureLib
    {
        //internal static readonly IntPtr;
        internal const int SW_MAXIMIZE = 3;

        internal System.Drawing.Bitmap CaptureWindow(IntPtr hWnd)
        {
            System.Drawing.Rectangle rctForm = System.Drawing.Rectangle.Empty;
            using (System.Drawing.Graphics grfx = System.Drawing.Graphics.FromHdc(NativeMethods.GetWindowDC(hWnd)))
            {
                rctForm = System.Drawing.Rectangle.Round(grfx.VisibleClipBounds);
            }
            if (rctForm.Width == 0 | rctForm.Height == 0)
            {
                return null;
            }
            System.Drawing.Bitmap pImage = new System.Drawing.Bitmap(rctForm.Width, rctForm.Height);
            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(pImage);
            IntPtr hDC = graphics.GetHdc();
            try
            {
                if (Environment.OSVersion.Version.Major.ToString() + Environment.OSVersion.Version.Minor.ToString() == "62")
                    NativeMethods.PrintWindow(hWnd, hDC, 0x2);
                else
                    NativeMethods.PrintWindow(hWnd, hDC, 0);
                //PrintWindow(hWnd, hDC, (uint)0);
            }
            finally
            {
                graphics.ReleaseHdc(hDC);
            }
            GC.Collect(0, GCCollectionMode.Optimized);
            GC.WaitForPendingFinalizers();
            return pImage;
        }
    }

    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);
        [DllImport("user32.dll")]
        internal static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("User32.dll")]
        internal static extern IntPtr SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    }
}
