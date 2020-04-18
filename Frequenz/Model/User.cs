using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Frequenz
{
    public class User
    {

        private int id;
        private string username;
        private string password;
        private string email;
        private List<User> friends;
        private bool isArtist;


        private MySqlConnection connection;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public List<User> Friends { get => friends; set => friends = value; }
        public bool IsArtist { get => isArtist; set => isArtist = value; }

        public User()
        {
           connection = new MySqlConnection("");

        }

        public List<User> GetUsers(string username)
        {
            List<User> userList = new List<User>();

            MySqlCommand cmd = new MySqlCommand("select * from users where users=@username", connection);
            cmd.Parameters.AddWithValue("@username", username);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                User user = new User();
                user.Id = reader.GetInt32("Id");
                user.username = reader.GetString("Username");
                user.Password = reader.GetString("password");
                user.Email = reader.GetString("email");

                userList.Add(user);
            }

            connection.Close();
            return userList;
        }

    }

    public class Artist
    {

        private int id;
        private List<Song> publishedSongs;
        private string artistName;
        private List<Artist> friends;
        private List<Artist> followers;

        public int Id { get => id; set => id = value; }
        public List<Song> PublishedSongs { get => publishedSongs; set => publishedSongs = value; }
        public string ArtistName { get => artistName; set => artistName = value; }
        public List<Artist> Friends { get => friends; set => friends = value; }
        public List<Artist> Followers { get => followers; set => followers = value; }
    }
}
