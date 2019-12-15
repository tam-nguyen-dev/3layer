using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sinhvienBLL.Instance.xem(dtgvds);
            AddBinding();
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            sinhvienBLL.Instance.xem(dtgvds);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string hoten = txthoten.Text;
            DateTime ngsinh = Convert.ToDateTime(txtngsinh.Text);
            string khoa = txtkhoa.Text;
            string lop = txtlop.Text;
            string hedt = txthedt.Text;
            sinhvienBLL.Instance.them(hoten, ngsinh, khoa, lop, hedt);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int maSV = Convert.ToInt32(txtmasv.Text);
            string hoten = txthoten.Text;
            DateTime ngsinh = Convert.ToDateTime(txtngsinh.Text);
            string khoa = txtkhoa.Text;
            string lop = txtlop.Text;
            string hedt = txthedt.Text;
            sinhvienBLL.Instance.sua(maSV, hoten, ngsinh, khoa, lop, hedt);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int maSV = Convert.ToInt32(txtmasv.Text);
            sinhvienBLL.Instance.xoa(maSV);
        }

        void AddBinding()
        {
            txtmasv.DataBindings.Add(new Binding("Text", dtgvds.DataSource, "maSV", true, DataSourceUpdateMode.OnPropertyChanged));
            txthoten.DataBindings.Add(new Binding("Text", dtgvds.DataSource, "hoten", true, DataSourceUpdateMode.OnPropertyChanged));
            txtngsinh.DataBindings.Add(new Binding("Text", dtgvds.DataSource, "ngsinh", true, DataSourceUpdateMode.OnPropertyChanged));
            txtkhoa.DataBindings.Add(new Binding("Text", dtgvds.DataSource, "khoa", true, DataSourceUpdateMode.OnPropertyChanged));
            txtlop.DataBindings.Add(new Binding("Text", dtgvds.DataSource, "lop", true, DataSourceUpdateMode.OnPropertyChanged));
            txthedt.DataBindings.Add(new Binding("Text", dtgvds.DataSource, "hedaotao", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
