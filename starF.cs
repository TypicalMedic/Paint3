using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPERPAINT
{
    public partial class starF : Form
    {
        Bitmap bitmap;
        Point[] star;
        public starF()
        {
            InitializeComponent();
            percents.Value = (int)(MainForm.prc * 100);
            peaks.Value = MainForm.pks;
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            star = DocForm.GenerateStar((int)peaks.Value, 100, 100 * (int)percents.Value / 100, panel1.Width / 2, panel1.Height / 2, 0);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawPolygon(new Pen(MainForm.color, MainForm.width), star);
            Invalidate();
        }


        private void starF_Load(object sender, EventArgs e)
        {

        }

        private void wBox1_ValueChanged(object sender, EventArgs e)
        {
            MainForm.pks = (int)peaks.Value;
            star = DocForm.GenerateStar((int)peaks.Value, 100, 100 * (int)percents.Value / 100, panel1.Width / 2, panel1.Height / 2, 0);
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawPolygon(new Pen(MainForm.color, MainForm.width), star);
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(bitmap, panel1.Location.X, panel1.Location.Y);
        }

        private void perc_ValueChanged(object sender, EventArgs e)
        {
            percents.Value = perc.Value;
            MainForm.prc = (double)percents.Value / 100;
        }

        private void percents_ValueChanged(object sender, EventArgs e)
        {
            perc.Value = (int)percents.Value;
            MainForm.prc = (double)percents.Value / 100;
            star = DocForm.GenerateStar((int)peaks.Value, 100, 100 * (int)percents.Value / 100, panel1.Width / 2, panel1.Height / 2, 0);
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawPolygon(new Pen(MainForm.color, MainForm.width), star);
            Invalidate();
        }

        private void Cncel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //docForm.peaksAmount = (int)peaks.Value;
            //docForm.innerRadiusPerc = (double)perc.Value / 100;
        }
    }
}
