using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class sinhvienBLL
    {
        private static sinhvienBLL instance;
        public static sinhvienBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new sinhvienBLL();
                return instance;
            }
        }
        private sinhvienBLL() { }
        public void xem(DataGridView data)
        {
            data.DataSource = sinhvienDAL.Instance.xem();
        }

        public void them(string hoten, DateTime ngsinh, string khoa, string lop, string hedt)
        {
            sinhvienDAL.Instance.them(hoten, ngsinh, khoa, lop, hedt);
        }

        public void xoa(int maSV)
        {
            sinhvienDAL.Instance.xoa(maSV);
        }

        public void sua(int maSV, string hoten, DateTime ngsinh, string khoa, string lop, string hedt)
        {
            sinhvienDAL.Instance.sua(maSV, hoten, ngsinh, khoa, lop, hedt);
        }
    }
}
