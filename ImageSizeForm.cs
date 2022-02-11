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
    public partial class ImageSizeForm : Form
    {
        public DocForm doc { get; set; }
        Bitmap newBit;
        public ImageSizeForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            newBit = new Bitmap((int)wBox1.Value, (int)hBox2.Value);
            Graphics g = Graphics.FromImage(newBit);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(doc.bitmap, 0, 0, (int)wBox1.Value, (int)hBox2.Value);
            Invalidate();
            newBit.SetResolution(doc.bitmap.HorizontalResolution, doc.bitmap.VerticalResolution);
            doc.bitmap = newBit;
            doc.pictureBox1.Size = new Size(newBit.Width, newBit.Height);
            Close();
        }

        private void ImageSizeForm_Load(object sender, EventArgs e)
        {
            ImgName.Text = doc.fileName;
            hBox2.Value = doc.bitmap.Height;
            wBox1.Value = doc.bitmap.Width;
        }
    }
}
