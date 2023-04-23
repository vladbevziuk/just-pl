using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
        public string Login { get; set;}

        private void Launcher_Load(object sender, EventArgs e)
        {
            label1.Text = Login;
        }
        private int currentPage = 0;
        private int maxPages = 12;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < maxPages - 1) 
            {
                currentPage++;
            }
            btnPrev.Visible = true;
            
            if (currentPage == maxPages - 1) 
            {
                btnNext.Visible = false;    
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                
            }

            
            btnNext.Enabled = true;

            if (currentPage == 0)
            {
                btnPrev.Visible = false;
            }
        }
    }
    
}
