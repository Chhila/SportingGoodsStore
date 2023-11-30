namespace SportingGoodsStore
{
    partial class Product
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboCategoryName = new System.Windows.Forms.ComboBox();
            this.dataProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.labelProductID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelWelcome = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEditUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btAddNewCategory = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btAddNewCategory);
            this.panel2.Controls.Add(this.btBack);
            this.panel2.Controls.Add(this.comboCategoryName);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.btEditUpdate);
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Controls.Add(this.dataProduct);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.labelProductID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.picProduct);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSQty);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 619);
            this.panel2.TabIndex = 1;
            // 
            // comboCategoryName
            // 
            this.comboCategoryName.FormattingEnabled = true;
            this.comboCategoryName.Location = new System.Drawing.Point(187, 175);
            this.comboCategoryName.Name = "comboCategoryName";
            this.comboCategoryName.Size = new System.Drawing.Size(204, 30);
            this.comboCategoryName.TabIndex = 28;
            this.comboCategoryName.SelectedIndexChanged += new System.EventHandler(this.comboCategoryName_SelectedIndexChanged);
            // 
            // dataProduct
            // 
            this.dataProduct.AllowUserToAddRows = false;
            this.dataProduct.AllowUserToDeleteRows = false;
            this.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataProduct.Location = new System.Drawing.Point(16, 319);
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.ReadOnly = true;
            this.dataProduct.RowTemplate.Height = 40;
            this.dataProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProduct.Size = new System.Drawing.Size(762, 278);
            this.dataProduct.TabIndex = 14;
            this.dataProduct.SelectionChanged += new System.EventHandler(this.dataProduct_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PName";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SQty";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 98;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Picture";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(770, 1);
            this.panel3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(398, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "$";
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.ForeColor = System.Drawing.Color.White;
            this.labelProductID.Location = new System.Drawing.Point(432, 27);
            this.labelProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(0, 22);
            this.labelProductID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(398, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(507, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Picture:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category Name:";
            // 
            // txtSQty
            // 
            this.txtSQty.Location = new System.Drawing.Point(187, 124);
            this.txtSQty.Name = "txtSQty";
            this.txtSQty.Size = new System.Drawing.Size(204, 29);
            this.txtSQty.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(118, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "SQty:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(187, 74);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(204, 29);
            this.txtPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(187, 24);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(204, 29);
            this.txtProductName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.LabelWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 77);
            this.panel1.TabIndex = 0;
            // 
            // LabelWelcome
            // 
            this.LabelWelcome.Font = new System.Drawing.Font("LEMON MILK Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcome.ForeColor = System.Drawing.Color.White;
            this.LabelWelcome.Location = new System.Drawing.Point(0, 0);
            this.LabelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelWelcome.Name = "LabelWelcome";
            this.LabelWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelWelcome.Size = new System.Drawing.Size(794, 77);
            this.LabelWelcome.TabIndex = 1;
            this.LabelWelcome.Text = "PRODUCT LIST";
            this.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btBack
            // 
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.Image = global::SportingGoodsStore.Properties.Resources.previous_318477;
            this.btBack.Location = new System.Drawing.Point(597, 219);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(181, 69);
            this.btBack.TabIndex = 31;
            this.btBack.Text = "  Back";
            this.btBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Image = global::SportingGoodsStore.Properties.Resources.Add_New;
            this.btAdd.Location = new System.Drawing.Point(16, 219);
            this.btAdd.Name = "btAdd";
            this.btAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btAdd.Size = new System.Drawing.Size(181, 69);
            this.btAdd.TabIndex = 24;
            this.btAdd.Text = "Insert";
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEditUpdate
            // 
            this.btEditUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditUpdate.Image = global::SportingGoodsStore.Properties.Resources.Edit;
            this.btEditUpdate.Location = new System.Drawing.Point(210, 219);
            this.btEditUpdate.Name = "btEditUpdate";
            this.btEditUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btEditUpdate.Size = new System.Drawing.Size(181, 69);
            this.btEditUpdate.TabIndex = 23;
            this.btEditUpdate.Text = "Edit";
            this.btEditUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEditUpdate.UseVisualStyleBackColor = true;
            this.btEditUpdate.Click += new System.EventHandler(this.btEditUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Image = global::SportingGoodsStore.Properties.Resources.Trash;
            this.btDelete.Location = new System.Drawing.Point(404, 219);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(181, 69);
            this.btDelete.TabIndex = 22;
            this.btDelete.Text = "Delete";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // picProduct
            // 
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Image = global::SportingGoodsStore.Properties.Resources.No_Image_Available;
            this.picProduct.Location = new System.Drawing.Point(597, 24);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(140, 140);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 9;
            this.picProduct.TabStop = false;
            this.picProduct.Click += new System.EventHandler(this.picProduct_Click);
            // 
            // btAddNewCategory
            // 
            this.btAddNewCategory.BackColor = System.Drawing.Color.White;
            this.btAddNewCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAddNewCategory.FlatAppearance.BorderSize = 0;
            this.btAddNewCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btAddNewCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btAddNewCategory.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNewCategory.Location = new System.Drawing.Point(404, 174);
            this.btAddNewCategory.Name = "btAddNewCategory";
            this.btAddNewCategory.Size = new System.Drawing.Size(36, 35);
            this.btAddNewCategory.TabIndex = 32;
            this.btAddNewCategory.Text = "+";
            this.btAddNewCategory.UseVisualStyleBackColor = false;
            this.btAddNewCategory.Click += new System.EventHandler(this.btAddNewCategory_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(597, 176);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(181, 29);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(450, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Search Name:";
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 696);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelWelcome;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEditUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ComboBox comboCategoryName;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btAddNewCategory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
    }
}