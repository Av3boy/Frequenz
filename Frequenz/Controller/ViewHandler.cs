using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frequenz.Controller
{
    public class ViewHandler
    {

        public ViewHandler()
        {

        }

        public bool RetrieveLogin(string email, string emailPassword)
        {
            try
            {
                var fromAddress = new MailAddress(email, "From Frequenz");
                var toAddress = new MailAddress(email, "To Name");
                string fromPassword = emailPassword;
                const string subject = "Frequenz Password Reset";

                string newPass = RandomPassword();
                string body = "Your new password has been generated: " + newPass + ". <br><br> Thank you for using Frequenz!";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                MessageBox.Show("Email sent successfully!");
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        string RandomPassword()
        {

            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
