namespace Lab_2
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbFstNm = new System.Windows.Forms.TextBox();
            this.txtbLstNm = new System.Windows.Forms.TextBox();
            this.txtbPwrUsg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbAccNo = new System.Windows.Forms.TextBox();
            this.addCrtBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbAvgBill = new System.Windows.Forms.TextBox();
            this.txtbNoCstm = new System.Windows.Forms.TextBox();
            this.txtbTtlUsg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstView = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Lab_2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(389, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(9);
            this.label1.Size = new System.Drawing.Size(390, 129);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill app";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(9);
            this.label2.Size = new System.Drawing.Size(114, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(9);
            this.label3.Size = new System.Drawing.Size(112, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // txtbFstNm
            // 
            this.txtbFstNm.BackColor = System.Drawing.SystemColors.Info;
            this.txtbFstNm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtbFstNm.Location = new System.Drawing.Point(217, 107);
            this.txtbFstNm.Name = "txtbFstNm";
            this.txtbFstNm.Size = new System.Drawing.Size(156, 29);
            this.txtbFstNm.TabIndex = 2;
            // 
            // txtbLstNm
            // 
            this.txtbLstNm.BackColor = System.Drawing.SystemColors.Info;
            this.txtbLstNm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtbLstNm.Location = new System.Drawing.Point(217, 158);
            this.txtbLstNm.Name = "txtbLstNm";
            this.txtbLstNm.Size = new System.Drawing.Size(156, 29);
            this.txtbLstNm.TabIndex = 3;
            // 
            // txtbPwrUsg
            // 
            this.txtbPwrUsg.BackColor = System.Drawing.SystemColors.Info;
            this.txtbPwrUsg.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtbPwrUsg.Location = new System.Drawing.Point(217, 209);
            this.txtbPwrUsg.Name = "txtbPwrUsg";
            this.txtbPwrUsg.Size = new System.Drawing.Size(156, 29);
            this.txtbPwrUsg.TabIndex = 4;
            this.txtbPwrUsg.TextChanged += new System.EventHandler(this.txtbPwrUsg_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(13, 203);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(9);
            this.label4.Size = new System.Drawing.Size(174, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Power Usage(kwh):";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.exitBtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtbAccNo);
            this.groupBox1.Controls.Add(this.addCrtBtn);
            this.groupBox1.Controls.Add(this.txtbPwrUsg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbFstNm);
            this.groupBox1.Controls.Add(this.txtbLstNm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(0, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 265);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a new Customer:";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.Info;
            this.resetBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.resetBtn.Location = new System.Drawing.Point(394, 118);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Padding = new System.Windows.Forms.Padding(5);
            this.resetBtn.Size = new System.Drawing.Size(155, 45);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset Fields";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.Info;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.exitBtn.Location = new System.Drawing.Point(394, 180);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(5);
            this.exitBtn.Size = new System.Drawing.Size(155, 45);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit App";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(13, 50);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(9);
            this.label8.Size = new System.Drawing.Size(188, 39);
            this.label8.TabIndex = 10;
            this.label8.Text = "Account # (optional):";
            // 
            // txtbAccNo
            // 
            this.txtbAccNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtbAccNo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtbAccNo.Location = new System.Drawing.Point(217, 56);
            this.txtbAccNo.Name = "txtbAccNo";
            this.txtbAccNo.Size = new System.Drawing.Size(156, 29);
            this.txtbAccNo.TabIndex = 1;
            this.txtbAccNo.TextChanged += new System.EventHandler(this.txtbAccNo_TextChanged);
            // 
            // addCrtBtn
            // 
            this.addCrtBtn.BackColor = System.Drawing.SystemColors.Info;
            this.addCrtBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addCrtBtn.Location = new System.Drawing.Point(394, 56);
            this.addCrtBtn.Name = "addCrtBtn";
            this.addCrtBtn.Padding = new System.Windows.Forms.Padding(5);
            this.addCrtBtn.Size = new System.Drawing.Size(155, 45);
            this.addCrtBtn.TabIndex = 5;
            this.addCrtBtn.Text = "Add Customer";
            this.addCrtBtn.UseVisualStyleBackColor = false;
            this.addCrtBtn.Click += new System.EventHandler(this.addCrtBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.lstView);
            this.groupBox2.Controls.Add(this.removeBtn);
            this.groupBox2.Location = new System.Drawing.Point(596, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 554);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Customers";
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.SystemColors.Info;
            this.removeBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.removeBtn.Location = new System.Drawing.Point(219, 497);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Padding = new System.Windows.Forms.Padding(5);
            this.removeBtn.Size = new System.Drawing.Size(171, 45);
            this.removeBtn.TabIndex = 8;
            this.removeBtn.Text = "Remove Customer";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.txtbAvgBill);
            this.groupBox3.Controls.Add(this.txtbNoCstm);
            this.groupBox3.Controls.Add(this.txtbTtlUsg);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(0, 494);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 209);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // txtbAvgBill
            // 
            this.txtbAvgBill.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbAvgBill.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtbAvgBill.Location = new System.Drawing.Point(389, 152);
            this.txtbAvgBill.Name = "txtbAvgBill";
            this.txtbAvgBill.ReadOnly = true;
            this.txtbAvgBill.Size = new System.Drawing.Size(156, 29);
            this.txtbAvgBill.TabIndex = 11;
            // 
            // txtbNoCstm
            // 
            this.txtbNoCstm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbNoCstm.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtbNoCstm.Location = new System.Drawing.Point(389, 44);
            this.txtbNoCstm.Name = "txtbNoCstm";
            this.txtbNoCstm.ReadOnly = true;
            this.txtbNoCstm.Size = new System.Drawing.Size(156, 29);
            this.txtbNoCstm.TabIndex = 9;
            // 
            // txtbTtlUsg
            // 
            this.txtbTtlUsg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbTtlUsg.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtbTtlUsg.Location = new System.Drawing.Point(389, 98);
            this.txtbTtlUsg.Name = "txtbTtlUsg";
            this.txtbTtlUsg.ReadOnly = true;
            this.txtbTtlUsg.Size = new System.Drawing.Size(156, 29);
            this.txtbTtlUsg.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(17, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Average bill amount ($):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(17, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total number of kWh used:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(17, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number of customers processed:";
            // 
            // lstView
            // 
            this.lstView.BackColor = System.Drawing.SystemColors.Info;
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(21, 56);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(570, 416);
            this.lstView.TabIndex = 9;
            this.lstView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::Lab_2.Properties.Resources.blurBG;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(1199, 731);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Electricity Co.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbFstNm;
        private System.Windows.Forms.TextBox txtbLstNm;
        private System.Windows.Forms.TextBox txtbPwrUsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtbAvgBill;
        private System.Windows.Forms.TextBox txtbNoCstm;
        private System.Windows.Forms.TextBox txtbTtlUsg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addCrtBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbAccNo;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ListView lstView;
    }
}

