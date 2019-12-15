using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class sinhvienDAL
    {
        SinhVienEntities db = new SinhVienEntities();
        private  static sinhvienDAL instance;
        public static sinhvienDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new sinhvienDAL();
                return instance;
            }
        }
        private sinhvienDAL() { }
        public List<sVien> xem()
        {
            List<sVien> sVien = new List<sVien>();
            var result = from s in db.sViens select s;
            sVien = result.ToList();
            return sVien;
        }

        public bool them(string hoten, DateTime ngsinh, string khoa, string lop, string hedt )
        {
            sVien sinhvien = new sVien();
            sinhvien.hoten = hoten;
            sinhvien.ngsinh = ngsinh;
            sinhvien.khoa = khoa;
            sinhvien.lop = lop;
            sinhvien.hedaotao = hedt;
            db.sViens.Add(sinhvien);
            db.SaveChanges();
            return true;
        }

        public bool sua(int maSV, string hoten, DateTime ngsinh, string khoa, string lop, string hedt)
        {
            sVien svien = db.sViens.Where(p => p.maSV == maSV).SingleOrDefault();
            svien.hoten = hoten;
            svien.ngsinh = ngsinh;
            svien.khoa = khoa;
            svien.lop = lop;
            svien.hedaotao = hedt;
            db.SaveChanges();
            return false;
        }

        public bool xoa(int maSV)
        {
            sVien sinhvien = db.sViens.Where(p => p.maSV == maSV).SingleOrDefault();
            //db.sViens.Find(p => p.maSV == maSV);
            db.sViens.Remove(sinhvien);
            db.SaveChanges();
            return true;
        }
    }
}
