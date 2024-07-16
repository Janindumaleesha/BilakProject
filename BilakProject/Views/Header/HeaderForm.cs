using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilakProject.Views.Header
{
    public partial class HeaderForm : Form
    {
        public HeaderForm()
        {
            InitializeComponent();
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExpanPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
