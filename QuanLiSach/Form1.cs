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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.ShowDialog();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheLoai theloai = new TheLoai();
            theloai.ShowDialog();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaXuatBan nhaxuatban = new NhaXuatBan();
            nhaxuatban.ShowDialog();
        }
    }
}
