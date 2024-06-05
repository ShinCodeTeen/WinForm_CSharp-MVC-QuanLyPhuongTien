using QuanLyPhuongTien.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTien.ModelView
{
    public class MV_Tracuu
    {
        private static MV_Tracuu instance;

        public static MV_Tracuu Instance
        {
            get { if (instance == null) instance = new MV_Tracuu(); return instance; }
            private set { instance = value; }
        }

        private MV_Tracuu() { }
        public MD_DangKi SearchDki(string timkiem)
        {
            MD_DangKi dk = new MD_DangKi();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.DangKi WHERE Bienso='"+timkiem+"'OR maDKi='"+timkiem+"'");

            foreach (DataRow item in data.Rows)
            {
                dk = new MD_DangKi(item);
            }
            return dk;
        }
        public MD_BaoHiem SearchBaoHiem(string timkiem)
        {
            MD_BaoHiem bh = new MD_BaoHiem();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BaoHiem WHERE Bienso='" + timkiem + "'OR maBH='" + timkiem + "'");
            foreach (DataRow item in data.Rows)
            {
                bh = new MD_BaoHiem(item);
            }
            return bh;
        }
        public MD_Xuphat SearchXuPhat(string timkiem)
        {
            MD_Xuphat xp = new MD_Xuphat();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BienBan WHERE Bienso='" + timkiem + "'OR maBienban='" + timkiem + "'");
            foreach (DataRow item in data.Rows)
            {
                xp = new MD_Xuphat(item);
            }
            return xp;
        }
        public MD_Phuongtien SearchPhuongTien(string timkiem)
        {
            MD_Phuongtien pt = new MD_Phuongtien();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.PhuongTien WHERE Bienso='" + timkiem + "'");
            foreach (DataRow item in data.Rows)
            {
                pt = new MD_Phuongtien(item);
            }
            return pt;
        }
    }
}
