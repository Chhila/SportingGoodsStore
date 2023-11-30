namespace SportingGoodsStore
{
    partial class StaffLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btLogin = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.labelDatabaseUser = new System.Windows.Forms.Label();
            this.labelLoginAs = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.chkShowPW = new System.Windows.Forms.CheckBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelLinePassword = new System.Windows.Forms.Panel();
            this.panelLineUsername = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("LEMON MILK Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAFF LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btLogin);
            this.panel2.Controls.Add(this.btExit);
            this.panel2.Controls.Add(this.labelDatabaseUser);
            this.panel2.Controls.Add(this.labelLoginAs);
            this.panel2.Controls.Add(this.picUser);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.chkShowPW);
            this.panel2.Controls.Add(this.picPassword);
            this.panel2.Controls.Add(this.labelPassword);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.panelLinePassword);
            this.panel2.Controls.Add(this.panelLineUsername);
            this.panel2.Controls.Add(this.labelUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 348);
            this.panel2.TabIndex = 1;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(138, 226);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(144, 56);
            this.btLogin.TabIndex = 33;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(295, 226);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(144, 56);
            this.btExit.TabIndex = 32;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // labelDatabaseUser
            // 
            this.labelDatabaseUser.AutoSize = true;
            this.labelDatabaseUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelDatabaseUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatabaseUser.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelDatabaseUser.Location = new System.Drawing.Point(268, 320);
            this.labelDatabaseUser.Name = "labelDatabaseUser";
            this.labelDatabaseUser.Size = new System.Drawing.Size(121, 19);
            this.labelDatabaseUser.TabIndex = 30;
            this.labelDatabaseUser.Text = "Database User";
            this.labelDatabaseUser.Click += new System.EventHandler(this.labelDatabaseUser_Click);
            // 
            // labelLoginAs
            // 
            this.labelLoginAs.AutoSize = true;
            this.labelLoginAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLoginAs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginAs.ForeColor = System.Drawing.Color.White;
            this.labelLoginAs.Location = new System.Drawing.Point(196, 320);
            this.labelLoginAs.Name = "labelLoginAs";
            this.labelLoginAs.Size = new System.Drawing.Size(75, 19);
            this.labelLoginAs.TabIndex = 29;
            this.labelLoginAs.Text = "Login as";
            this.labelLoginAs.Click += new System.EventHandler(this.labelLoginAs_Click);
            // 
            // picUser
            // 
            this.picUser.Image = global::SportingGoodsStore.Properties.Resources.User;
            this.picUser.Location = new System.Drawing.Point(409, 60);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(30, 30);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 26;
            this.picUser.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(138, 65);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(301, 25);
            this.txtUsername.TabIndex = 21;
            this.txtUsername.Text = "Enter Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // chkShowPW
            // 
            this.chkShowPW.AutoSize = true;
            this.chkShowPW.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPW.ForeColor = System.Drawing.Color.White;
            this.chkShowPW.Location = new System.Drawing.Point(138, 185);
            this.chkShowPW.Name = "chkShowPW";
            this.chkShowPW.Size = new System.Drawing.Size(153, 23);
            this.chkShowPW.TabIndex = 25;
            this.chkShowPW.Text = "Show Password";
            this.chkShowPW.UseVisualStyleBackColor = true;
            this.chkShowPW.CheckedChanged += new System.EventHandler(this.chkShowPW_CheckedChanged);
            // 
            // picPassword
            // 
            this.picPassword.Image = global::SportingGoodsStore.Properties.Resources.Password;
            this.picPassword.Location = new System.Drawing.Point(409, 135);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(30, 30);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 24;
            this.picPassword.TabStop = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(139, 113);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(109, 24);
            this.labelPassword.TabIndex = 23;
            this.labelPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(138, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(301, 25);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.Text = "Enter Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // panelLinePassword
            // 
            this.panelLinePassword.BackColor = System.Drawing.Color.White;
            this.panelLinePassword.Location = new System.Drawing.Point(138, 168);
            this.panelLinePassword.Name = "panelLinePassword";
            this.panelLinePassword.Size = new System.Drawing.Size(301, 1);
            this.panelLinePassword.TabIndex = 20;
            // 
            // panelLineUsername
            // 
            this.panelLineUsername.BackColor = System.Drawing.Color.White;
            this.panelLineUsername.Location = new System.Drawing.Point(138, 93);
            this.panelLineUsername.Name = "panelLineUsername";
            this.panelLineUsername.Size = new System.Drawing.Size(301, 1);
            this.panelLineUsername.TabIndex = 19;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(136, 38);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(112, 24);
            this.labelUsername.TabIndex = 18;
            this.labelUsername.Text = "Username";
            // 
            // StaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 428);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StaffLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffLogin";
            this.Load += new System.EventHandler(this.StaffLogin_Load);
            this.Click += new System.EventHandler(this.StaffLogin_Click);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox chkShowPW;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panelLinePassword;
        private System.Windows.Forms.Panel panelLineUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelDatabaseUser;
        private System.Windows.Forms.Label labelLoginAs;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogin;
    }
}