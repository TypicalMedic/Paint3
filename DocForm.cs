using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SUPERPAINT
{
    public partial class DocForm : Form
    {
        public int x { get; set; }
        public int y { get; set; }
        public Bitmap bitmap { get; set; }
        public bool savedInFile { get; set; }
        public bool areChangesSaved { get; set; }
        public string fileName { get; set; }
        public ImageFormat fileFormat { get; set; }
        bool shiftPressed = false;
        public float scale { get; set; }
        private void DocForm_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            areChangesSaved = false;
        }

        private void DocForm_MouseMove(object sender, MouseEventArgs e)
        {
            MainForm main = MdiParent as MainForm;
            string posx = bitmap.Width.ToString();
            string posy = bitmap.Height.ToString();
            if ((int)Math.Round(e.X / scale) <= bitmap.Width)
            {
                posx = e.X.ToString();
            }
            if (e.Y <= bitmap.Height)
            {
                posy = e.Y.ToString();
            }
            main.pos.Text = "x: " + posx + " y: " + posy;
            if (e.Button == MouseButtons.Left)
            {
                switch (MainForm.tool)
                {
                    case Tools.brush:
                        {
                            Graphics g = Graphics.FromImage(bitmap);
                            g.ScaleTransform(1 / scale, 1 / scale);
                            // g.FillEllipse(new SolidBrush(MainForm.color), e.X, e.Y, MainForm.width * scale, MainForm.width * (scale / 100));
                            g.DrawLine(new Pen(MainForm.color, MainForm.width * scale), x, y, e.X, e.Y);
                            pictureBox1.Invalidate();
                            x = e.X;
                            y = e.Y;
                            break;
                        }
                    case Tools.line:
                        {
                            Refresh();
                            Graphics g = pictureBox1.CreateGraphics();
                            g.DrawLine(new Pen(MainForm.color, MainForm.width *scale ), x, y, e.X, e.Y);
                            break;
                        }
                    case Tools.ellipse:
                        {
                            Refresh();
                            Graphics g = pictureBox1.CreateGraphics();
                            if (shiftPressed)
                            {
                                g.DrawEllipse(new Pen(MainForm.color, MainForm.width *scale), x, y, e.X - x, e.X - x);
                            }
                            else
                            {
                                g.DrawEllipse(new Pen(MainForm.color, MainForm.width * scale), x, y, e.X - x, e.Y - y);
                            }
                            break;
                        }
                    case Tools.eraser:
                        {
                            Bitmap b = new Bitmap(bitmap);//saving unchanged bmp in the new variable
                            b.SetResolution(bitmap.HorizontalResolution, bitmap.VerticalResolution);
                            bitmap = new Bitmap(b.Width, b.Height);//creating clean canvas and assinging it to picturebox
                            bitmap.SetResolution(b.HorizontalResolution, b.VerticalResolution);
                            Graphics g = Graphics.FromImage(bitmap);//new graphics from empty canvas
                            g.ScaleTransform(1 / scale, 1/ scale);//offsetting brush to the set scale
                            g.ExcludeClip(new Rectangle(e.X - (int)(MainForm.width * scale / 2), e.Y - (int)(MainForm.width *scale / 2),
                                (int)(MainForm.width * scale), (int)(MainForm.width * scale)));//deleting area that we dont want to redraw on the new bmp
                            g.DrawImage(b, 0, 0, b.Width * scale , b.Height * scale );//redrawing old bmp without selected chunk
                            pictureBox1.Invalidate();
                            //this creates eraser effect even though we dont "erase" but draw the old picture without a certain piece
                            break;
                        }
                    case Tools.star:
                        {
                            Refresh();
                            Graphics g = pictureBox1.CreateGraphics();
                            double r = Math.Sqrt((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y)); //calculating star radius
                            double ang = Math.Asin((e.Y - y) / r); //calculating star rotation
                            Point[] p = GenerateStar(MainForm.pks, r, r * MainForm.prc, x, y, ang);
                            g.DrawPolygon(new Pen(MainForm.color, MainForm.width * scale), p);
                            break;
                        }
                }


            }
        }
        /// <summary>
        /// Calculates coordinates of the star's outer and inner peaks based on entered parameters
        /// </summary>
        /// <param name="peaks">Amount of outer peaks</param>
        /// <param name="oR">Outer star radius</param>
        /// <param name="iR">Inner star radius</param>
        /// <param name="posX">Star's center X position</param>
        /// <param name="posY">Star's center Y position</param>
        /// <param name="offsetAngle">Rotation</param>
        /// <returns></returns>
        public static Point[] GenerateStar(int peaks, double oR, double iR, int posX, int posY, double offsetAngle)
        {
            int n = peaks, count = 0;
            double rOut = oR, rIn = iR;
            double alpha, angle, x, y;
            alpha = 360;
            Point[] points = new Point[n * 2]; //we put both outer and inner peaks' coordinates in one array alternately
            Point point;
            for (int i = 0; i < n; i++)
            {
                angle = alpha * i * Math.PI / 180 / n + offsetAngle;//we divide full circle into n peaks and for each peak calculate its offset angle from  
                x = rOut * Math.Sin(angle) + posX;
                y = -rOut * Math.Cos(angle) + posY;
                point = new Point((int)Math.Round(x), (int)Math.Round(y));
                points[count] = point;
                count++;
                angle = alpha * (i + 0.5) * Math.PI / 180 / n + offsetAngle;
                x = rIn * Math.Sin(angle) + posX;
                y = -rIn * Math.Cos(angle) + posY;
                point = new Point((int)Math.Round(x), (int)Math.Round(y));
                points[count] = point;
                count++;
            }
            return points;
        }
        private void DocForm_MouseUp(object sender, MouseEventArgs e)
        {
            switch (MainForm.tool)
            {
                case Tools.brush:
                    {
                        break;
                    }
                case Tools.line:
                    {
                        Graphics g = Graphics.FromImage(bitmap);
                        g.ScaleTransform(1 / (scale ), 1 / scale);
                        g.DrawLine(new Pen(MainForm.color, MainForm.width * scale ), x, y, e.X, e.Y);
                        x = e.X;
                        y = e.Y;
                        Invalidate();
                        break;
                    }
                case Tools.ellipse:
                    {
                        Graphics g = Graphics.FromImage(bitmap);
                        g.ScaleTransform(1 / scale, 1 / scale);
                        if (shiftPressed)
                        {
                            g.DrawEllipse(new Pen(MainForm.color, MainForm.width * scale ), x, y, e.X - x, e.X - x);
                        }
                        else
                        {
                            g.DrawEllipse(new Pen(MainForm.color, MainForm.width * scale ), x, y, e.X - x, e.Y - y);
                        }
                        x = e.X;
                        y = e.Y;
                        Invalidate();
                        break;
                    }
                case Tools.star:
                    {
                        Graphics g = Graphics.FromImage(bitmap);
                        g.ScaleTransform(1 / scale, 1 / scale );
                        double r = Math.Sqrt((e.X - x) * (e.X - x) + (e.Y - y) * (e.Y - y));
                        double ang = Math.Asin((e.Y - y) / r);
                        Point[] p = GenerateStar(MainForm.pks, r, r * MainForm.prc, x, y, ang);
                        g.DrawPolygon(new Pen(MainForm.color, MainForm.width * scale ), p);
                        x = e.X;
                        y = e.Y;
                        Invalidate();
                        break;
                    }
            }
        }

        public DocForm()
        {
            InitializeComponent();
            savedInFile = false;
            areChangesSaved = true;
            bitmap = new Bitmap(250, 250);
            scale = 1;
            pictureBox1.Paint += new PaintEventHandler(this.pictureBox1_Paint); //adding new listener (in our case a picture box) to tha paint event to later draw on top of the picturebox

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                shiftPressed = true;
            }
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            shiftPressed = false;
        }
        private void DocForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!areChangesSaved)
            {
                save frm = new save();
                frm.fileName = this.Text;
                DialogResult res = frm.ShowDialog();
                if (res == DialogResult.Yes)
                {
                    if (!MainForm.SaveImg(this))
                    {
                        e.Cancel = true;
                    };
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void DocForm_Load(object sender, System.EventArgs e)
        {
            pictureBox1.Size = new Size(bitmap.Width, bitmap.Height);
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor; //to get clear pixels with the scale
            e.Graphics.DrawImage(bitmap, 0, 0); //draws the bitmap on top the picture box's image(scaled)
        }
        private void DocForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm f = MdiParent as MainForm;
            if (f.MdiChildren.Length == 1)
            {
                f.star.Enabled = false;
                f.ellipse.Enabled = false;
                f.line.Enabled = false;
                f.eraser.Enabled = false;
                f.brush.Enabled = false;
                f.upS.Enabled = false;
                f.downS.Enabled = false;
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.ScrollToControl(this);
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
        }
    }
}
