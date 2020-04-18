using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Frequenz.Controller
{
    public class ServerUtils
    {
        public string host;
        public string username;
        public string password;
        public int port;
        public string database;

        public ServerUtils()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string startupPath = Path.Combine(path, ".env");
            string creds = File.ReadAllText(startupPath);

            string[] words = creds.Split(';');

            foreach (var word in words)
            {
                string credentialType = word.Split(':')[0];
                string credential = word.Substring(word.IndexOf(':') + 1);

                switch (credentialType)
                {
                    case "host":
                        host = credential;
                        break;
                    case "username":
                        username = credential;
                        break;
                    case "password":
                        password = credential;
                        break;
                    case "port":
                        port = int.Parse(credential);
                        break;
                    case "sqlDataBase":
                        database = credential;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
