using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_08._09
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.DeepPink, 18);
            button1.Paint += Button1_Paint;
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            pen = new Pen(Color.DeepPink, 16);
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            pen = new Pen(Color.DarkTurquoise, 16);
        }

        private void Button1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            GraphicsPath path = new GraphicsPath();

            Point[] points =
            {
                new Point(40, 20),
                new Point(120, 20),
                new Point(140, 50),
                new Point(120, 80),
                new Point(40, 80),
                new Point(20, 50),
            };

            path.AddPolygon(points);
            g.DrawPolygon(pen, points);
            g.DrawString("Push me", Font, Brushes.DimGray, 55, 43);

            Region region = new Region(path);
            button1.Region = region;
        }

        Pen pen;
    }
}
