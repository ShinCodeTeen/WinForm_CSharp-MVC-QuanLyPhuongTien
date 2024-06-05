using QuanLyPhuongTien.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTien.ModelView
{
    public class MV_Account
    {
        private static MV_Account instance;

        public static MV_Account Instance
        {
            get { if (instance == null) instance = new MV_Account(); return instance; }
            private set { instance = value; }
        }

        private MV_Account() { }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM dbo.Account WHERE userName = N'" + userName + "' AND passWord = N'" + passWord + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public Account GetAccount(string username) {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE userName='" + username + "'");
            foreach (DataRow row in data.Rows)
            {
                return new Account(row);
            }
            return null;
        }

        public void CreateAccount(string username, string password, string name, string chucvu, int type, string diachi,string MaCV) {
            string query = "INSERT INTO dbo.Account(userName,passWord,type,ten,chucvu,diachi,maCV)" +
                "VALUES('" + username + "','" + password + "','" + type + "',N'" + name + "','" + chucvu + "',N'" + diachi + "','"+MaCV+"')";
            
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public List<Account> GetListAc() {
            List<Account> accounts = new List<Account>();
            string query = "SELECT * FROM dbo.Account";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Account ac = new Account(item);
                accounts.Add(ac);
            }
            return accounts;
        }
        public List<Account> GetAc(string ten, string macv)
        {
            List<Account> accounts = new List<Account>();
            string query = "SELECT * FROM dbo.Account WHERE ten =N'"+ten+"' OR maCV ='"+macv+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Account ac = new Account(item);
                accounts.Add(ac);
            }
            return accounts;
        }
        public List<PhanQuyen> GetPhanquyen()
        {
            List<PhanQuyen> pq = new List<PhanQuyen>();
            string query = "SELECT * FROM ChucVu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                PhanQuyen ac = new PhanQuyen(item);
                pq.Add(ac);
            }
            return pq;
        }
        public void UpdateAC(string username,string newPW)
        {
            string query = "Update Account Set passWord = '"+newPW+"' WHERE userName ='"+username+"'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void DeletAC(string username)
        {
            string query = "Delete Account Where userName ='"+username+"'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
