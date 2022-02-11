namespace SUPERPAINT
{
    partial class save
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
            this.Cncel = new System.Windows.Forms.Button();
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cncel
            // 
            this.Cncel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cncel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cncel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cncel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cncel.Location = new System.Drawing.Point(249, 133);
            this.Cncel.Name = "Cncel";
            this.Cncel.Size = new System.Drawing.Size(82, 37);
            this.Cncel.TabIndex = 3;
            this.Cncel.Text = "Cancel";
            this.Cncel.UseVisualStyleBackColor = false;
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yes.Location = new System.Drawing.Point(12, 133);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(82, 37);
            this.yes.TabIndex = 2;
            this.yes.Text = "Yes";
            this.yes.UseVisualStyleBackColor = false;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.no.DialogResult = System.Windows.Forms.DialogResult.No;
            this.no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.no.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.no.Location = new System.Drawing.Point(100, 133);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(82, 37);
            this.no.TabIndex = 4;
            this.no.Text = "No";
            this.no.UseVisualStyleBackColor = false;
            this.no.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.name.Location = new System.Drawing.Point(0, 0);
            this.name.MaximumSize = new System.Drawing.Size(359, 100);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.name.Size = new System.Drawing.Size(343, 100);
            this.name.TabIndex = 7;
            this.name.Text = "The file \r\nhas not been saved. \r\nSave it?";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.Cncel;
            this.ClientSize = new System.Drawing.Size(343, 184);
            this.Controls.Add(this.name);
            this.Controls.Add(this.no);
            this.Controls.Add(this.Cncel);
            this.Controls.Add(this.yes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "save";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "save";
            this.Load += new System.EventHandler(this.save_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cncel;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Label name;
    }
}