using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilakProject.Views.Login
{
    public partial class AccessRecoveryPasswordForm : Form
    {
        public AccessRecoveryPasswordForm()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RecoveryPasswordForm recoveryPasswordForm = new RecoveryPasswordForm();
            recoveryPasswordForm.Show();
            this.Hide();
        }
    }
}
