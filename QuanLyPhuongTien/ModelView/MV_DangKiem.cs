using QuanLyPhuongTien.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTien.ModelView
{
    public class MV_DangKiem
    {
        private static MV_DangKiem instance;

        public static MV_DangKiem Instance
        {
            get { if (instance == null) instance = new MV_DangKiem(); return instance; }
            private set { instance = value; }
        }

        private MV_DangKiem() { }
        public void InsertDangKiem(string madk, string madki, string thoigian, string macb, string tencb,string bienso,string chusohuu)
        {
            string query = "INSERT INTO dbo.DangKiem(maDkiem,maDki,thoigian,maCB,TenCB,bienso,chusohuu)" +
                "VALUES('"+madk+"','"+madki+"','"+thoigian+"','"+macb+"',N'"+tencb+"','"+bienso+"',N'"+chusohuu+"')";


            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<MD_DangKiem> LoadListDK()
        {
            List<MD_DangKiem> DKList = new List<MD_DangKiem>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.DangKiem ");

            foreach (DataRow item in data.Rows)
            {
                MD_DangKiem dk = new MD_DangKiem(item);
                DKList.Add(dk);
            }

            return DKList;
        }
        public List<MD_DangKiem> SearchDKiemList(string timkiem)
        {
            List<MD_DangKiem> DKList = new List<MD_DangKiem>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT* FROM dbo.DangKiem WHERE maDKiem='" + timkiem + "'OR bienso='" + timkiem + "'");

            foreach (DataRow item in data.Rows)
            {
                MD_DangKiem dk = new MD_DangKiem(item);
                DKList.Add(dk);
            }

            return DKList;
        }
    }
}