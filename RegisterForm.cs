using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace just_pl
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.Width = 956;
            this.Height = 720;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int windowWidth = this.Width;
            int windowHeight = this.Height;
            int x = (screenWidth - windowWidth) / 2;
            int y = (screenHeight - windowHeight) / 2;
            this.Location = new Point(x, y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            if (logintext.Text == "")
            {
                logintext.BorderColor = Color.Red;
                return;
            }
            if(textBox1.Text == "")
            {
                textBox1.BorderColor = Color.Red;
                return;
            }

            if (checkUSer())
                return;

        
            Db db = new Db();
            MySqlCommand command = new MySqlCommand("Insert INTO users (login, password) VALUES (@login, @pass)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = logintext.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox1.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                Launcher launcher = new Launcher();
                launcher.Login = logintext.Text;
                launcher.Show();
            }
            else
                MessageBox.Show("No account");



            db.closeConnection();
        }

        public Boolean checkUSer()
        {
            Db db = new Db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = logintext.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This username already exists, please enter another one");
                return true;
            }
            else
                return false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
