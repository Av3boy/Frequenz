namespace Frequenz
{
    partial class Frequenz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Play = new System.Windows.Forms.Button();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label_currentSong = new System.Windows.Forms.Label();
            this.label_currentArtist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.button_back = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.label_songDuration = new System.Windows.Forms.Label();
            this.label_songElapsed = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_settings = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.groupBox_playlists = new System.Windows.Forms.GroupBox();
            this.btn_downloadYT = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(84, 26);
            this.contextMenuStrip.Text = "...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(83, 22);
            this.toolStripMenuItem2.Text = "...";
            // 
            // button_Play
            // 
            this.button_Play.Location = new System.Drawing.Point(389, 7);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(43, 23);
            this.button_Play.TabIndex = 1;
            this.button_Play.Text = "Play";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.Button_Play_Click);
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(205, 36);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(410, 10);
            this.bunifuProgressBar1.TabIndex = 2;
            this.bunifuProgressBar1.Value = 0;
            // 
            // label_currentSong
            // 
            this.label_currentSong.AutoSize = true;
            this.label_currentSong.Location = new System.Drawing.Point(79, 7);
            this.label_currentSong.Name = "label_currentSong";
            this.label_currentSong.Size = new System.Drawing.Size(58, 13);
            this.label_currentSong.TabIndex = 3;
            this.label_currentSong.Text = "songName";
            // 
            // label_currentArtist
            // 
            this.label_currentArtist.AutoSize = true;
            this.label_currentArtist.Location = new System.Drawing.Point(79, 33);
            this.label_currentArtist.Name = "label_currentArtist";
            this.label_currentArtist.Size = new System.Drawing.Size(53, 13);
            this.label_currentArtist.TabIndex = 4;
            this.label_currentArtist.Text = "songArtist";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button_Exit);
            this.panel1.Location = new System.Drawing.Point(159, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 44);
            this.panel1.TabIndex = 5;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(598, 11);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(31, 23);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "X";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.trackBar_volume);
            this.panel2.Controls.Add(this.button_back);
            this.panel2.Controls.Add(this.button_next);
            this.panel2.Controls.Add(this.label_songDuration);
            this.panel2.Controls.Add(this.label_songElapsed);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button_Play);
            this.panel2.Controls.Add(this.bunifuProgressBar1);
            this.panel2.Controls.Add(this.label_currentArtist);
            this.panel2.Controls.Add(this.label_currentSong);
            this.panel2.Location = new System.Drawing.Point(-1, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 61);
            this.panel2.TabIndex = 6;
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.Location = new System.Drawing.Point(655, 33);
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Size = new System.Drawing.Size(134, 45);
            this.trackBar_volume.TabIndex = 10;
            this.trackBar_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(330, 7);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(43, 23);
            this.button_back.TabIndex = 9;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(448, 7);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(43, 23);
            this.button_next.TabIndex = 8;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label_songDuration
            // 
            this.label_songDuration.AutoSize = true;
            this.label_songDuration.Location = new System.Drawing.Point(621, 33);
            this.label_songDuration.Name = "label_songDuration";
            this.label_songDuration.Size = new System.Drawing.Size(28, 13);
            this.label_songDuration.TabIndex = 7;
            this.label_songDuration.Text = "0:00";
            // 
            // label_songElapsed
            // 
            this.label_songElapsed.AutoSize = true;
            this.label_songElapsed.Location = new System.Drawing.Point(157, 33);
            this.label_songElapsed.Name = "label_songElapsed";
            this.label_songElapsed.Size = new System.Drawing.Size(28, 13);
            this.label_songElapsed.TabIndex = 6;
            this.label_songElapsed.Text = "0:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.btn_downloadYT);
            this.panel3.Controls.Add(this.groupBox_playlists);
            this.panel3.Controls.Add(this.btn_Upload);
            this.panel3.Controls.Add(this.button_settings);
            this.panel3.Location = new System.Drawing.Point(-1, -8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 404);
            this.panel3.TabIndex = 6;
            this.panel3.Resize += new System.EventHandler(this.panel3_Resize);
            // 
            // button_settings
            // 
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_settings.ForeColor = System.Drawing.Color.White;
            this.button_settings.Location = new System.Drawing.Point(13, 19);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(42, 23);
            this.button_settings.TabIndex = 0;
            this.button_settings.Text = "...";
            this.button_settings.UseVisualStyleBackColor = true;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(13, 68);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(114, 23);
            this.btn_Upload.TabIndex = 1;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            // 
            // groupBox_playlists
            // 
            this.groupBox_playlists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_playlists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_playlists.Location = new System.Drawing.Point(13, 145);
            this.groupBox_playlists.Name = "groupBox_playlists";
            this.groupBox_playlists.Size = new System.Drawing.Size(114, 230);
            this.groupBox_playlists.TabIndex = 2;
            this.groupBox_playlists.TabStop = false;
            // 
            // btn_downloadYT
            // 
            this.btn_downloadYT.Location = new System.Drawing.Point(13, 97);
            this.btn_downloadYT.Name = "btn_downloadYT";
            this.btn_downloadYT.Size = new System.Drawing.Size(114, 42);
            this.btn_downloadYT.TabIndex = 3;
            this.btn_downloadYT.Text = "Download from Youtube";
            this.btn_downloadYT.UseVisualStyleBackColor = true;
            // 
            // Frequenz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frequenz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frequenz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label_currentSong;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label_songDuration;
        private System.Windows.Forms.Label label_songElapsed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_currentArtist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.GroupBox groupBox_playlists;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_downloadYT;
    }
}

