using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace just_pl
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Process.Start(@"Snake\Snake.exe");
        }
    }
}
