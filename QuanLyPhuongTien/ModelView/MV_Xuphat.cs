using QuanLyPhuongTien.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTien.ModelView
{
    public class MV_Xuphat
    {
        private static MV_Xuphat instance;

        public static MV_Xuphat Instance
        {
            get { if (instance == null) instance = new MV_Xuphat(); return instance; }
            private set { instance = value; }
        }

        private MV_Xuphat() { }
        public void InsertXuphat(string mabb, string bienso, string cccd, string ten, string vipham, string diadiem, string thoigian, string sotien, string maCBPT,string tenCBPT,string macbTH,string tencbTH)
        {
            string query = "INSERT INTO dbo.BienBan(maBienban,Bienso,cccd,ten,vipham,diadiem,thoigian,sotien,maCBTT,tenCBTT,maCBTH,tenCBTH)" +
                "VALUES('"+mabb+"','"+bienso+"','"+cccd+"',N'"+ten+"',N'"+vipham+"',N'"+diadiem+"','"+thoigian+"','"+sotien+"','"+maCBPT+"',N'"+tenCBPT+"','"+macbTH+"',N'"+tencbTH+"')";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<MD_Xuphat> LoadListBB()
        {
            List<MD_Xuphat> BBList = new List<MD_Xuphat>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BienBan");

            foreach (DataRow item in data.Rows)
            {
                MD_Xuphat dk = new MD_Xuphat(item);
                BBList.Add(dk);
            }

            return BBList;
        }
        public List<MD_Xuphat> SearchListBB(string timkiem)
        {
            List<MD_Xuphat> BBList = new List<MD_Xuphat>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BienBan WHERE maBienba='"+timkiem+"'OR Bienso='"+timkiem+"'");

            foreach (DataRow item in data.Rows)
            {
                MD_Xuphat dk = new MD_Xuphat(item);
                BBList.Add(dk);
            }

            return BBList;
        
        }
      
    }
}