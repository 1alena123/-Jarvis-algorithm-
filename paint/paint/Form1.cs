using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        private Graphics graph;
        Color cur = Color.Black;
        List<Point> points;

        public Form1()
        {
            InitializeComponent();
            graph = panel1.CreateGraphics();
            points = new List<Point>();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cur = colorDialog1.Color;  
            }
        }

      private void panel1_MouseDown(object sender, MouseEventArgs e)
        {   
            SolidBrush myBrush = new SolidBrush(cur);
            points.Add(new Point(e.X, e.Y));
            graph.FillRectangle(myBrush, e.X, e.Y,trackBar1.Value,trackBar1.Value);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(cur, trackBar1.Value);      
            Program program = new Program();
            List<Point> new_points = Program.ConvexHull(points);
            Point[] pn = new Point[new_points.Count];
            for (int i = 0; i < new_points.Count; i++)
            {
                pn[i] = new_points[i];
            }
            graph.DrawPolygon(pen, pn);
            points.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        panel1.Refresh();
        }
    }
}
