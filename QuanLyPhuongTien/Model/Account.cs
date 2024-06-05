using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTien.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }  
        public string Name {  get; set; }
        public string Chucvu { get; set; }
        public int Type {  get; set; }
       
        public string Diachi {  get; set; }
        public string MaCV { get; set; }
        public Account(int id,string username,string password, string name,string chucvu,int type,string diachi,string maCV) 
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Chucvu = chucvu;
            this.Type = type;
            this.Diachi = diachi;
            this.MaCV = maCV;
            
        }
        public Account(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Username = row["userName"].ToString();
            this.Password = row["passWord"].ToString();
            this.Name = row["ten"].ToString();
            this.Chucvu = row["chucvu"].ToString();
            this.Type = (int)row["type"];
            this.Diachi = row["diachi"].ToString();
            this.MaCV = row["maCV"].ToString();
        }
    }
}
