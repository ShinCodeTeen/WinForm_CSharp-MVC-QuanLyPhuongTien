using QuanLyPhuongTien.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTien.ModelView
{
    public class MV_DangKi
    {
        private static MV_DangKi instance;

        public static MV_DangKi Instance
        {
            get { if (instance == null) instance = new MV_DangKi(); return instance; }
            private set { instance = value; }
        }

        private MV_DangKi() { }
        public void InsertDangKi(string madki, string bienso,string tenxe,string loaixe, string dacdiem,string cccd,string macb,string tencb,string tencsh)
        {
            string query = "INSERT INTO dbo.DangKi(maDKi,Bienso,tenxe,loaixe,dacdiem,cccd,thoigian,MaCB,TenCB,tenchuSH)" +
                "VALUES('"+madki+"','"+bienso+"',N'"+tenxe+"','"+loaixe+"', N'"+dacdiem+"','"+cccd+"',DEFAULT,'"+macb+"',N'"+tencb+"',N'"+tencsh+"')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<MD_DangKi> LoadDKList()
        {
            List<MD_DangKi> DKList = new List<MD_DangKi>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.DangKi");

            foreach (DataRow item in data.Rows) 
            {
                MD_DangKi dk = new MD_DangKi(item);
                DKList.Add(dk);
            }

            return DKList;
        }
        public List<MD_DangKi> SearchDKList(string timkiem)
        {
            List<MD_DangKi> DKList = new List<MD_DangKi>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT* FROM dbo.DangKi WHERE maDKi LIKE '"+timkiem+"'OR Bienso LIKE '"+timkiem+"'");

            foreach (DataRow item in data.Rows)
            {
                MD_DangKi dk = new MD_DangKi(item);
                DKList.Add(dk);
            }

            return DKList;
        }
        public void UpdateDki(string bienso,string cccd,string tencsh,string madki)
        {
            string query = "UPDATE dbo.DangKi " +
                "SET Bienso ='"+bienso+"',cccd='"+cccd+"',tenchuSH=N'"+tencsh+"'"+" WHERE maDki='"+madki+"'";
            DataProvider.Instance.ExecuteNonQuery(query);

        }
        public void DeletDki(string bienso,string madki)
        {
            string query = "Delete dbo.Dangki WHERE maDki = '"+madki+"' and Bienso ='"+bienso+"'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
