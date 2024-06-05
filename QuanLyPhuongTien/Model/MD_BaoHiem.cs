using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTien.Model
{
    public class MD_BaoHiem
    {
        public int Id { get; set; }
        public string maBH {  get; set; }
        public string Bienso { get; set; }
        public string cccd { get; set; }
        public string tenchuxe { get; set; }
        public string ngaydki { get; set; }
        public string hansudung { get; set; }
        public string manv { get; set; }
        public string tennv { get; set; }

        public MD_BaoHiem(DataRow row ) {
            this.Id = (int)row["id"];
            this.maBH = row["maBH"].ToString();
            this.cccd = row["cccd"].ToString();
            this.tenchuxe = row["TenChuxe"].ToString();
            this.ngaydki = row["ngayDK"].ToString();
            this.hansudung = row["hansudung"].ToString();
            this.manv = row["maNV"].ToString();
            this.tennv = row["tenNV"].ToString();
            this.Bienso = row["Bienso"].ToString() ;
        }
        public MD_BaoHiem() { }
    }
}
