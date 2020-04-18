namespace Frequenz
{
    partial class Reqister
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_register = new System.Windows.Forms.Label();
            this.button_reqister = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.textBox_reEnter = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label_register);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 191);
            this.panel1.TabIndex = 0;
            // 
            // label_register
            // 
            this.label_register.AutoSize = true;
            this.label_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_register.ForeColor = System.Drawing.SystemColors.Control;
            this.label_register.Location = new System.Drawing.Point(65, 56);
            this.label_register.Name = "label_register";
            this.label_register.Size = new System.Drawing.Size(279, 73);
            this.label_register.TabIndex = 0;
            this.label_register.Text = "Reqister";
            // 
            // button_reqister
            // 
            this.button_reqister.Location = new System.Drawing.Point(118, 358);
            this.button_reqister.Name = "button_reqister";
            this.button_reqister.Size = new System.Drawing.Size(75, 23);
            this.button_reqister.TabIndex = 1;
            this.button_reqister.Text = "Reqister";
            this.button_reqister.UseVisualStyleBackColor = true;
            this.button_reqister.Click += new System.EventHandler(this.Reqister_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(118, 263);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(166, 20);
            this.textBox_email.TabIndex = 2;
            this.textBox_email.Text = "[Email]";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(118, 289);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(166, 20);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.Text = "[Password]";
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(209, 358);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.Back_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // textBox_reEnter
            // 
            this.textBox_reEnter.Location = new System.Drawing.Point(118, 315);
            this.textBox_reEnter.Name = "textBox_reEnter";
            this.textBox_reEnter.Size = new System.Drawing.Size(166, 20);
            this.textBox_reEnter.TabIndex = 5;
            this.textBox_reEnter.Text = "[Re Enter password]";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(118, 237);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(166, 20);
            this.textBox_Username.TabIndex = 6;
            this.textBox_Username.Text = "[Username]";
            // 
            // Reqister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.textBox_reEnter);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.button_reqister);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reqister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reqister";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_register;
        private System.Windows.Forms.Button button_reqister;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_back;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox textBox_reEnter;
        private System.Windows.Forms.TextBox textBox_Username;
    }
}