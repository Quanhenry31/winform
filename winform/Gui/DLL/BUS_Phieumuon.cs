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
    public class BUS_Phieumuon
    {
        DAL_Phieumuon pm = new DAL_Phieumuon();
        public DataTable Phieumuon()
        {
            return pm.Phieumuon();
        }
        public DataTable Phieumuon_chitiet()
        {
            return pm.Phieumuon_chitiet();
        }
        public DataTable Tim_pm(string tensach,string sophieu)
        {
            return pm.Tim_PM(tensach,sophieu);
        }
        public void themPhieumuon(Phieumuon PM)
        {
             pm.themPhieumuon(PM);
        }
        public void suaPhieumuon(Phieumuon PM)
        {
            pm.suaPhieumuon(PM);
        }
        public void xoaPhieumuon(string Sothe)
        {
            pm.xoaPhieumuon(Sothe);
        }
        public DataTable Getsothe()
        {
            return pm.Getsothe();
        }
        public DataTable Getmatt()
        {
            return pm.Getmatt();
        }
        public DataTable Timkiem(string keyword)
        {
            return pm.Timkiem(keyword); 
        }


        public bool dkaddpm(Phieumuon phieumuon)
        {
            try
            {
            return pm.dkaddPM(phieumuon);

            }
            catch (Exception)
            {

                return true;
            }
        }

        public bool dkupdatepm(Phieumuon phieumuon)
        {
            return pm.dkupdatePM(phieumuon);
        }

        public bool dkdeletepm(string SoPhieu)
        {
            return pm.dkdeletePM(SoPhieu);
        }
    }
}
