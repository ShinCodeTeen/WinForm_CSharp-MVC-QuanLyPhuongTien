using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTien.Model
{
    public class MD_DangKiem
    {
        public int Id { get; set; }
        public string madkiem { get; set; }
        public string madki { get; set; }
        public string thoigian { get; set; }
        public string macb { get; set; }
        public string tencb { get; set; }
        public string chusohuu {  get; set; }
        public string bienso {  get; set; }
        public MD_DangKiem(DataRow row) {
            this.Id = (int)row["id"];
            this.madkiem = row["maDkiem"].ToString();
            this.madki = row["maDki"].ToString();
            this.thoigian = row["thoigian"].ToString();
            this.macb = row["maCB"].ToString();
            this.tencb = row["tenCB"].ToString();
            this.bienso = row["bienso"].ToString();
            this.chusohuu = row["chusohuu"].ToString();
        }
        public MD_DangKiem() { }
    }
}
