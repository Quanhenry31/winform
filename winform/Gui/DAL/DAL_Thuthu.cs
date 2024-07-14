using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Thuthu
    {
        public DataTable ThuThu()
        {
            string query = $"SP_hienthi_ThuThu";
            return DBconnect.Instance.ExecuteQuery(query);
        }

        public void addThuTHu(Thuthu tt)
        {
            string query = $"SP_Them_ThuThu @Matt , @Hotentt , @Gioitinhtt , @ngaySinhtt , @Chucvu ,  @Sdt , @Quequantt ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
           {
                tt.Matt,
                tt.Hotentt,
                tt.Gioitinhtt,
                tt.ngaySinhtt,
                tt.Chucvu,
                tt.Sdt,
                tt.Quequantt
            });
        }
        public void suaThuThu(Thuthu tt)
        {
            string query = $"SP_Sua_ThuThu @Matt , @Hotentt , @Gioitinhtt , @ngaySinhtt , @Chucvu ,  @Sdt , @Quequantt ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                tt.Matt,
                tt.Hotentt,
                tt.Gioitinhtt,
                tt.ngaySinhtt,
                tt.Chucvu,
                tt.Sdt,
                tt.Quequantt
            });
        }

        public void xoaThuThu(string Matt)
        {
            string query = $"SP_Xoa_Thuthu @Matt";
            DBconnect.Instance.ExecuteQuery(query, new object[] { Matt });

        }
        public DataTable Timkiem(string keyword)
        {  
            string query = "SP_Tim_Thuthu @key ";

            return DBconnect.Instance.ExecuteQuery(query, new object[] { keyword });
        }
    }
}
