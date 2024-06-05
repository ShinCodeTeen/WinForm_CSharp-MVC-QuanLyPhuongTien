using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTien.Model
{
    public class MD_Xuphat
    {
        public MD_Xuphat() { }
        public int Id { get; set; }
        public string maBienban { get; set; }
        public string bienso { get; set; }
        public string cccd { get; set; }
        public string ten { get; set; }
        public string vipham { get; set; }
        public string diadiem { get; set; }
        public string thoigian { get; set; }
        public string sotien { get; set; }
        public string tencb { get; set; }
        public string macb { get; set; }
     
        public MD_Xuphat(DataRow row)
        {
            this.Id = (int)row["id"];
            this.maBienban = row["maBienban"].ToString();
            this.bienso = row["Bienso"].ToString();
            this.cccd = row["cccd"].ToString();
            this.ten = row["ten"].ToString();
            this.vipham = row["vipham"].ToString();
            this.diadiem = row["diadiem"].ToString();
            this.thoigian = row["thoigian"].ToString();
            this.sotien = row["sotien"].ToString();
            this.macb = row["maCBTT"].ToString();
            this.tencb = row["tenCBTT"].ToString();
   
        }
        public MD_Xuphat(int id, string maBienban, string bienso, string cccd, string ten, string vipham, string diadiem, string thoigian, string sotien, string tencb, string macb)
        {
            this.Id = id;
            this.maBienban = maBienban;
            this.bienso = bienso;
            this.cccd = cccd;
            this.ten = ten;
            this.vipham = vipham;
            this.diadiem = diadiem;
            this.thoigian = thoigian;
            this.sotien = sotien;
            this.tencb = tencb;
            this.macb = macb;
            
        }       
    }
}
