using Frequenz.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frequenz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            DatabaseHandler handler = new DatabaseHandler();
            if (!handler.CheckUserCredentials(textBox_email.Text, textBox_password.Text))
            {
                if (checkBox_stayLoggedIn.Enabled)
                {
                    string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                    string config = Path.Combine(path, "config.txt");
                    string text = File.ReadAllText(config);
                    text = text.Replace("false", "true");
                    File.WriteAllText(config, text);
                }

                this.Hide();
                var form2 = new Frequenz();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
                MessageBox.Show("Error logging in. Please check your credentials");
        }

        private void Reqister_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Reqister();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Forgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new ForgotPass();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
