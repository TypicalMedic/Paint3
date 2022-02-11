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
    public partial class CanvasSizeForm : Form
    {
        public DocForm doc { get; set; }
        public CanvasSizeForm()
        {
            InitializeComponent();
        }

        private void CanvasSizeForm_Load(object sender, EventArgs e)
        {
            ImgName.Text = doc.fileName;
            hBox2.Value = doc.bitmap.Height;
            wBox1.Value = doc.bitmap.Width;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OKbutton1_Click(object sender, EventArgs e)
        {
            Bitmap newBit = new Bitmap((int)wBox1.Value, (int)hBox2.Value);
            newBit.SetResolution(doc.bitmap.HorizontalResolution, doc.bitmap.VerticalResolution);
            Graphics g = Graphics.FromImage(newBit);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(doc.bitmap, 0, 0);
            Invalidate();
            doc.bitmap = newBit;
            doc.pictureBox1.Size = new Size(newBit.Width, newBit.Height);
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void Cncel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImgName_Click(object sender, EventArgs e)
        {

        }
    }
}