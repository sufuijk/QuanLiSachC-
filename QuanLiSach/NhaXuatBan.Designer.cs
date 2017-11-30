namespace QuanLiSach
{
    partial class NhaXuatBan
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
            this.dgvLoadNXB = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbIDNXB = new System.Windows.Forms.TextBox();
            this.txbTELNXB = new System.Windows.Forms.TextBox();
            this.txbDIACHINXB = new System.Windows.Forms.TextBox();
            this.txbTENNXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddNXB = new System.Windows.Forms.Button();
            this.btnEditNXB = new System.Windows.Forms.Button();
            this.btnDelNXB = new System.Windows.Forms.Button();
            this.btnRefreshNXB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadNXB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoadNXB
            // 
            this.dgvLoadNXB.AllowUserToAddRows = false;
            this.dgvLoadNXB.AllowUserToDeleteRows = false;
            this.dgvLoadNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadNXB.Location = new System.Drawing.Point(12, 193);
            this.dgvLoadNXB.Name = "dgvLoadNXB";
            this.dgvLoadNXB.ReadOnly = true;
            this.dgvLoadNXB.Size = new System.Drawing.Size(668, 150);
            this.dgvLoadNXB.TabIndex = 0;
            this.dgvLoadNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoadNXB_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbTENNXB);
            this.groupBox1.Controls.Add(this.txbDIACHINXB);
            this.groupBox1.Controls.Add(this.txbTELNXB);
            this.groupBox1.Controls.Add(this.txbIDNXB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà xuất bản";
            // 
            // txbIDNXB
            // 
            this.txbIDNXB.Enabled = false;
            this.txbIDNXB.Location = new System.Drawing.Point(130, 30);
            this.txbIDNXB.Name = "txbIDNXB";
            this.txbIDNXB.Size = new System.Drawing.Size(243, 20);
            this.txbIDNXB.TabIndex = 2;
            // 
            // txbTELNXB
            // 
            this.txbTELNXB.Location = new System.Drawing.Point(130, 133);
            this.txbTELNXB.Name = "txbTELNXB";
            this.txbTELNXB.Size = new System.Drawing.Size(243, 20);
            this.txbTELNXB.TabIndex = 3;
            // 
            // txbDIACHINXB
            // 
            this.txbDIACHINXB.Location = new System.Drawing.Point(130, 96);
            this.txbDIACHINXB.Name = "txbDIACHINXB";
            this.txbDIACHINXB.Size = new System.Drawing.Size(243, 20);
            this.txbDIACHINXB.TabIndex = 4;
            // 
            // txbTENNXB
            // 
            this.txbTENNXB.Location = new System.Drawing.Point(130, 63);
            this.txbTENNXB.Name = "txbTENNXB";
            this.txbTENNXB.Size = new System.Drawing.Size(243, 20);
            this.txbTENNXB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Nhà xuất bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên nhà xuất bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Điện thoại";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefreshNXB);
            this.groupBox2.Controls.Add(this.btnDelNXB);
            this.groupBox2.Controls.Add(this.btnEditNXB);
            this.groupBox2.Controls.Add(this.btnAddNXB);
            this.groupBox2.Location = new System.Drawing.Point(450, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 175);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // btnAddNXB
            // 
            this.btnAddNXB.Location = new System.Drawing.Point(17, 70);
            this.btnAddNXB.Name = "btnAddNXB";
            this.btnAddNXB.Size = new System.Drawing.Size(189, 50);
            this.btnAddNXB.TabIndex = 3;
            this.btnAddNXB.Text = "Thêm";
            this.btnAddNXB.UseVisualStyleBackColor = true;
            this.btnAddNXB.Click += new System.EventHandler(this.btnAddNXB_Click);
            // 
            // btnEditNXB
            // 
            this.btnEditNXB.Location = new System.Drawing.Point(17, 22);
            this.btnEditNXB.Name = "btnEditNXB";
            this.btnEditNXB.Size = new System.Drawing.Size(78, 42);
            this.btnEditNXB.TabIndex = 4;
            this.btnEditNXB.Text = "Sửa";
            this.btnEditNXB.UseVisualStyleBackColor = true;
            this.btnEditNXB.Click += new System.EventHandler(this.btnEditNXB_Click);
            // 
            // btnDelNXB
            // 
            this.btnDelNXB.Location = new System.Drawing.Point(118, 22);
            this.btnDelNXB.Name = "btnDelNXB";
            this.btnDelNXB.Size = new System.Drawing.Size(88, 42);
            this.btnDelNXB.TabIndex = 5;
            this.btnDelNXB.Text = "Xóa";
            this.btnDelNXB.UseVisualStyleBackColor = true;
            this.btnDelNXB.Click += new System.EventHandler(this.btnDelNXB_Click);
            // 
            // btnRefreshNXB
            // 
            this.btnRefreshNXB.Location = new System.Drawing.Point(17, 133);
            this.btnRefreshNXB.Name = "btnRefreshNXB";
            this.btnRefreshNXB.Size = new System.Drawing.Size(189, 30);
            this.btnRefreshNXB.TabIndex = 6;
            this.btnRefreshNXB.Text = "Làm mới";
            this.btnRefreshNXB.UseVisualStyleBackColor = true;
            this.btnRefreshNXB.Click += new System.EventHandler(this.btnRefreshNXB_Click);
            // 
            // NhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLoadNXB);
            this.Name = "NhaXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhaXuatBan";
            this.Load += new System.EventHandler(this.NhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadNXB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoadNXB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbTENNXB;
        private System.Windows.Forms.TextBox txbDIACHINXB;
        private System.Windows.Forms.TextBox txbTELNXB;
        private System.Windows.Forms.TextBox txbIDNXB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefreshNXB;
        private System.Windows.Forms.Button btnDelNXB;
        private System.Windows.Forms.Button btnEditNXB;
        private System.Windows.Forms.Button btnAddNXB;
    }
}