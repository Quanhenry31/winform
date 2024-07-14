using BUS;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class BUS_Thuthu
    {
        DAL_Thuthu tt = new DAL_Thuthu();
        public DataTable ThuThu()
        {
            return tt.ThuThu();
        }

        public void addThuTHu(Thuthu thuthu)
        {
            tt.addThuTHu(thuthu);
        }
        public void suaThuThu(Thuthu thuthu)
        {
            tt.suaThuThu(thuthu);
        }
        public void xoaThuThu(string Matt)
        {
            tt.xoaThuThu(Matt);
        }
        public DataTable Timkiem(string keyword)
        {
            return tt.Timkiem(keyword);
        }

        public void KetXuatWord(string exportPath)
        {

            WordHelper.ExportToWord(tt.ThuThu(), "Template\\ViewThuthu_Template.docx", exportPath, new List<string>()
            {
                "Quequan"
            });
        }

        public void XuatExcel(string filePath)
        {
            ExcelHelper.WriteExcelFile(filePath, "Template\\Thuthu.xlsx", tt.ThuThu());
        }
    }
}
