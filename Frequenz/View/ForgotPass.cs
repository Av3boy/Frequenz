using Frequenz.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frequenz
{
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            ViewHandler handler = new ViewHandler();
            handler.RetrieveLogin(textBox_email.Text, textBox_password.Text);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Login();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
