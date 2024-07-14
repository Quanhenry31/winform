using BUS;
using DTO;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using DLL;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLogin_KhongNhapMatKhau()
        {
            // Arrange
            BUS_Taikhoan loginForm = new BUS_Taikhoan();
            string username = "abc";
            string password = "";
            string phanQuyen = "";

            // Act
            bool result = loginForm.KiemTraTk(username, password, phanQuyen);

            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestLogin_KhongNhapTenTaiKhoan()
        {
            // Arrange
            BUS_Taikhoan loginForm = new BUS_Taikhoan();
            string username = "";
            string password = "abc";
            string phanQuyen = "";

            // Act
            bool result = loginForm.KiemTraTk(username, password, phanQuyen);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestLogin_KhongNhapTenTaiKhoan_MatKhau()
        {
            // Arrange
            BUS_Taikhoan loginForm = new BUS_Taikhoan();
            string username = "";
            string password = "";
            string phanQuyen = "Độc giả";

            // Act
            bool result = loginForm.KiemTraTk(username, password, phanQuyen);

            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void NO_TestLogin_KhongNhapTenTaiKhoan_MatKhau_Phanquyen()
        {
            // Arrange
            BUS_Taikhoan loginForm = new BUS_Taikhoan();
            string username = "";
            string password = "";
            string phanQuyen = "";

            // Act
            bool result = loginForm.KiemTraTk(username, password, phanQuyen);

            // Assert
            Assert.IsFalse(result);
        }



        [TestMethod]
        public void TestLogin_Nhậptatca()
        {
            // Arrange
            BUS_Taikhoan loginForm = new BUS_Taikhoan();
            string username = "a";
            string password = "a";
            string phanQuyen = "Độc giả";

            // Act
            bool result = loginForm.KiemTraTk(username, password, phanQuyen);

            // Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestLogin_Nhập_dungtk_saimk()
        {
            // Arrange
            BUS_Taikhoan loginForm = new BUS_Taikhoan();
            string username = "a";
            string password = "b";
            string phanQuyen = "Độc giả";

            // Act
            bool result = loginForm.KiemTraTk(username, password, phanQuyen);

            // Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void TestLogin_Nhập_saitk_dungmk()
        {
            // Arrange
            BUS_Taikhoan loginForm = new BUS_Taikhoan();
            string username = "b";
            string password = "a";
            string phanQuyen = "Độc giả";

            // Act
            bool result = loginForm.KiemTraTk(username, password, phanQuyen);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestLogin_Nhậpsaipq()
        {
            // Arrange
            BUS_Taikhoan loginForm = new BUS_Taikhoan();
            string username = "a";
            string password = "a";
            string phanQuyen = "";

            // Act
            bool result = loginForm.KiemTraTk(username, password, phanQuyen);

            // Assert
            Assert.IsFalse(result);
        }




        [TestMethod]
        public void thongtinrongtestThemsach_()
        {
            BUS_Dausach busds = new BUS_Dausach();
            Dausach dausach = new Dausach()
            {
                maDS = "",
                tenSach = "",
                namXB = DateTime.Parse("2003/01/31"),
                ngayNhap = DateTime.Parse("2003/02/01"),
                Gia = "",
                soLuong = 1,
                Linhvuc = "",
                Nhaxuatban = "",
                Tacgia = "",
                tinhTrang = ""

            };
            bool result = busds.dkaddds(dausach);
            Assert.IsTrue(result);
        }



        [TestMethod]
        public void testThemsach()
        {
            BUS_Dausach busds = new BUS_Dausach();
            Dausach dausach = new Dausach()
            {
                maDS = "100",
                tenSach = "Học thuật",
                namXB = DateTime.Parse("2003/01/31"),
                ngayNhap = DateTime.Parse("2003/02/01"),
                Gia = "113",
                soLuong = 3,
                Linhvuc = "Truyện",
                Nhaxuatban = "Kim đồng",
                Tacgia = "Trần quân",
                tinhTrang = "Còn"

            };
            bool result = busds.dkaddds(dausach);
            Assert.AreEqual(result, true);
        }


        [TestMethod]
        public void id_trungtestThemsach()
        {
            BUS_Dausach busds = new BUS_Dausach();
            Dausach dausach = new Dausach()
            {
                maDS = "100",
                tenSach = "Học thuật",
                namXB = DateTime.Parse("2003/01/31"),
                ngayNhap = DateTime.Parse("2003/02/01"),
                Gia = "113",
                soLuong = 3,
                Linhvuc = "Truyện",
                Nhaxuatban = "Kim đồng",
                Tacgia = "Trần quân",
                tinhTrang = "Còn"

            };
            bool result = busds.dkaddds(dausach);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void testSuasach()
        {
            BUS_Dausach busds = new BUS_Dausach();
            Dausach dausach = new Dausach()
            {
                maDS = "100",
                tenSach = "Học thuật",
                namXB = DateTime.Parse("2003/01/31"),
                ngayNhap = DateTime.Parse("2003/02/01"),
                Gia = "113",
                soLuong = 3,
                Linhvuc = "Truyện",
                Nhaxuatban = "Kim đồng",
                Tacgia = "Trần quân",
                tinhTrang = "Còn"

            };
            bool result = busds.dkupdateds(dausach);
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void testSuasach_loi()
        {
            BUS_Dausach busds = new BUS_Dausach();
            Dausach dausach = new Dausach()
            {
                maDS = "",
                tenSach = "Học thuật",
                namXB = DateTime.Parse("2003/01/31"),
                ngayNhap = DateTime.Parse("2003/02/01"),
                Gia = "113",
                soLuong = 3,
                Linhvuc = "Truyện",
                Nhaxuatban = "Kim đồng",
                Tacgia = "Trần quân",
                tinhTrang = "Còn"

            };
            bool result = busds.dkupdateds(dausach);
            Assert.IsFalse(result);
        }



        [TestMethod]
        public void testXoasach()
        {
            BUS_Dausach busds = new BUS_Dausach();
            string maDS = "100";
            bool result = busds.dkdeleteds(maDS);
            Assert.AreEqual(result, true);
        }



        [TestMethod]
        public void testXoasach_loi()
        {
            BUS_Dausach busds = new BUS_Dausach();
            string maDS = "";
            bool result = busds.dkdeleteds(maDS);
            Assert.AreEqual(result, true);
        }


        [TestMethod]
        public void oke_thongtinrongtestThemphieumuon()
        {
            BUS_Phieumuon buspm = new BUS_Phieumuon();
            Phieumuon phieumuon = new Phieumuon()
            {
                SoPhieu = "",
                Sothe = "",
                maDS = "",
                ngayMuon = DateTime.Parse("2003/01/31"),
                ngayTra = DateTime.Parse("2003/03/09"),
                Matt = ""
            };
            bool result = buspm.dkaddpm(phieumuon);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void thongtinkhoptestThemphieumuon_()
        {
            BUS_Phieumuon buspm = new BUS_Phieumuon();
            Phieumuon phieumuon = new Phieumuon()
            {
                SoPhieu = "1",
                Sothe = "1",
                maDS = "1",
                ngayMuon = DateTime.Parse("2003/01/31"),
                ngayTra = DateTime.Parse("2003/03/09"),
                Matt = "1"
            };
            bool result = buspm.dkaddpm(phieumuon);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void thongtin_oke_testThemphieumuon_()
        {
            BUS_Phieumuon buspm = new BUS_Phieumuon();
            Phieumuon phieumuon = new Phieumuon()
            {
                SoPhieu = "3",
                Sothe = "1",
                maDS = "1",
                ngayMuon = DateTime.Parse("2003/01/31"),
                ngayTra = DateTime.Parse("2003/03/09"),
                Matt = "1"
            };
            bool result = buspm.dkaddpm(phieumuon);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void sua_saima_testThemphieumuon_()
        {
            BUS_Phieumuon buspm = new BUS_Phieumuon();
            Phieumuon phieumuon = new Phieumuon()
            {
                SoPhieu = "1",
                Sothe = "1",
                maDS = "",
                ngayMuon = DateTime.Parse("2003/01/31"),
                ngayTra = DateTime.Parse("2003/03/09"),
                Matt = "1"
            };
            bool result = buspm.dkupdatepm(phieumuon);
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void sua_oke_testThemphieumuon_()
        {
            BUS_Phieumuon buspm = new BUS_Phieumuon();
            Phieumuon phieumuon = new Phieumuon()
            {
                SoPhieu = "1",
                Sothe = "1",
                maDS = "1",
                ngayMuon = DateTime.Parse("2003/01/31"),
                ngayTra = DateTime.Parse("2003/03/09"),
                Matt = "1"
            };
            bool result = buspm.dkupdatepm(phieumuon);
            Assert.IsFalse(result);


        }


        [TestMethod]
        public void testPhieumuon_loi()
        {
            BUS_Phieumuon buspm = new BUS_Phieumuon();
            string SoPhieu = "";
            bool result = buspm.dkdeletepm(SoPhieu);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void testPhieumuon_oke()
        {
            BUS_Phieumuon buspm = new BUS_Phieumuon();
            string SoPhieu = "1";
            bool result = buspm.dkdeletepm(SoPhieu);
            Assert.IsTrue(result);
            //Assert.AreEqual(result, true);
        }
    }

}
