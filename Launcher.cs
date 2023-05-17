using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace just_pl
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            images = new Image[]
            {
                Image.FromFile(@"C:\Users\vladb\Downloads\flp_brd.png"), 
                Image.FromFile(@"C:\Users\vladb\Downloads\snk.png"), 
                Image.FromFile(@"C:\Users\vladb\Downloads\zmb.png"), 
                Image.FromFile(@"C:\Users\vladb\Downloads\act.png"), 
                Image.FromFile(@"C:\Users\vladb\Downloads\carRac.png"), 
                Image.FromFile(@"C:\Users\vladb\Downloads\ct.png"), 
                Image.FromFile(@"C:\Users\vladb\Downloads\fjs.png"),
                Image.FromFile(@"C:\Users\vladb\Downloads\helc.png"),
                Image.FromFile(@"C:\Users\vladb\Downloads\rps.png"),
                Image.FromFile(@"C:\Users\vladb\Downloads\trex.png")
            };
            screengame.Image = images[currentPage];
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
        private int maxPages = 9;
        private Image[] images;
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < maxPages - 1) 
            {
                currentPage++;
                screengame.Image = images[currentPage]; 
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
                screengame.Image = images[currentPage];
                btnNext.Visible = true;
                
            }

            
            btnNext.Enabled = true;

            if (currentPage == 0)
            {
                btnPrev.Visible = false;
            }
        }
        private void UpdateButton()
        {
            switch (currentPage)
            {
                case 0:
                    Process.Start(@"FlappyBird\Flappy Bird Windows Form"); 
                    break;
                case 1:
                    Process.Start(@"Snake\Snake.exe"); 
                    break;
                case 3:
                    Process.Start(@"ZombieShooter\Shoot Out Game MOO ICT"); 
                    break;
                case 4:
                    Process.Start(@"ActionGame\Side Scrolling Game MOO ICT"); 
                    break;
                case 6:
                    Process.Start(@"CarRacing\Car Racing Game MOO ICT"); 
                    break;
                case 7:
                    Process.Start(@"CityDefense\CityDefense"); 
                    break;
                case 8:
                    Process.Start(@"Fighter Jet Shooting\Fighter Jet Shooting Game MOO ICT");
                break;
                case 9:
                    Process.Start(@"Helicopter Shooter\Helicopter Shooter Game MOO ICT");
                    break;
                case 10:
                    Process.Start(@"Rock Paper Scissors\rock");
                    break;
                case 11:
                    Process.Start(@"TRex Runner\T Rex Endless Runner MOO ICT");
                    break;
              
            }
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;


        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = SystemColors.Control;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            UpdateButton();
            
        }

    }
    
}
