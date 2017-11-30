namespace QuanLiSach
{
    partial class Sach
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
            this.dgvLoadSach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTL = new System.Windows.Forms.ComboBox();
            this.cbxNXB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbGIABIA = new System.Windows.Forms.TextBox();
            this.txbSOTRANG = new System.Windows.Forms.TextBox();
            this.txbTENSACH = new System.Windows.Forms.TextBox();
            this.txbTACGIA = new System.Windows.Forms.TextBox();
            this.txbIDSACH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSach = new System.Windows.Forms.Button();
            this.btnEditSach = new System.Windows.Forms.Button();
            this.btnDelSach = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoadSach
            // 
            this.dgvLoadSach.AllowUserToAddRows = false;
            this.dgvLoadSach.AllowUserToDeleteRows = false;
            this.dgvLoadSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadSach.Location = new System.Drawing.Point(12, 247);
            this.dgvLoadSach.Name = "dgvLoadSach";
            this.dgvLoadSach.ReadOnly = true;
            this.dgvLoadSach.Size = new System.Drawing.Size(605, 150);
            this.dgvLoadSach.TabIndex = 0;
            this.dgvLoadSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoadSach_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxTL);
            this.groupBox1.Controls.Add(this.cbxNXB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbGIABIA);
            this.groupBox1.Controls.Add(this.txbSOTRANG);
            this.groupBox1.Controls.Add(this.txbTENSACH);
            this.groupBox1.Controls.Add(this.txbTACGIA);
            this.groupBox1.Controls.Add(this.txbIDSACH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // cbxTL
            // 
            this.cbxTL.FormattingEnabled = true;
            this.cbxTL.Location = new System.Drawing.Point(357, 97);
            this.cbxTL.Name = "cbxTL";
            this.cbxTL.Size = new System.Drawing.Size(121, 21);
            this.cbxTL.TabIndex = 13;
            // 
            // cbxNXB
            // 
            this.cbxNXB.FormattingEnabled = true;
            this.cbxNXB.Location = new System.Drawing.Point(357, 48);
            this.cbxNXB.Name = "cbxNXB";
            this.cbxNXB.Size = new System.Drawing.Size(121, 21);
            this.cbxNXB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Thể loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhà xuất bản";
            // 
            // txbGIABIA
            // 
            this.txbGIABIA.Location = new System.Drawing.Point(100, 140);
            this.txbGIABIA.Name = "txbGIABIA";
            this.txbGIABIA.Size = new System.Drawing.Size(215, 20);
            this.txbGIABIA.TabIndex = 9;
            // 
            // txbSOTRANG
            // 
            this.txbSOTRANG.Location = new System.Drawing.Point(100, 111);
            this.txbSOTRANG.Name = "txbSOTRANG";
            this.txbSOTRANG.Size = new System.Drawing.Size(215, 20);
            this.txbSOTRANG.TabIndex = 8;
            // 
            // txbTENSACH
            // 
            this.txbTENSACH.Location = new System.Drawing.Point(100, 53);
            this.txbTENSACH.Name = "txbTENSACH";
            this.txbTENSACH.Size = new System.Drawing.Size(215, 20);
            this.txbTENSACH.TabIndex = 7;
            // 
            // txbTACGIA
            // 
            this.txbTACGIA.Location = new System.Drawing.Point(100, 81);
            this.txbTACGIA.Name = "txbTACGIA";
            this.txbTACGIA.Size = new System.Drawing.Size(215, 20);
            this.txbTACGIA.TabIndex = 6;
            // 
            // txbIDSACH
            // 
            this.txbIDSACH.Enabled = false;
            this.txbIDSACH.Location = new System.Drawing.Point(100, 24);
            this.txbIDSACH.Name = "txbIDSACH";
            this.txbIDSACH.Size = new System.Drawing.Size(215, 20);
            this.txbIDSACH.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gía bìa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số trang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Sách";
            // 
            // btnAddSach
            // 
            this.btnAddSach.Location = new System.Drawing.Point(12, 191);
            this.btnAddSach.Name = "btnAddSach";
            this.btnAddSach.Size = new System.Drawing.Size(84, 39);
            this.btnAddSach.TabIndex = 14;
            this.btnAddSach.Text = "Thêm";
            this.btnAddSach.UseVisualStyleBackColor = true;
            this.btnAddSach.Click += new System.EventHandler(this.btnAddSach_Click);
            // 
            // btnEditSach
            // 
            this.btnEditSach.Location = new System.Drawing.Point(112, 191);
            this.btnEditSach.Name = "btnEditSach";
            this.btnEditSach.Size = new System.Drawing.Size(78, 39);
            this.btnEditSach.TabIndex = 15;
            this.btnEditSach.Text = "Sửa";
            this.btnEditSach.UseVisualStyleBackColor = true;
            // 
            // btnDelSach
            // 
            this.btnDelSach.Location = new System.Drawing.Point(211, 191);
            this.btnDelSach.Name = "btnDelSach";
            this.btnDelSach.Size = new System.Drawing.Size(87, 39);
            this.btnDelSach.TabIndex = 16;
            this.btnDelSach.Text = "Xóa";
            this.btnDelSach.UseVisualStyleBackColor = true;
            this.btnDelSach.Click += new System.EventHandler(this.btnDelSach_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(324, 191);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 39);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 409);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelSach);
            this.Controls.Add(this.btnEditSach);
            this.Controls.Add(this.btnAddSach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLoadSach);
            this.Name = "Sach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sach";
            this.Load += new System.EventHandler(this.Sach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoadSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxTL;
        private System.Windows.Forms.ComboBox cbxNXB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbGIABIA;
        private System.Windows.Forms.TextBox txbSOTRANG;
        private System.Windows.Forms.TextBox txbTENSACH;
        private System.Windows.Forms.TextBox txbTACGIA;
        private System.Windows.Forms.TextBox txbIDSACH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSach;
        private System.Windows.Forms.Button btnEditSach;
        private System.Windows.Forms.Button btnDelSach;
        private System.Windows.Forms.Button btnRefresh;
    }
}