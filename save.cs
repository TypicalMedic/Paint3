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
    public partial class save : Form
    {
        public string fileName { get; set; }
        public save()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void save_Load(object sender, EventArgs e)
        {
            name.Text = fileName + "\nhas not been saved. \n Save it?";
        }

        private void yes_Click(object sender, EventArgs e)
        {

        }
    }
}
