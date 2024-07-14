using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{

    public class BUS_Dangkitk
    {
        DAL_Dangkitk TK = new DAL_Dangkitk();
        public void themTaikhoan(Taikhoan tk)
        {
            TK.Dangki_tk(tk);
        }
        public void Doi_mk(Taikhoan tk)
        {
            TK.Doimk(tk);
        }
    }
}
   
