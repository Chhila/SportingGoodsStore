namespace SportingGoodsStore
{
    partial class DBLogin
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
            this.btLogin = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.labelStaff = new System.Windows.Forms.Label();
            this.labelLoginAs = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.chkShowPW = new System.Windows.Forms.CheckBox();
            this.comboAuthentication = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelLinePassword = new System.Windows.Forms.Panel();
            this.panelLineUsername = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Controls.Add(this.labelStaff);
            this.panel1.Controls.Add(this.labelLoginAs);
            this.panel1.Controls.Add(this.picUser);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.chkShowPW);
            this.panel1.Controls.Add(this.comboAuthentication);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.picPassword);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.panelLinePassword);
            this.panel1.Controls.Add(this.panelLineUsername);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 449);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Location = new System.Drawing.Point(138, 340);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(144, 56);
            this.btLogin.TabIndex = 35;
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
            this.btExit.Location = new System.Drawing.Point(295, 340);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(144, 56);
            this.btExit.TabIndex = 34;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // labelStaff
            // 
            this.labelStaff.AutoSize = true;
            this.labelStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStaff.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaff.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelStaff.Location = new System.Drawing.Point(279, 425);
            this.labelStaff.Name = "labelStaff";
            this.labelStaff.Size = new System.Drawing.Size(84, 19);
            this.labelStaff.TabIndex = 20;
            this.labelStaff.Text = "Staff User";
            this.labelStaff.Click += new System.EventHandler(this.labelStaff_Click);
            // 
            // labelLoginAs
            // 
            this.labelLoginAs.AutoSize = true;
            this.labelLoginAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLoginAs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginAs.ForeColor = System.Drawing.Color.White;
            this.labelLoginAs.Location = new System.Drawing.Point(207, 425);
            this.labelLoginAs.Name = "labelLoginAs";
            this.labelLoginAs.Size = new System.Drawing.Size(75, 19);
            this.labelLoginAs.TabIndex = 19;
            this.labelLoginAs.Text = "Login as";
            this.labelLoginAs.Click += new System.EventHandler(this.labelLoginAs_Click);
            // 
            // picUser
            // 
            this.picUser.Image = global::SportingGoodsStore.Properties.Resources.User;
            this.picUser.Location = new System.Drawing.Point(409, 186);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(30, 30);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 15;
            this.picUser.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(138, 191);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(301, 25);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Text = "Enter Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // chkShowPW
            // 
            this.chkShowPW.AutoSize = true;
            this.chkShowPW.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPW.ForeColor = System.Drawing.Color.White;
            this.chkShowPW.Location = new System.Drawing.Point(138, 311);
            this.chkShowPW.Name = "chkShowPW";
            this.chkShowPW.Size = new System.Drawing.Size(153, 23);
            this.chkShowPW.TabIndex = 14;
            this.chkShowPW.Text = "Show Password";
            this.chkShowPW.UseVisualStyleBackColor = true;
            this.chkShowPW.CheckedChanged += new System.EventHandler(this.chkShowPW_CheckedChanged);
            // 
            // comboAuthentication
            // 
            this.comboAuthentication.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboAuthentication.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboAuthentication.BackColor = System.Drawing.Color.White;
            this.comboAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAuthentication.FormattingEnabled = true;
            this.comboAuthentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.comboAuthentication.Location = new System.Drawing.Point(138, 115);
            this.comboAuthentication.Name = "comboAuthentication";
            this.comboAuthentication.Size = new System.Drawing.Size(301, 32);
            this.comboAuthentication.TabIndex = 5;
            this.comboAuthentication.SelectedIndexChanged += new System.EventHandler(this.comboAuthentication_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(136, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Authentication";
            // 
            // picPassword
            // 
            this.picPassword.Image = global::SportingGoodsStore.Properties.Resources.Password;
            this.picPassword.Location = new System.Drawing.Point(409, 261);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(30, 30);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 10;
            this.picPassword.TabStop = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(139, 239);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(109, 24);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(138, 266);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(301, 25);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Enter Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // panelLinePassword
            // 
            this.panelLinePassword.BackColor = System.Drawing.Color.White;
            this.panelLinePassword.Location = new System.Drawing.Point(138, 294);
            this.panelLinePassword.Name = "panelLinePassword";
            this.panelLinePassword.Size = new System.Drawing.Size(301, 1);
            this.panelLinePassword.TabIndex = 5;
            // 
            // panelLineUsername
            // 
            this.panelLineUsername.BackColor = System.Drawing.Color.White;
            this.panelLineUsername.Location = new System.Drawing.Point(138, 219);
            this.panelLineUsername.Name = "panelLineUsername";
            this.panelLineUsername.Size = new System.Drawing.Size(301, 1);
            this.panelLineUsername.TabIndex = 4;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(136, 164);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(112, 24);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATABASE LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 58);
            this.panel4.TabIndex = 1;
            // 
            // DBLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 449);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DBLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBLogin";
            this.Load += new System.EventHandler(this.DBLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLineUsername;
        private System.Windows.Forms.Panel panelLinePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.ComboBox comboAuthentication;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkShowPW;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label labelLoginAs;
        private System.Windows.Forms.Label labelStaff;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btExit;
    }
}

