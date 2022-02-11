namespace SUPERPAINT
{
    partial class ImageSizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wBox1 = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.hBox2 = new System.Windows.Forms.NumericUpDown();
            this.ImgName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hlabel2 = new System.Windows.Forms.Label();
            this.wlabel1 = new System.Windows.Forms.Label();
            this.Cncel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // wBox1
            // 
            this.wBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wBox1.Location = new System.Drawing.Point(82, 95);
            this.wBox1.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.wBox1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wBox1.Name = "wBox1";
            this.wBox1.Size = new System.Drawing.Size(84, 26);
            this.wBox1.TabIndex = 8;
            this.wBox1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.hBox2);
            this.splitContainer1.Panel1.Controls.Add(this.wBox1);
            this.splitContainer1.Panel1.Controls.Add(this.ImgName);
            this.splitContainer1.Panel1.Controls.Add(this.name);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.hlabel2);
            this.splitContainer1.Panel1.Controls.Add(this.wlabel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Cncel);
            this.splitContainer1.Panel2.Controls.Add(this.OK);
            this.splitContainer1.Size = new System.Drawing.Size(209, 244);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 1;
            // 
            // hBox2
            // 
            this.hBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hBox2.Location = new System.Drawing.Point(82, 130);
            this.hBox2.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.hBox2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hBox2.Name = "hBox2";
            this.hBox2.Size = new System.Drawing.Size(84, 26);
            this.hBox2.TabIndex = 9;
            this.hBox2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ImgName
            // 
            this.ImgName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImgName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ImgName.Location = new System.Drawing.Point(0, 0);
            this.ImgName.MaximumSize = new System.Drawing.Size(0, 50);
            this.ImgName.Name = "ImgName";
            this.ImgName.Size = new System.Drawing.Size(209, 50);
            this.ImgName.TabIndex = 7;
            this.ImgName.Text = "Image";
            this.ImgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.name.Location = new System.Drawing.Point(49, 60);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(117, 20);
            this.name.TabIndex = 6;
            this.name.Text = "Set image size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(172, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "px";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(172, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "px";
            // 
            // hlabel2
            // 
            this.hlabel2.AutoSize = true;
            this.hlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hlabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hlabel2.Location = new System.Drawing.Point(14, 132);
            this.hlabel2.Name = "hlabel2";
            this.hlabel2.Size = new System.Drawing.Size(60, 20);
            this.hlabel2.TabIndex = 2;
            this.hlabel2.Text = "Height:";
            // 
            // wlabel1
            // 
            this.wlabel1.AutoSize = true;
            this.wlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wlabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wlabel1.Location = new System.Drawing.Point(12, 100);
            this.wlabel1.Name = "wlabel1";
            this.wlabel1.Size = new System.Drawing.Size(54, 20);
            this.wlabel1.TabIndex = 0;
            this.wlabel1.Text = "Width:";
            // 
            // Cncel
            // 
            this.Cncel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cncel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cncel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cncel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cncel.Location = new System.Drawing.Point(115, 8);
            this.Cncel.Name = "Cncel";
            this.Cncel.Size = new System.Drawing.Size(82, 37);
            this.Cncel.TabIndex = 1;
            this.Cncel.Text = "Cancel";
            this.Cncel.UseVisualStyleBackColor = false;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OK.Location = new System.Drawing.Point(12, 8);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(82, 37);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ImageSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(209, 244);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ImageSizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImageSizeForm";
            this.Load += new System.EventHandler(this.ImageSizeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown wBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown hBox2;
        private System.Windows.Forms.Label ImgName;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hlabel2;
        private System.Windows.Forms.Label wlabel1;
        private System.Windows.Forms.Button Cncel;
        private System.Windows.Forms.Button OK;
    }
}