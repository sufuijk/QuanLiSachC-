using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSach
{
    public partial class NhaXuatBan : Form
    {
        public NhaXuatBan()
        {
            InitializeComponent();
        }
        private string query = "SELECT * FROM NHAXUATBAN";
        private int index;

        public void LoadData()
        {
            dgvLoadNXB.DataSource = Database.Instance.LoadData(query);
        }
        private void NhaXuatBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddNXB_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(query);
            DataRow newRow = table.NewRow();
            newRow["TENNXB"] = txbTENNXB.Text;
            newRow["DIACHI"] = txbDIACHINXB.Text;
            newRow["DIENTHOAI"] = txbTELNXB.Text;
            table.Rows.Add(newRow);
            Database.Instance.Update(table);
            LoadData();
        }

        private void btnEditNXB_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(query);
            
            table.Rows[index]["ID_NXB"] = txbIDNXB.Text;
            table.Rows[index]["TENNXB"] = txbTENNXB.Text;
            table.Rows[index]["DIACHI"] = txbDIACHINXB.Text;
            table.Rows[index]["DIENTHOAI"] = txbTELNXB.Text;
            Database.Instance.Update(table);
            LoadData();
        }

        private void dgvLoadNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = Database.Instance.LoadData(query);
            index = e.RowIndex;
            if (index >= 0)
            {
                txbIDNXB.Text = table.Rows[index]["ID_NXB"].ToString();
                txbTENNXB.Text = table.Rows[index]["TENNXB"].ToString();
                txbDIACHINXB.Text = table.Rows[index]["DIACHI"].ToString();
                txbTELNXB.Text = table.Rows[index]["DIENTHOAI"].ToString();
            }

        }

        private void btnDelNXB_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(query);
            table.Rows[index].Delete();
            Database.Instance.Update(table);
            LoadData();
        }

        private void btnRefreshNXB_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
