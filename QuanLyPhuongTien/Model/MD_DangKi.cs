using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTien.Model
{
    public class MD_DangKi
    {
        public int Id { get; set; }
        public string madki { get; set; }
        public string bienso { get; set; }
        public string tenxe { get; set; }
        public string loaixe { get; set; }
        public string dacdiem { get; set; }
        public string cccd { get; set; }
        public string thoigian { get; set; }
        public string macb { get; set; }
        public string tencb { get; set; }
        public string tencsh { get; set; }
        public MD_DangKi(int id,string madki,string bienso, string tenxe,string loaixe, string dacdiem,string cccd,string thoigian,string macb,string tencb,string tencsh) {
            this.Id = id;
            this.madki = madki;
            this.bienso = bienso;
            this.tenxe = tenxe;
            this.tencb = tencb;
            this.tencsh = tencsh;
            this.loaixe = loaixe;
            this.dacdiem = dacdiem;
            this.cccd = cccd;
            this.thoigian = thoigian;
            this.macb=macb;
            this.tencb=tencb;
        }
        public MD_DangKi(DataRow row) {
            this.Id = (int)row["id"];
            this.madki = row["maDKi"].ToString();
            this.bienso = row["Bienso"].ToString();
            this.tenxe = row["tenxe"].ToString();
            this.loaixe = row["loaixe"].ToString();
            this.dacdiem = row["dacdiem"].ToString();
            this.cccd = row["cccd"].ToString();
            this.macb = row["MaCB"].ToString();
            this.tencb = row["TenCB"].ToString();
            this.tencsh = row["tenchuSH"].ToString();
            this.thoigian = row["thoigian"].ToString() ;
        }
        public MD_DangKi() { }
    }
}
