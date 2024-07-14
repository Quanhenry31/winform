using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Dangkitk
    {
        public void Dangki_tk(Taikhoan tk)
        {
            string query = $" SP_dk_Taikhoan @Username , @Pass , @Email , @Phanquyen , @Matma ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                tk.Username,
                tk.Pass,
                tk.Email,
                tk.Phanquyen,
                tk.Matma
             });
        }
        public void Doimk(Taikhoan tk)
        {
            string query = $" SP_cn_Taikhoan @Username , @Pass , @Email , @Phanquyen , @Matma ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                tk.Username,
                tk.Pass,
                tk.Email,
                tk.Phanquyen,
                tk.Matma
             });
        }
    
    }
}
