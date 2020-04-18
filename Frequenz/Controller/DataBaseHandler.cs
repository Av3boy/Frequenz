using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net;

namespace Frequenz.Controller
{
    public class DatabaseHandler
    {
        MySqlConnection connection;
        private static ServerUtils server;
        public string connString = "datasource="+server.host+";port="+ server.port +";username="+ server.username +";password="+ server.password + ";database="+ server.database +";";

        public DatabaseHandler()
        {
            //connect to database
            connection = new MySqlConnection(connString);
            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                //MessageBox.Show("connected");
            }
        }

        public List<Song> GetAllSongs()
        {
            List<Song> songList = new List<Song>();
            MySqlCommand cmd = new MySqlCommand("Select * From frequenz_songs", connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Song song = new Song();

                song.id = reader.GetInt32("id");
                song.songname = reader.GetString("songName");
                song.duration = reader.GetInt32("duration");

                string artistName = reader.GetString("artist");

                MySqlCommand artistcmd = new MySqlCommand("select * from frequenz_artists where artistName = @artistName", connection);
                MySqlDataReader artistReader = artistcmd.ExecuteReader();
                Artist artist = new Artist();
                while (reader.Read()) 
                {
                    artist.Id = reader.GetInt32("id");
                    artist.ArtistName = reader.GetString("artistName");
                    song.artist = artist;
                }
            }

            connection.Close();
            return songList;
        }

        public bool Reqister(string username, string password, string email)
        {
            MySqlCommand cmd = new MySqlCommand("Insert into Frequenz_Users (username, password, email) values (@username, @password, @email)", connection);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);

            MySqlDataReader reader = cmd.ExecuteReader();

            if(cmd.ExecuteNonQuery() < 0)
            {
                MessageBox.Show("Error inserting to database");
                connection.Close();

                return false;
            }
            else
            {
                connection.Close();
                return true;
            }
        }

        public bool CheckUserCredentials(string email, string password)
        {
            MySqlCommand cmd = new MySqlCommand("Select * From Frequenz_Users where email=@email and password=@password", connection);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);

            if (cmd.ExecuteNonQuery() < 0)
            {
                MessageBox.Show("Error inserting to database");
                connection.Close();

                return false;
            }
            connection.Close();
            return true;
        }

        #region Forgot Login
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
            catch (Exception ex)
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
        #endregion
    }
}
