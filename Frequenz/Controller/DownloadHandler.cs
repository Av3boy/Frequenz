using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using VideoLibrary;
using System.Windows.Forms;

namespace Frequenz.Controller
{
    public class DownloadHandler
    {
        WebClient request = new WebClient();
        private static ServerUtils server;

        public string ftpString = "ftp://"+ server.host + "/";
        public NetworkCredential ftpCredentials = new NetworkCredential(server.username, server.password);

        public Thread thread;

        public DownloadHandler()
        {
            server = new ServerUtils();
        }

        public byte[] DownloadSong(string song)
        {
            string url = ftpString + song;
            request.Credentials = ftpCredentials;

            try
            {
                byte[] data = request.DownloadData(url);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new byte[0];
            }
        }

        public void DownloadFile(string file, string path)
        {
            thread = new Thread(() => {
                string file_ = Encoding.UTF8.GetString(DownloadFromServer(file));
                if (path.EndsWith(@"\") || path.EndsWith("/"))
                {
                    path.Substring(path.Length - 1);
                }
                else
                    path += @"\";
                File.WriteAllText(path + file_, file_);

                Console.WriteLine(file_);
            });
            thread.Start();

            Wait();
        }

        public void DownloadYoutube(string youtubeUrl, string pathToyoutubeVideo)
        {
            thread = new Thread(() => {

                YouTube youtube = YouTube.Default;
                Video vid = youtube.GetVideo(youtubeUrl);

                string file = pathToyoutubeVideo + vid.FullName;

                File.WriteAllBytes(file, vid.GetBytes());
                Console.WriteLine(pathToyoutubeVideo + vid.FullName);
            });

            thread.Start();

            Wait();
        }

        void Wait()
        {
            int i = 0;
            while (thread.IsAlive)
            {
                Console.WriteLine("Time Elapsed: {0}", i);
                Thread.Sleep(1000);
                i++;
            }
        }

        string GetValidPath()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"Audio";
            if (Uri.IsWellFormedUriString(path, UriKind.Absolute))
            {
                MessageBox.Show("The inserted path: '" + path + "' is not valid. \n" +
                    "Please try again.");
                return GetValidPath();

            }
            else
                return path;
        }

        byte[] DownloadFromServer(string file)
        {
            WebClient request = new WebClient();
            string url = ftpString + "/Programs/" + file;

            request.Credentials = ftpCredentials;

            Console.WriteLine("downloading");

            try
            {
                byte[] data = request.DownloadData(url);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new byte[0];
            }
        }
    }
}
