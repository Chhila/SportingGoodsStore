namespace SportingGoodsStore
{
    partial class MainForm
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
            this.LabelWelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btInvoice = new System.Windows.Forms.Button();
            this.btIncome = new System.Windows.Forms.Button();
            this.btSale = new System.Windows.Forms.Button();
            this.btProduct = new System.Windows.Forms.Button();
            this.btStaff = new System.Windows.Forms.Button();
            this.btCategory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.LabelWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 80);
            this.panel1.TabIndex = 0;
            // 
            // LabelWelcome
            // 
            this.LabelWelcome.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcome.ForeColor = System.Drawing.Color.White;
            this.LabelWelcome.Location = new System.Drawing.Point(0, 0);
            this.LabelWelcome.Name = "LabelWelcome";
            this.LabelWelcome.Size = new System.Drawing.Size(532, 80);
            this.LabelWelcome.TabIndex = 0;
            this.LabelWelcome.Text = "Welcome";
            this.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btInvoice);
            this.panel2.Controls.Add(this.btIncome);
            this.panel2.Controls.Add(this.btSale);
            this.panel2.Controls.Add(this.btProduct);
            this.panel2.Controls.Add(this.btStaff);
            this.panel2.Controls.Add(this.btCategory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 426);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.btLogout);
            this.panel3.Controls.Add(this.btExit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 346);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 80);
            this.panel3.TabIndex = 6;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Location = new System.Drawing.Point(74, 12);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(144, 56);
            this.btLogout.TabIndex = 34;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(315, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(144, 56);
            this.btExit.TabIndex = 33;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btInvoice
            // 
            this.btInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.btInvoice.FlatAppearance.BorderSize = 3;
            this.btInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.btInvoice.Image = global::SportingGoodsStore.Properties.Resources.Receipt_Dollar;
            this.btInvoice.Location = new System.Drawing.Point(296, 235);
            this.btInvoice.Name = "btInvoice";
            this.btInvoice.Size = new System.Drawing.Size(179, 75);
            this.btInvoice.TabIndex = 5;
            this.btInvoice.Text = "Invoice";
            this.btInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInvoice.UseVisualStyleBackColor = false;
            this.btInvoice.Click += new System.EventHandler(this.btInvoice_Click);
            // 
            // btIncome
            // 
            this.btIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIncome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.btIncome.FlatAppearance.BorderSize = 3;
            this.btIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(0)))));
            this.btIncome.Image = global::SportingGoodsStore.Properties.Resources.Receive_Dollar;
            this.btIncome.Location = new System.Drawing.Point(57, 235);
            this.btIncome.Name = "btIncome";
            this.btIncome.Size = new System.Drawing.Size(179, 75);
            this.btIncome.TabIndex = 4;
            this.btIncome.Text = "Income";
            this.btIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btIncome.UseVisualStyleBackColor = false;
            this.btIncome.Click += new System.EventHandler(this.btIncome_Click);
            // 
            // btSale
            // 
            this.btSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSale.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btSale.FlatAppearance.BorderSize = 3;
            this.btSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btSale.Image = global::SportingGoodsStore.Properties.Resources.Sale;
            this.btSale.Location = new System.Drawing.Point(296, 135);
            this.btSale.Name = "btSale";
            this.btSale.Size = new System.Drawing.Size(179, 75);
            this.btSale.TabIndex = 3;
            this.btSale.Text = "Sale";
            this.btSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSale.UseVisualStyleBackColor = false;
            this.btSale.Click += new System.EventHandler(this.btSale_Click);
            // 
            // btProduct
            // 
            this.btProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btProduct.FlatAppearance.BorderSize = 3;
            this.btProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btProduct.Image = global::SportingGoodsStore.Properties.Resources.Product_Icon;
            this.btProduct.Location = new System.Drawing.Point(57, 30);
            this.btProduct.Name = "btProduct";
            this.btProduct.Size = new System.Drawing.Size(179, 75);
            this.btProduct.TabIndex = 2;
            this.btProduct.Text = "Product";
            this.btProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProduct.UseVisualStyleBackColor = false;
            this.btProduct.Click += new System.EventHandler(this.btProduct_Click);
            // 
            // btStaff
            // 
            this.btStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStaff.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btStaff.FlatAppearance.BorderSize = 3;
            this.btStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStaff.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btStaff.Image = global::SportingGoodsStore.Properties.Resources.StaffIcon2;
            this.btStaff.Location = new System.Drawing.Point(57, 135);
            this.btStaff.Name = "btStaff";
            this.btStaff.Size = new System.Drawing.Size(179, 75);
            this.btStaff.TabIndex = 1;
            this.btStaff.Text = "Staff";
            this.btStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btStaff.UseVisualStyleBackColor = false;
            this.btStaff.Click += new System.EventHandler(this.btStaff_Click);
            // 
            // btCategory
            // 
            this.btCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCategory.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btCategory.FlatAppearance.BorderSize = 3;
            this.btCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCategory.ForeColor = System.Drawing.Color.Lime;
            this.btCategory.Image = global::SportingGoodsStore.Properties.Resources.New_Product;
            this.btCategory.Location = new System.Drawing.Point(296, 30);
            this.btCategory.Name = "btCategory";
            this.btCategory.Size = new System.Drawing.Size(179, 75);
            this.btCategory.TabIndex = 0;
            this.btCategory.Text = "Category";
            this.btCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCategory.UseVisualStyleBackColor = false;
            this.btCategory.Click += new System.EventHandler(this.btCategory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCategory;
        private System.Windows.Forms.Button btIncome;
        private System.Windows.Forms.Button btSale;
        private System.Windows.Forms.Button btProduct;
        private System.Windows.Forms.Button btStaff;
        private System.Windows.Forms.Button btInvoice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogout;
    }
}