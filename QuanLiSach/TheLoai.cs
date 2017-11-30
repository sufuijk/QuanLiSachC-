using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;

namespace QuanLiSach
{
    public partial class TheLoai : Form
    {
        public TheLoai()
        {
            InitializeComponent();
        }
        private string query = "SELECT * FROM THELOAI";
        private int index;

        public void LoadData()
        {
            dgvLoadTheLoai.DataSource = Database.Instance.LoadData(query);
        }

        private void TheLoai_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddTL_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(query);
            DataRow newRow = table.NewRow();
            newRow["TENLOAI"] = txbTenTL.Text;
            table.Rows.Add(newRow);
            Database.Instance.Update(table);
            LoadData();
        }

        private void dgvLoadTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataTable table = Database.Instance.LoadData(query);
            if (index >= 0)
            {
                txbIDTL.Text = table.Rows[index]["ID_THELOAI"].ToString();
                txbTenTL.Text = table.Rows[index]["TENLOAI"].ToString();
            }
        }

        private void btnEditTL_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(query);
            table.Rows[index]["ID_THELOAI"] = txbIDTL.Text;
            table.Rows[index]["TENLOAI"] = txbTenTL.Text;
            Database.Instance.Update(table);
            LoadData();
        }

        private void btnDelTL_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(query);
            table.Rows[index].Delete();
            Database.Instance.Update(table);
            LoadData();
        }

        private void btnRefressTL_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
