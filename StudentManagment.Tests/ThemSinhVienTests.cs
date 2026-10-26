using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentManagment;

namespace StudentManagment.Tests
{
    [TestClass]
    public class ThemSinhVienTests
    {
        // -------------------------------------------------------------
        // TEST CASE 1: THÊM THÀNH CÔNG VỚI ĐẦY ĐỦ DỮ LIỆU HỢP LỆ
        // -------------------------------------------------------------
        [TestMethod]
        public void ThemSinhVien_DuLieuHopLe_TraVeTrueVaDiemChinhXac()
        {
            // Arrange (Chuẩn bị dữ liệu)
            var bll = new SinhVienBLL();
            string mssv = "SV001";
            string hoTen = "Nguyễn Văn An";
            string lop = "DH24CT1";
            string khoa = "Kỹ thuật phần mềm";
            string gpaText = "3.75";

            // Act (Thực thi)
            bool ketQua = bll.KiemTraThongTinSinhVien(mssv, hoTen, lop, khoa, gpaText, out double gpa);

            // Assert (Kiểm tra kết quả)
            Assert.IsTrue(ketQua);
            Assert.AreEqual(3.75, gpa);
        }

        // -------------------------------------------------------------
        // TEST CASE 2: BẮT LỖI BỎ TRỐNG MÃ SỐ SINH VIÊN (MSSV)
        // -------------------------------------------------------------
        [TestMethod]
        public void ThemSinhVien_MSSVRong_BatLoiArgumentException()
        {
            // Arrange
            var bll = new SinhVienBLL();

            // Act & Assert bằng khối try...catch
            try
            {
                bll.KiemTraThongTinSinhVien("", "Nguyễn Văn An", "DH24CT1", "Kỹ thuật phần mềm", "3.5", out _);
                Assert.Fail("Lẽ ra phải ném ngoại lệ ArgumentException khi MSSV bị để trống!");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("mssv", ex.ParamName);
                StringAssert.Contains(ex.Message, "Mã số sinh viên (MSSV) không được để trống!");
            }
        }

        // -------------------------------------------------------------
        // TEST CASE 3: BẮT LỖI BỎ TRỐNG HỌ VÀ TÊN
        // -------------------------------------------------------------
        [TestMethod]
        public void ThemSinhVien_HoTenRong_BatLoiArgumentException()
        {
            // Arrange
            var bll = new SinhVienBLL();

            // Act & Assert bằng khối try...catch
            try
            {
                bll.KiemTraThongTinSinhVien("SV002", "   ", "DH24CT1", "An toàn thông tin", "3.2", out _);
                Assert.Fail("Lẽ ra phải ném ngoại lệ ArgumentException khi họ tên chỉ toàn khoảng trắng!");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("hoTen", ex.ParamName);
                StringAssert.Contains(ex.Message, "Họ và tên sinh viên không được để trống!");
            }
        }

        // -------------------------------------------------------------
        // TEST CASE 4: BẮT LỖI SAI ĐỊNH DẠNG LỚP QUY ĐỊNH
        // -------------------------------------------------------------
        [TestMethod]
        public void ThemSinhVien_LopKhongDungDinhDang_BatLoiArgumentException()
        {
            // Arrange: Lớp không thuộc tập hợp [DH24CT, DH24CT1, DH24CT2]
            var bll = new SinhVienBLL();
            string lopSai = "21DTH01";

            // Act & Assert bằng khối try...catch
            try
            {
                bll.KiemTraThongTinSinhVien("SV003", "Trần Bích Ngọc", lopSai, "An toàn thông tin", "3.0", out _);
                Assert.Fail("Lẽ ra phải ném ngoại lệ khi lớp không thuộc danh mục quy định!");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("lop", ex.ParamName);
                StringAssert.Contains(ex.Message, "Chỉ chấp nhận DH24CT, DH24CT1 hoặc DH24CT2!");
            }
        }

        // -------------------------------------------------------------
        // TEST CASE 5: BẮT LỖI SAI NGÀNH/KHOA NGOÀI 3 NGÀNH CHO PHÉP
        // -------------------------------------------------------------
        [TestMethod]
        public void ThemSinhVien_NganhNgoaiPhamViChoPhep_BatLoiArgumentException()
        {
            // Arrange: Ngành không thuộc [Kỹ thuật phần mềm, An toàn thông tin, Trí tuệ nhân tạo]
            var bll = new SinhVienBLL();
            string nganhSai = "Quản trị kinh doanh";

            // Act & Assert bằng khối try...catch
            try
            {
                bll.KiemTraThongTinSinhVien("SV004", "Lê Hoàng Nam", "DH24CT", nganhSai, "3.2", out _);
                Assert.Fail("Lẽ ra phải ném ngoại lệ khi ngành không hợp lệ!");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("khoa", ex.ParamName);
                StringAssert.Contains(ex.Message, "Chỉ chấp nhận: Kỹ thuật phần mềm, An toàn thông tin hoặc Trí tuệ nhân tạo!");
            }
        }

        // -------------------------------------------------------------
        // TEST CASE 6: BẮT LỖI ĐỊNH DẠNG SỐ CỦA GPA (KÝ TỰ CHỮ)
        // -------------------------------------------------------------
        [TestMethod]
        public void ThemSinhVien_GPASaiDinhDangSo_BatLoiFormatException()
        {
            // Arrange: GPA là chuỗi không chuyển đổi được sang số thực
            var bll = new SinhVienBLL();
            string gpaChu = "BaDiemRuoi";

            // Act & Assert bằng khối try...catch
            try
            {
                bll.KiemTraThongTinSinhVien("SV005", "Phạm Minh Tuấn", "DH24CT2", "Trí tuệ nhân tạo", gpaChu, out _);
                Assert.Fail("Lẽ ra phải ném ngoại lệ FormatException khi GPA là chuỗi ký tự chữ!");
            }
            catch (FormatException ex)
            {
                StringAssert.Contains(ex.Message, "không đúng định dạng số!");
            }
        }

        // -------------------------------------------------------------
        // TEST CASE 7: BẮT LỖI ĐIỂM VƯỢT BIÊN DƯỚI (GPA < 0.0)
        // -------------------------------------------------------------
        [TestMethod]
        public void ThemSinhVien_GPANhoHonKhong_BatLoiArgumentOutOfRangeException()
        {
            // Arrange: GPA mang giá trị âm (-0.5)
            var bll = new SinhVienBLL();
            string gpaAm = "-0.5";

            // Act & Assert bằng khối try...catch
            try
            {
                bll.KiemTraThongTinSinhVien("SV006", "Đỗ Quỳnh Hương", "DH24CT", "Kỹ thuật phần mềm", gpaAm, out _);
                Assert.Fail("Lẽ ra phải ném ngoại lệ ArgumentOutOfRangeException khi GPA < 0.0!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("gpa", ex.ParamName);
                StringAssert.Contains(ex.Message, "Điểm GPA phải nằm trong khoảng từ 0.0 đến 4.0!");
            }
        }

        // -------------------------------------------------------------
        // TEST CASE 8: BẮT LỖI ĐIỂM VƯỢT BIÊN TRÊN (GPA > 4.0)
        // -------------------------------------------------------------
        [TestMethod]
        public void ThemSinhVien_GPALonHonBon_BatLoiArgumentOutOfRangeException()
        {
            // Arrange: GPA vượt ngưỡng 4.0 (4.5)
            var bll = new SinhVienBLL();
            string gpaVuotBien = "4.5";

            // Act & Assert bằng khối try...catch
            try
            {
                bll.KiemTraThongTinSinhVien("SV007", "Vũ Quốc Huy", "DH24CT1", "Trí tuệ nhân tạo", gpaVuotBien, out _);
                Assert.Fail("Lẽ ra phải ném ngoại lệ ArgumentOutOfRangeException khi GPA > 4.0!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("gpa", ex.ParamName);
                StringAssert.Contains(ex.Message, "Điểm GPA phải nằm trong khoảng từ 0.0 đến 4.0!");
            }
        }

        // -------------------------------------------------------------
        // TEST CASE 9 & 10: KIỂM THỬ GIÁ TRỊ TẠI 2 ĐẦU BIÊN (GPA = 0.0 VÀ GPA = 4.0)
        // -------------------------------------------------------------
        [TestMethod]
        public void ThemSinhVien_GPATaiGiaTriBien0Va4_TraVeDung()
        {
            // Arrange
            var bll = new SinhVienBLL();

            // Act & Assert biên dưới (0.0)
            bool resultBienDuoi = bll.KiemTraThongTinSinhVien("SV008", "Đặng Gia Bảo", "DH24CT", "Kỹ thuật phần mềm", "0.0", out double gpa0);
            Assert.IsTrue(resultBienDuoi);
            Assert.AreEqual(0.0, gpa0);

            // Act & Assert biên trên (4.0)
            bool resultBienTren = bll.KiemTraThongTinSinhVien("SV009", "Hoàng Trọng Nghĩa", "DH24CT2", "An toàn thông tin", "4.0", out double gpa4);
            Assert.IsTrue(resultBienTren);
            Assert.AreEqual(4.0, gpa4);
        }
    }
}