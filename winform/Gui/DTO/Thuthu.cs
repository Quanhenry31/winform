using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thuthu
    {
        public string Matt { get; set; }
        public string Hotentt { get; set; }
        public string Gioitinhtt { get; set; }
        public DateTime ngaySinhtt { get; set; }
        public string Chucvu { get; set; }
        public string Sdt { get; set; }
        public string Quequantt { get; set; }

        public Thuthu() { }

        public Thuthu(string matt, string hotentt, string gioitinhtt, DateTime ngaySinhtt, string chucvu, string sdt, string quequantt)
        {
            Matt = matt;
            Hotentt = hotentt;
            Gioitinhtt = gioitinhtt;
            this.ngaySinhtt = ngaySinhtt;
            Chucvu = chucvu;
            Sdt = sdt;
            Quequantt = quequantt;
        }
    }
}
