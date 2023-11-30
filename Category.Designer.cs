namespace SportingGoodsStore
{
    partial class Category
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btProductAvailable = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.dataCategory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btEditUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(985, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 80);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btBack);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btProductAvailable);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.dataCategory);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btEditUpdate);
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 462);
            this.panel2.TabIndex = 2;
            // 
            // btBack
            // 
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.Image = global::SportingGoodsStore.Properties.Resources.previous_318477;
            this.btBack.Location = new System.Drawing.Point(272, 249);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(181, 69);
            this.btBack.TabIndex = 32;
            this.btBack.Text = "  Back";
            this.btBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.labelID);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtCategoryName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(22, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(460, 87);
            this.panel4.TabIndex = 22;
            // 
            // labelID
            // 
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(410, 29);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(43, 24);
            this.labelID.TabIndex = 16;
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(379, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "ID:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(202, 26);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(171, 32);
            this.txtCategoryName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Category Name :";
            // 
            // btProductAvailable
            // 
            this.btProductAvailable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProductAvailable.Image = global::SportingGoodsStore.Properties.Resources.Ok;
            this.btProductAvailable.Location = new System.Drawing.Point(68, 348);
            this.btProductAvailable.Name = "btProductAvailable";
            this.btProductAvailable.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btProductAvailable.Size = new System.Drawing.Size(385, 69);
            this.btProductAvailable.TabIndex = 20;
            this.btProductAvailable.Text = "  Products  Available\r\n";
            this.btProductAvailable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProductAvailable.UseVisualStyleBackColor = true;
            this.btProductAvailable.Click += new System.EventHandler(this.btProductAvailable_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Image = global::SportingGoodsStore.Properties.Resources.Add_New;
            this.btAdd.Location = new System.Drawing.Point(68, 154);
            this.btAdd.Name = "btAdd";
            this.btAdd.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btAdd.Size = new System.Drawing.Size(181, 69);
            this.btAdd.TabIndex = 19;
            this.btAdd.Text = "Insert";
            this.btAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dataCategory
            // 
            this.dataCategory.AllowUserToAddRows = false;
            this.dataCategory.AllowUserToDeleteRows = false;
            this.dataCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataCategory.Location = new System.Drawing.Point(521, 35);
            this.dataCategory.Name = "dataCategory";
            this.dataCategory.ReadOnly = true;
            this.dataCategory.RowTemplate.Height = 30;
            this.dataCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCategory.Size = new System.Drawing.Size(443, 383);
            this.dataCategory.TabIndex = 18;
            this.dataCategory.SelectionChanged += new System.EventHandler(this.dataCategory_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 120F;
            this.Column1.HeaderText = "Category ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(501, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 444);
            this.panel3.TabIndex = 17;
            // 
            // btEditUpdate
            // 
            this.btEditUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditUpdate.Image = global::SportingGoodsStore.Properties.Resources.Edit;
            this.btEditUpdate.Location = new System.Drawing.Point(68, 249);
            this.btEditUpdate.Name = "btEditUpdate";
            this.btEditUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btEditUpdate.Size = new System.Drawing.Size(181, 69);
            this.btEditUpdate.TabIndex = 16;
            this.btEditUpdate.Text = "Edit";
            this.btEditUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEditUpdate.UseVisualStyleBackColor = true;
            this.btEditUpdate.Click += new System.EventHandler(this.btEditUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Image = global::SportingGoodsStore.Properties.Resources.Trash;
            this.btDelete.Location = new System.Drawing.Point(272, 154);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(181, 69);
            this.btDelete.TabIndex = 15;
            this.btDelete.Text = "Delete";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btEditUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataCategory;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btProductAvailable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btBack;
    }
}