using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using NAudio.Wave;
using System.Threading;
using NAudio.Wave.SampleProviders;
using Frequenz.Controller;

namespace Frequenz
{
    public partial class Frequenz : Form
    {
        List<string> songList = new List<string>();
        DirectSoundOut player;
        WaveOut waveOut;
        private delegate void SafeCallDelegate();

        public Frequenz()
        {
            InitializeComponent();
            player = new DirectSoundOut();
            WaveOut waveOut = new WaveOut();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string songDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Audio\";
            string songToPlay = "Stephen Walking - Glide.wav";

            WaveFileReader wave = new WaveFileReader(songDir + songToPlay);

            /*var sineWaveProvider = new SineWaveProvider32();
            sineWaveProvider.SetWaveFormat(16000, 1); // 16kHz mono
            sineWaveProvider.Frequency = 1000;
            sineWaveProvider.Amplitude = 0.01f;
            waveOut = new WaveOut();

            waveOut.Init(sineWaveProvider);
            waveOut.Play();*/

            player.Init(new WaveChannel32(wave));
            //player.Volume = 0.1f;

            label_currentSong.Text = songToPlay;

            Thread thread = new Thread(() => {
                UpdateVolume();
            });
                thread.Start();

            for (int i = 0; i < 10; i++)
            {
                Label playlist = new Label();
                playlist.Text = "ses" + 1;
                playlist.Location = new Point(playlist.Location.X, playlist.Location.Y + i * 20);
                groupBox_playlists.Controls.Add(playlist);
                playlist.BringToFront();
                Console.WriteLine(i);
            }
        }

        private void Button_Play_Click(object sender, EventArgs e)
        {

            if (player.PlaybackState == PlaybackState.Paused)
            {
                player.Play();
                button_Play.Text = "Pause";
            }
            else
            {
                player.Pause();
                button_Play.Text = "Play";
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void UpdateSong()
        {
            //label_songElapsed.Text = player.
        }

        public void UpdateVolume()
        {
            while (true)
            {
                //Console.WriteLine(player.Volume);
                //ses();
                //player.Volume = 0.1f;//trackBar_volume.Value / 100;

            }
        }

        public void ses()
        {
            if (trackBar_volume.InvokeRequired)
            {
                var d = new SafeCallDelegate(ses);
                trackBar_volume.Invoke(d, new object[] { });
            }
            else
                player.Volume = trackBar_volume.Value / 100;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel3_Resize(object sender, EventArgs e)
        {

        }
    }
}
