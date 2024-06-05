using QuanLyPhuongTien.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTien.ModelView
{
    public class MV_BaoHiem
    {
        private static MV_BaoHiem instance;

        public static MV_BaoHiem Instance
        {
            get { if (instance == null) instance = new MV_BaoHiem(); return instance; }
            private set { instance = value; }
        }

        private MV_BaoHiem() { }
        public void InsertBaoHiem(string mabh, string bienso, string cccd, string tenchuxe,string ngaydk, string hsd, string manv, string tennv)
        {
            string query = "INSERT INTO dbo.BaoHiem(maBH,Bienso,cccd,TenChuxe,ngayDK,hansudung,maNV,tenNV)" +
                "VALUES('" + mabh + "','" + bienso + "','" + cccd + "', N'" + tenchuxe + "','"+ngaydk+"','" + hsd + "','" + manv + "',N'" + tennv + "')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<MD_BaoHiem> LoadListBH()
        {
            List<MD_BaoHiem> DKList = new List<MD_BaoHiem>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BaoHiem ");

            foreach (DataRow item in data.Rows)
            {
                MD_BaoHiem dk = new MD_BaoHiem(item);
                DKList.Add(dk);
            }

            return DKList;
        }
        public List<MD_BaoHiem> SearchListBH(string timkiem)
        {
            List<MD_BaoHiem> DKList = new List<MD_BaoHiem>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BaoHiem WHERE maBH LIKE '"+timkiem+"' OR Bienso LIKE '"+timkiem+"' ");

            foreach (DataRow item in data.Rows)
            {
                MD_BaoHiem dk = new MD_BaoHiem(item);
                DKList.Add(dk);
            }

            return DKList;
        }
    }
}
