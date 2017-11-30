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
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
        }
        string query = "SELECT * FROM SACH";
        string query1 = "SELECT * FROM NHAXUATBAN";
        string query2 = "SELECT * FROM THELOAI";


        private int index;

        public void LoadData()
        {
            DataTable table1 = Database.Instance.LoadData(query1);
            DataTable table2 = Database.Instance.LoadData(query2);

            dgvLoadSach.DataSource = Database.Instance.LoadData(query);
            cbxNXB.DataSource = table1;
            cbxNXB.DisplayMember = "TENNXB";
            cbxNXB.ValueMember = "ID_NXB";

            cbxTL.DataSource = table2;
            cbxTL.DisplayMember = "TENLOAI";
            cbxTL.ValueMember = "ID_THELOAI";
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddSach_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(query);
            DataRow newRow = table.NewRow();
            newRow["TENSACH"] = txbTENSACH.Text;
            newRow["TACGIA"] = txbTACGIA.Text;
            newRow["ID_NXB"] = cbxNXB.SelectedValue;
            newRow["ID_THELOAI"] = cbxTL.SelectedValue;
            newRow["SOTRANG"] = txbSOTRANG.Text;
            newRow["GIABIA"] = txbGIABIA.Text;
            table.Rows.Add(newRow);
            Database.Instance.Update(table);
            LoadData();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvLoadSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataTable table = Database.Instance.LoadData(query);
            if(index >= 0)
            {
                txbIDSACH.Text = table.Rows[index]["ID_SACH"].ToString();
                txbTENSACH.Text = table.Rows[index]["TENSACH"].ToString();
                txbTACGIA.Text = table.Rows[index]["TACGIA"].ToString();
                txbSOTRANG.Text = table.Rows[index]["SOTRANG"].ToString();
                txbGIABIA.Text = table.Rows[index]["GIABIA"].ToString();
                cbxNXB.SelectedValue = table.Rows[index]["ID_NXB"].ToString();
                cbxTL.SelectedValue = table.Rows[index]["ID_THELOAI"].ToString();
            }
        }

        private void btnDelSach_Click(object sender, EventArgs e)
        {
            DataTable table = Database.Instance.LoadData(query);
            table.Rows[index].Delete();
            Database.Instance.Update(table);
            LoadData();
        }
    }
}
