using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class DAL_Phieumuon
    {
        public DataTable Phieumuon()
        {
            string query = $"hienthi_Phieumuon";
            return DBconnect.Instance.ExecuteQuery(query);
        }
        public DataTable Phieumuon_chitiet()
        {
            string query = $"SP_Ct_Pm";
            return DBconnect.Instance.ExecuteQuery(query);
        }

        public DataTable Tim_PM(string tensach,string sophieu)
        {
            string query = $"SP_Ct_Pm_tim @TenSach , @SoPhieu ";
            return DBconnect.Instance.ExecuteQuery(query);
        }
        public void themPhieumuon(Phieumuon pm)
        {
            string query = $"SP_Them_PhienMuon @SoPhieu , @Sothe , @maDS , @ngayMuon , @ngayTra , @Matt , @Soluong";
            DBconnect.Instance.ExecuteQuery(query, new object[]
           {
                pm.SoPhieu,
                pm.Sothe,
                pm.maDS,
                pm.ngayMuon,
                pm.ngayTra,
                pm.Matt,
                pm.Soluong
           });
        }
        public void suaPhieumuon(Phieumuon pm)
        {
            string query = $"SP_Sua_Phieumuon @SoPhieu , @Sothe , @maDS , @ngayMuon , @ngayTra , @Matt , @Soluong";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                pm.SoPhieu,
                pm.Sothe,
                pm.maDS,
                pm.ngayMuon,
                pm.ngayTra,
                pm.Matt,
                pm.Soluong
            });
        }
        public void xoaPhieumuon(string Sophieu)
        {
            string query = $"SP_Xoa_Phieumuon @SoPhieu";
            DBconnect.Instance.ExecuteQuery(query, new object[] { Sophieu});
        }

        public DataTable Getsothe()
        {
            string query = $"select * from DocGia";
            return DBconnect.Instance.ExecuteQuery(query);
        }
        public DataTable Getmatt()
        {
            string query = $"select * from ThuThu";
            return DBconnect.Instance.ExecuteQuery(query);
        }
        public DataTable Timkiem(string keyword)
        {
            string query = "SP_Tim_Phieumuon @key ";

            return DBconnect.Instance.ExecuteQuery(query, new object[] { keyword });
        }



        public bool dkaddPM(Phieumuon pm)
        {
            string query = $"SP_Them_PhienMuon @SoPhieu , @Sothe , @maDS , @ngayMuon , @ngayTra , @Matt";
            return DBconnect.Instance.ExecuteNonQuery(query, new object[]
           {
                pm.SoPhieu,
                pm.Sothe,
                pm.maDS,
                pm.ngayMuon,
                pm.ngayTra,
                pm.Matt
            }) > 0;
        }

        public bool dkupdatePM(Phieumuon pm)
        {
            string query = $"SP_Sua_Phieumuon @SoPhieu , @Sothe , @maDS , @ngayMuon , @ngayTra , @Matt";
            return DBconnect.Instance.ExecuteNonQuery(query, new object[]
            {
                pm.SoPhieu,
                pm.Sothe,
                pm.maDS,
                pm.ngayMuon,
                pm.ngayTra,
                pm.Matt
            }) > 0;
        }
        public bool dkdeletePM(string SoPhieu)
        {
            string query = $"SP_Xoa_Phieumuon @SoPhieu";
            return DBconnect.Instance.ExecuteNonQuery(query, new object[] { SoPhieu }) > 0;
        }
    }
}
