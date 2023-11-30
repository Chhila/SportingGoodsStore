namespace SportingGoodsStore
{
    partial class Payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscountPrice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btPay = new System.Windows.Forms.Button();
            this.txtCashReturned = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCashRecieved = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboDiscount = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("LEMON MILK Medium", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(209, 33);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(221, 29);
            this.txtTotalAmount.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount Price:";
            // 
            // txtDiscountPrice
            // 
            this.txtDiscountPrice.Location = new System.Drawing.Point(209, 109);
            this.txtDiscountPrice.Name = "txtDiscountPrice";
            this.txtDiscountPrice.Size = new System.Drawing.Size(221, 29);
            this.txtDiscountPrice.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.chkPreview);
            this.panel2.Controls.Add(this.btPay);
            this.panel2.Controls.Add(this.txtCashReturned);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtCashRecieved);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPayment);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboDiscount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDiscountPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTotalAmount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 360);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btPay
            // 
            this.btPay.Location = new System.Drawing.Point(238, 279);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(192, 60);
            this.btPay.TabIndex = 12;
            this.btPay.Text = "Pay";
            this.btPay.UseVisualStyleBackColor = true;
            this.btPay.Click += new System.EventHandler(this.btPay_Click);
            // 
            // txtCashReturned
            // 
            this.txtCashReturned.Location = new System.Drawing.Point(209, 226);
            this.txtCashReturned.Name = "txtCashReturned";
            this.txtCashReturned.Size = new System.Drawing.Size(221, 29);
            this.txtCashReturned.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cash Returned:";
            // 
            // txtCashRecieved
            // 
            this.txtCashRecieved.Location = new System.Drawing.Point(209, 187);
            this.txtCashRecieved.Name = "txtCashRecieved";
            this.txtCashRecieved.Size = new System.Drawing.Size(221, 29);
            this.txtCashRecieved.TabIndex = 9;
            this.txtCashRecieved.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCashRecieved_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cash Recieved:";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(209, 148);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(221, 29);
            this.txtPayment.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Payment:";
            // 
            // comboDiscount
            // 
            this.comboDiscount.FormattingEnabled = true;
            this.comboDiscount.Items.AddRange(new object[] {
            "0%",
            "5%",
            "10%",
            "25%",
            "50%"});
            this.comboDiscount.Location = new System.Drawing.Point(209, 70);
            this.comboDiscount.Name = "comboDiscount";
            this.comboDiscount.Size = new System.Drawing.Size(221, 30);
            this.comboDiscount.TabIndex = 5;
            this.comboDiscount.SelectedIndexChanged += new System.EventHandler(this.comboDiscount_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discount:";
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.ForeColor = System.Drawing.Color.White;
            this.chkPreview.Location = new System.Drawing.Point(36, 297);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(103, 26);
            this.chkPreview.TabIndex = 13;
            this.chkPreview.Text = "Preview";
            this.chkPreview.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiscountPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCashReturned;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCashRecieved;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btPay;
        private System.Windows.Forms.CheckBox chkPreview;
    }
}