using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhuongTien.Model
{
    public class PhanQuyen
    {
        public int type { get; set; }
        public string chucvu {  get; set; } 
        public PhanQuyen(DataRow row) {
            this.type =(int) row["type"];
            this.chucvu = row["chucvu"].ToString();
        }
    }
}
