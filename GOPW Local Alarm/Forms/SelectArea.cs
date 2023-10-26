using AForge.Imaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOPW.Alarm.Forms
{
    public partial class SelectArea : Form
    {
        private bool Drawing = false;
        internal delegate void EventHandler(int xstart, int xend, int ystart, int yend);
        internal event EventHandler WriteAreaSelectFin;
        internal Bitmap bitmap;
        private Bitmap OriginalImage;
        private Bitmap DisplayImage;
        private Graphics DisplayGraphics;
        private Point StartPoint;
        private Point EndPoint;

        private int xstart;
        private int xend;
        private int ystart;
        private int yend;

        public SelectArea()
        {
            InitializeComponent();
        }

        private void pictureBox_SelectArea_MouseDown(object sender, MouseEventArgs e)
        {
            Drawing = true;
            StartPoint = e.Location;
            DrawSelectionBox(e.Location);
        }

        private void pictureBox_SelectArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Drawing)
                return;
            DrawSelectionBox(e.Location);
        }

        private void pictureBox_SelectArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Drawing)
                return;
            Drawing = false;
            /*
            scaner.isareaset = 1;                  X
            scaner.status = 1;                     X
            
            scaner.TopMost = scaner.allwaystop;
            */
            WriteAreaSelectFin(xstart,xend,ystart,yend);
            OriginalImage.Dispose();
            DisplayImage.Dispose();
            bitmap.Dispose();
            DisplayGraphics.Dispose();
            Close();
            Dispose();
        }
        
        internal void DrawSelectionBox(Point end_point)
        {
            label_SelectArea.Text = StartPoint.X.ToString() + Properties.Resources.Text_Space + EndPoint.X.ToString() + Properties.Resources.Text_Space + StartPoint.Y.ToString() + Properties.Resources.Text_Space + EndPoint.Y.ToString();

            EndPoint = end_point;

            if (EndPoint.X < StartPoint.X)
                EndPoint.X = StartPoint.X + 10;
            if (EndPoint.X < 0)
                EndPoint.X = 0;
            if (EndPoint.X >= OriginalImage.Width)
                EndPoint.X = OriginalImage.Width - 1;

            if (EndPoint.Y < StartPoint.Y)
                EndPoint.Y = StartPoint.Y + 10;
            if (EndPoint.Y < 0)
                EndPoint.Y = 0;
            if (EndPoint.Y >= OriginalImage.Height)
                EndPoint.Y = OriginalImage.Height - 1;
            
            xstart = StartPoint.X;
            xend = EndPoint.X;
            ystart = StartPoint.Y;
            yend = EndPoint.Y;

            DisplayGraphics.DrawImageUnscaled(OriginalImage, 0, 0);
            DisplayGraphics.DrawRectangle(Pens.Red, Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y), Math.Abs(StartPoint.X - EndPoint.X), Math.Abs(StartPoint.Y - EndPoint.Y));
            pictureBox_SelectArea.Refresh();
        }

        private void Select_Area_Load(object sender, EventArgs e)
        {
            OriginalImage = bitmap;
            DisplayImage = OriginalImage.Clone() as Bitmap;
            DisplayGraphics = Graphics.FromImage(DisplayImage);
            pictureBox_SelectArea.Image = DisplayImage;
            pictureBox_SelectArea.SizeMode = PictureBoxSizeMode.AutoSize;

            if (Size.Height > SystemInformation.VirtualScreen.Height)
                pictureBox_SelectArea.Height = SystemInformation.VirtualScreen.Height -50;
            if (Size.Width > SystemInformation.VirtualScreen.Width)
                pictureBox_SelectArea.Width = SystemInformation.VirtualScreen.Width -100;
            Location = new Point(10,10);
        }
    }
}
