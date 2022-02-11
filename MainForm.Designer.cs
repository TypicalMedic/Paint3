namespace SUPERPAINT
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canvasSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topToBottomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.brush = new System.Windows.Forms.ToolStripButton();
            this.eraser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.line = new System.Windows.Forms.ToolStripButton();
            this.ellipse = new System.Windows.Forms.ToolStripButton();
            this.star = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Yellow = new System.Windows.Forms.ToolStripButton();
            this.Blue = new System.Windows.Forms.ToolStripButton();
            this.Green = new System.Windows.Forms.ToolStripButton();
            this.Red = new System.Windows.Forms.ToolStripButton();
            this.Black = new System.Windows.Forms.ToolStripButton();
            this.Gray = new System.Windows.Forms.ToolStripButton();
            this.White = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.bSize = new System.Windows.Forms.NumericUpDown();
            this.lineSizeT = new System.Windows.Forms.TrackBar();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.scale = new System.Windows.Forms.ToolStripLabel();
            this.upS = new System.Windows.Forms.ToolStripButton();
            this.downS = new System.Windows.Forms.ToolStripButton();
            this.pos = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.selC = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineSizeT)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 29);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownOpening += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpening);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.newToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.openToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canvasSizeToolStripMenuItem,
            this.imageSizeToolStripMenuItem});
            this.imageToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.imageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imageToolStripMenuItem.Image")));
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.DropDownOpening += new System.EventHandler(this.imageToolStripMenuItem_DropDownOpening);
            // 
            // canvasSizeToolStripMenuItem
            // 
            this.canvasSizeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.canvasSizeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvasSizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("canvasSizeToolStripMenuItem.Image")));
            this.canvasSizeToolStripMenuItem.Name = "canvasSizeToolStripMenuItem";
            this.canvasSizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.canvasSizeToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.canvasSizeToolStripMenuItem.Text = "Canvas size...";
            this.canvasSizeToolStripMenuItem.Click += new System.EventHandler(this.canvasSizeToolStripMenuItem_Click);
            // 
            // imageSizeToolStripMenuItem
            // 
            this.imageSizeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imageSizeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.imageSizeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imageSizeToolStripMenuItem.Image")));
            this.imageSizeToolStripMenuItem.Name = "imageSizeToolStripMenuItem";
            this.imageSizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.I)));
            this.imageSizeToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.imageSizeToolStripMenuItem.Text = "Image size...";
            this.imageSizeToolStripMenuItem.Click += new System.EventHandler(this.imageSizeToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.topToBottomToolStripMenuItem,
            this.leftToRightToolStripMenuItem,
            this.organizeIconsToolStripMenuItem});
            this.windowToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.windowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("windowToolStripMenuItem.Image")));
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.windowToolStripMenuItem.Text = "Window";
            this.windowToolStripMenuItem.DropDownOpening += new System.EventHandler(this.windowToolStripMenuItem_DropDownOpening);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cascadeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // topToBottomToolStripMenuItem
            // 
            this.topToBottomToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.topToBottomToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.topToBottomToolStripMenuItem.Name = "topToBottomToolStripMenuItem";
            this.topToBottomToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.topToBottomToolStripMenuItem.Text = "Top to bottom";
            this.topToBottomToolStripMenuItem.Click += new System.EventHandler(this.topToBottomToolStripMenuItem_Click);
            // 
            // leftToRightToolStripMenuItem
            // 
            this.leftToRightToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.leftToRightToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.leftToRightToolStripMenuItem.Name = "leftToRightToolStripMenuItem";
            this.leftToRightToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.leftToRightToolStripMenuItem.Text = "Left to right";
            this.leftToRightToolStripMenuItem.Click += new System.EventHandler(this.leftToRightToolStripMenuItem_Click);
            // 
            // organizeIconsToolStripMenuItem
            // 
            this.organizeIconsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.organizeIconsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.organizeIconsToolStripMenuItem.Name = "organizeIconsToolStripMenuItem";
            this.organizeIconsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.organizeIconsToolStripMenuItem.Text = "Arrange icons";
            this.organizeIconsToolStripMenuItem.Click += new System.EventHandler(this.organizeIconsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brush,
            this.eraser,
            this.toolStripSeparator4,
            this.line,
            this.ellipse,
            this.star,
            this.toolStripSeparator3,
            this.Yellow,
            this.Blue,
            this.Green,
            this.Red,
            this.Black,
            this.Gray,
            this.White,
            this.toolStripButton8,
            this.selC});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 63);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(42, 543);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // brush
            // 
            this.brush.Checked = true;
            this.brush.CheckState = System.Windows.Forms.CheckState.Checked;
            this.brush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brush.Enabled = false;
            this.brush.Image = ((System.Drawing.Image)(resources.GetObject("brush.Image")));
            this.brush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brush.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(36, 29);
            this.brush.Text = "toolStripButton2";
            this.brush.Click += new System.EventHandler(this.brush_Click);
            // 
            // eraser
            // 
            this.eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eraser.Enabled = false;
            this.eraser.Image = ((System.Drawing.Image)(resources.GetObject("eraser.Image")));
            this.eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraser.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(36, 29);
            this.eraser.Text = "toolStripButton3";
            this.eraser.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(30, 6);
            // 
            // line
            // 
            this.line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.line.Enabled = false;
            this.line.ForeColor = System.Drawing.SystemColors.Control;
            this.line.Image = ((System.Drawing.Image)(resources.GetObject("line.Image")));
            this.line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.line.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(36, 29);
            this.line.Text = "toolStripButton1";
            this.line.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ellipse
            // 
            this.ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipse.Enabled = false;
            this.ellipse.Image = ((System.Drawing.Image)(resources.GetObject("ellipse.Image")));
            this.ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipse.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(36, 29);
            this.ellipse.Text = "toolStripButton1";
            this.ellipse.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // star
            // 
            this.star.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.star.Enabled = false;
            this.star.Image = ((System.Drawing.Image)(resources.GetObject("star.Image")));
            this.star.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.star.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(36, 29);
            this.star.Text = "toolStripButton2";
            this.star.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(30, 6);
            // 
            // Yellow
            // 
            this.Yellow.AutoSize = false;
            this.Yellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Yellow.Image = ((System.Drawing.Image)(resources.GetObject("Yellow.Image")));
            this.Yellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(25, 23);
            this.Yellow.Text = "toolStripButton7";
            this.Yellow.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // Blue
            // 
            this.Blue.AutoSize = false;
            this.Blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Blue.Image = ((System.Drawing.Image)(resources.GetObject("Blue.Image")));
            this.Blue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(25, 23);
            this.Blue.Text = "toolStripButton6";
            this.Blue.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // Green
            // 
            this.Green.AutoSize = false;
            this.Green.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Green.Image = ((System.Drawing.Image)(resources.GetObject("Green.Image")));
            this.Green.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(25, 23);
            this.Green.Text = "toolStripButton5";
            this.Green.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // Red
            // 
            this.Red.AutoSize = false;
            this.Red.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Red.Image = ((System.Drawing.Image)(resources.GetObject("Red.Image")));
            this.Red.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(25, 23);
            this.Red.Text = "toolStripButton4";
            this.Red.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // Black
            // 
            this.Black.AutoSize = false;
            this.Black.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Black.Image = ((System.Drawing.Image)(resources.GetObject("Black.Image")));
            this.Black.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(25, 23);
            this.Black.Text = "toolStripButton3";
            this.Black.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // Gray
            // 
            this.Gray.AutoSize = false;
            this.Gray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Gray.Image = ((System.Drawing.Image)(resources.GetObject("Gray.Image")));
            this.Gray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(25, 23);
            this.Gray.Text = "toolStripButton2";
            this.Gray.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // White
            // 
            this.White.AutoSize = false;
            this.White.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.White.Image = ((System.Drawing.Image)(resources.GetObject("White.Image")));
            this.White.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(25, 23);
            this.White.Text = "toolStripButton1";
            this.White.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.AutoSize = false;
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Margin = new System.Windows.Forms.Padding(0, 10, 10, 2);
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripButton8.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.ToolTipText = "Other color...";
            this.toolStripButton8.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // bSize
            // 
            this.bSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bSize.ForeColor = System.Drawing.SystemColors.Window;
            this.bSize.Location = new System.Drawing.Point(203, 37);
            this.bSize.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.bSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bSize.Name = "bSize";
            this.bSize.Size = new System.Drawing.Size(51, 20);
            this.bSize.TabIndex = 4;
            this.bSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.bSize.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lineSizeT
            // 
            this.lineSizeT.AutoSize = false;
            this.lineSizeT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lineSizeT.Location = new System.Drawing.Point(62, 36);
            this.lineSizeT.Maximum = 200;
            this.lineSizeT.Minimum = 1;
            this.lineSizeT.Name = "lineSizeT";
            this.lineSizeT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lineSizeT.Size = new System.Drawing.Size(140, 26);
            this.lineSizeT.TabIndex = 5;
            this.lineSizeT.TickFrequency = 0;
            this.lineSizeT.TickStyle = System.Windows.Forms.TickStyle.None;
            this.lineSizeT.Value = 3;
            this.lineSizeT.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scale,
            this.upS,
            this.downS,
            this.pos});
            this.toolStrip2.Location = new System.Drawing.Point(0, 606);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(846, 27);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // scale
            // 
            this.scale.Image = ((System.Drawing.Image)(resources.GetObject("scale.Image")));
            this.scale.Name = "scale";
            this.scale.Size = new System.Drawing.Size(56, 24);
            this.scale.Text = "scale ";
            // 
            // upS
            // 
            this.upS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.upS.Enabled = false;
            this.upS.Image = ((System.Drawing.Image)(resources.GetObject("upS.Image")));
            this.upS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.upS.Name = "upS";
            this.upS.Size = new System.Drawing.Size(24, 24);
            this.upS.Text = "toolStripButton1";
            this.upS.Click += new System.EventHandler(this.upS_Click);
            // 
            // downS
            // 
            this.downS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.downS.Enabled = false;
            this.downS.Image = ((System.Drawing.Image)(resources.GetObject("downS.Image")));
            this.downS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.downS.Name = "downS";
            this.downS.Size = new System.Drawing.Size(24, 24);
            this.downS.Text = "toolStripButton2";
            this.downS.Click += new System.EventHandler(this.downS_Click);
            // 
            // pos
            // 
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(28, 24);
            this.pos.Text = "x: y:";
            // 
            // toolStrip3
            // 
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip3.Location = new System.Drawing.Point(0, 33);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(846, 30);
            this.toolStrip3.TabIndex = 12;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 27);
            this.toolStripLabel1.Text = "Line size:";
            // 
            // selC
            // 
            this.selC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selC.Enabled = false;
            this.selC.ForeColor = System.Drawing.SystemColors.Control;
            this.selC.Image = ((System.Drawing.Image)(resources.GetObject("selC.Image")));
            this.selC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selC.Name = "selC";
            this.selC.Size = new System.Drawing.Size(40, 29);
            this.selC.Text = "toolStripButton9";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(846, 633);
            this.Controls.Add(this.lineSizeT);
            this.Controls.Add(this.bSize);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(300, 160);
            this.Name = "MainForm";
            this.Text = "Paint 2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineSizeT)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canvasSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToBottomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem imageSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel scale;
        public System.Windows.Forms.ToolStripLabel pos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public System.Windows.Forms.ToolStripButton star;
        public System.Windows.Forms.ToolStripButton line;
        public System.Windows.Forms.ToolStripButton brush;
        public System.Windows.Forms.ToolStripButton ellipse;
        public System.Windows.Forms.NumericUpDown bSize;
        public System.Windows.Forms.TrackBar lineSizeT;
        public System.Windows.Forms.ToolStripButton eraser;
        public System.Windows.Forms.ToolStripButton upS;
        public System.Windows.Forms.ToolStripButton downS;
        private System.Windows.Forms.ToolStripButton White;
        private System.Windows.Forms.ToolStripButton Gray;
        private System.Windows.Forms.ToolStripButton Black;
        private System.Windows.Forms.ToolStripButton Red;
        private System.Windows.Forms.ToolStripButton Green;
        private System.Windows.Forms.ToolStripButton Blue;
        private System.Windows.Forms.ToolStripButton Yellow;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton selC;
    }
}

