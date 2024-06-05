using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTien.Model
{
    public class MD_Phuongtien
    {
        public int Id { get; set; }
        public string tenpt { get; set; }  
        public string chusohuu {  get; set; }
        public string bienso { get;set; }
        public string madki { get; set; }
        public string madkiem { get; set; }
        public string maBH { get; set; }
        public int sobienban { get; set; }
        public MD_Phuongtien(DataRow row) {
            this.Id = (int)row["id"];
            this.tenpt = row["tenPT"].ToString();
            this.chusohuu = row["tenCSH"].ToString();
            this.bienso = row["Bienso"].ToString();
            this.madki = row["maDKi"].ToString();
            this.madkiem = row["maDKiem"].ToString();
            this.maBH = row["maBH"].ToString();
            this.sobienban =(int) row["sobienban"];
        }
        public MD_Phuongtien() { }
    }
}
