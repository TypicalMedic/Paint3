using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum Tools { brush, line, ellipse, eraser, star };
namespace SUPERPAINT
{
    public partial class MainForm : Form
    {
        public static Color color { get; set; }
        public static int width { get; set; }
        public static Tools tool { get; set; }
        public static int count { get; set; }
        public static int pks { get; set; }
        public static double prc { get; set; }
        ToolStripButton currentTool;
        public MainForm()
        {
            InitializeComponent();
            color = Color.Black;
            width = 3;
            tool = Tools.brush;
            count = 1;
            pks = 5;
            prc = 0.5;
            currentTool = brush;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "PNG files (*.png)|*.png| JPEG files (*.jpg)|*.jpg| Windows Bitmap (*.bmp)|*.bmp| Все файлы ()*.*|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var frm = new DocForm();
                frm.MdiParent = this;

                using (var filePath = new FileStream(dlg.FileName, FileMode.Open))
                    frm.bitmap = new Bitmap(filePath);
                frm.bitmap.SetResolution(96, 96);
                frm.savedInFile = true;
                frm.fileName = dlg.FileName;
                frm.Text = dlg.FileName;
                frm.Show();
                star.Enabled = true;
                ellipse.Enabled = true;
                line.Enabled = true;
                eraser.Enabled = true;
                brush.Enabled = true;
                upS.Enabled = true;
                downS.Enabled = true;
            }

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new DocForm();
            frm.MdiParent = this;
            frm.Text = "Img " + count;
            frm.fileName = frm.Text;
            count++;
            frm.Show();
            star.Enabled = true;
            ellipse.Enabled = true;
            line.Enabled = true;
            eraser.Enabled = true;
            brush.Enabled = true;
            upS.Enabled = true;
            downS.Enabled = true;
        }

        private void imageToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            canvasSizeToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
            imageSizeToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }

        private void canvasSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocForm doc = ActiveMdiChild as DocForm;
            var cnvF = new CanvasSizeForm();
            cnvF.doc = doc;
            cnvF.ShowDialog();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Green;
            selC.BackColor = color;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Red;
            selC.BackColor = color;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
            selC.BackColor = color;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImg(ActiveMdiChild as DocForm);
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
            saveToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocForm dfrm = ActiveMdiChild as DocForm;
            Bitmap bmp = dfrm.bitmap;
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.AddExtension = true;
            dlg.Filter = "PNG files (*.png)|*.png| Windows Bitmap (*.bmp)|*.bmp| JPEG files (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(dlg.FileName);
                dfrm.fileName = dlg.FileName;
                dfrm.savedInFile = true;
                dfrm.areChangesSaved = true;
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void leftToRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void topToBottomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void organizeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!currentTool.Equals(sender))
            {
                tool = Tools.line;
                line.Checked = true;
                currentTool.Checked = false;
                currentTool = line;
            }
        }

        private void brush_Click(object sender, EventArgs e)
        {
            if (!currentTool.Equals(sender))
            {
                tool = Tools.brush;
                brush.Checked = true;
                currentTool.Checked = false;
                currentTool = brush;
            }
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                color = cd.Color;
                selC.BackColor = color;
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void windowToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            cascadeToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
            topToBottomToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
            leftToRightToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
            organizeIconsToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }
        public static bool SaveImg(DocForm pic)
        {
            DocForm dfrm = pic;
            Bitmap bmp = dfrm.bitmap;
            if (dfrm.savedInFile)
            {
                bmp.Save(dfrm.fileName);
                dfrm.areChangesSaved = true;
                return true;
            }
            else
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.AddExtension = true;
                dlg.Filter = "PNG files (*.png)|*.png| Windows Bitmap (*.bmp)|*.bmp| JPEG files (*.jpg)|*.jpg";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(dlg.FileName);
                    dfrm.fileName = dlg.FileName;
                    dfrm.savedInFile = true;
                    dfrm.areChangesSaved = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            width = (int)bSize.Value;
            lineSizeT.Value = (int)bSize.Value;
        }

        private void imageSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocForm doc = ActiveMdiChild as DocForm;
            ImageSizeForm frm = new ImageSizeForm();
            frm.doc = doc;
            frm.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (!currentTool.Equals(sender))
            {
                tool = Tools.ellipse;
                ellipse.Checked = true;
                currentTool.Checked = false;
                currentTool = ellipse;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            bSize.Value = lineSizeT.Value;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (!currentTool.Equals(sender))
            {
                tool = Tools.eraser;
                eraser.Checked = true;
                currentTool.Checked = false;
                currentTool = eraser;
            }
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            DocForm docForm = ActiveMdiChild as DocForm;
            if (docForm != null)
            {
                scale.Text = docForm.scale*100 + "%";
            }
        }

        private void upS_Click(object sender, EventArgs e)
        {
            DocForm docForm = ActiveMdiChild as DocForm;
            docForm.scale *= 2;
            docForm.bitmap.SetResolution(96 / (docForm.scale ), 96 / (docForm.scale ));
            docForm.pictureBox1.Size = new Size((int)(docForm.bitmap.Width * docForm.scale ),
                (int)(docForm.bitmap.Height * docForm.scale ));
            Invalidate();
            scale.Text = docForm.scale * 100 + "%";
        }

        private void downS_Click(object sender, EventArgs e)
        {
            DocForm docForm = ActiveMdiChild as DocForm;
            docForm.scale /= 2;
            docForm.bitmap.SetResolution(96 / docForm.scale , 96 / docForm.scale );
            docForm.pictureBox1.Size = new Size((int)(docForm.bitmap.Width * docForm.scale ),
                (int)(docForm.bitmap.Height * docForm.scale ));
            Invalidate();
            scale.Text = docForm.scale*100 + "%";
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!currentTool.Equals(sender))
            {
                tool = Tools.star;
                star.Checked = true;
                currentTool.Checked = false;
                currentTool = star;
            }
            starF frm = new starF();
            frm.ShowDialog();
        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            color = Color.Black;
            selC.BackColor = color;
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            color = Color.Gray;
            selC.BackColor = color;
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            color = Color.White;
            selC.BackColor = color;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
            selC.BackColor = color;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void selC_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
