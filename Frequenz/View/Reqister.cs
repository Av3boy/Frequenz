using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frequenz.Controller;

namespace Frequenz
{
    public partial class Reqister : Form
    {
        public Reqister()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Login();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Reqister_Click(object sender, EventArgs e)
        {
            DatabaseHandler handler = new DatabaseHandler();
            handler.Reqister(textBox_Username.Text, textBox_email.Text, textBox_password.Text);
        }
    }
}
