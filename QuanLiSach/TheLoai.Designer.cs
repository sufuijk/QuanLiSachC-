namespace QuanLiSach
{
    partial class TheLoai
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
            this.dgvLoadTheLoai = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenTL = new System.Windows.Forms.TextBox();
            this.txbIDTL = new System.Windows.Forms.TextBox();
            this.btnAddTL = new System.Windows.Forms.Button();
            this.btnEditTL = new System.Windows.Forms.Button();
            this.btnDelTL = new System.Windows.Forms.Button();
            this.btnRefressTL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTheLoai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoadTheLoai
            // 
            this.dgvLoadTheLoai.AllowUserToAddRows = false;
            this.dgvLoadTheLoai.AllowUserToDeleteRows = false;
            this.dgvLoadTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadTheLoai.Location = new System.Drawing.Point(12, 149);
            this.dgvLoadTheLoai.Name = "dgvLoadTheLoai";
            this.dgvLoadTheLoai.ReadOnly = true;
            this.dgvLoadTheLoai.Size = new System.Drawing.Size(586, 150);
            this.dgvLoadTheLoai.TabIndex = 0;
            this.dgvLoadTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoadTheLoai_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbTenTL);
            this.groupBox1.Controls.Add(this.txbIDTL);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Thể loại";
            // 
            // txbTenTL
            // 
            this.txbTenTL.Location = new System.Drawing.Point(120, 70);
            this.txbTenTL.Name = "txbTenTL";
            this.txbTenTL.Size = new System.Drawing.Size(237, 20);
            this.txbTenTL.TabIndex = 1;
            // 
            // txbIDTL
            // 
            this.txbIDTL.Location = new System.Drawing.Point(120, 30);
            this.txbIDTL.Name = "txbIDTL";
            this.txbIDTL.Size = new System.Drawing.Size(237, 20);
            this.txbIDTL.TabIndex = 0;
            // 
            // btnAddTL
            // 
            this.btnAddTL.Location = new System.Drawing.Point(427, 40);
            this.btnAddTL.Name = "btnAddTL";
            this.btnAddTL.Size = new System.Drawing.Size(75, 23);
            this.btnAddTL.TabIndex = 2;
            this.btnAddTL.Text = "Thêm";
            this.btnAddTL.UseVisualStyleBackColor = true;
            this.btnAddTL.Click += new System.EventHandler(this.btnAddTL_Click);
            // 
            // btnEditTL
            // 
            this.btnEditTL.Location = new System.Drawing.Point(523, 40);
            this.btnEditTL.Name = "btnEditTL";
            this.btnEditTL.Size = new System.Drawing.Size(75, 23);
            this.btnEditTL.TabIndex = 3;
            this.btnEditTL.Text = "Sửa";
            this.btnEditTL.UseVisualStyleBackColor = true;
            this.btnEditTL.Click += new System.EventHandler(this.btnEditTL_Click);
            // 
            // btnDelTL
            // 
            this.btnDelTL.Location = new System.Drawing.Point(427, 82);
            this.btnDelTL.Name = "btnDelTL";
            this.btnDelTL.Size = new System.Drawing.Size(75, 23);
            this.btnDelTL.TabIndex = 4;
            this.btnDelTL.Text = "Xóa";
            this.btnDelTL.UseVisualStyleBackColor = true;
            this.btnDelTL.Click += new System.EventHandler(this.btnDelTL_Click);
            // 
            // btnRefressTL
            // 
            this.btnRefressTL.Location = new System.Drawing.Point(523, 80);
            this.btnRefressTL.Name = "btnRefressTL";
            this.btnRefressTL.Size = new System.Drawing.Size(75, 23);
            this.btnRefressTL.TabIndex = 5;
            this.btnRefressTL.Text = "Làm mới";
            this.btnRefressTL.UseVisualStyleBackColor = true;
            this.btnRefressTL.Click += new System.EventHandler(this.btnRefressTL_Click);
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 311);
            this.Controls.Add(this.btnRefressTL);
            this.Controls.Add(this.btnDelTL);
            this.Controls.Add(this.btnEditTL);
            this.Controls.Add(this.btnAddTL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLoadTheLoai);
            this.Name = "TheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheLoai";
            this.Load += new System.EventHandler(this.TheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadTheLoai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoadTheLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenTL;
        private System.Windows.Forms.TextBox txbIDTL;
        private System.Windows.Forms.Button btnAddTL;
        private System.Windows.Forms.Button btnEditTL;
        private System.Windows.Forms.Button btnDelTL;
        private System.Windows.Forms.Button btnRefressTL;
    }
}