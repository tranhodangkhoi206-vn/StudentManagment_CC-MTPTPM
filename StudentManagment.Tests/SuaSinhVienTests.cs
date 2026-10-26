using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentManagment;

namespace StudentManagment.Tests
{
    [TestClass]
    public class SuaSinhVienTests
    {
        private SinhVienBLL bll = null!;

        [TestInitialize]
        public void Setup()
        {
            bll = new SinhVienBLL();
        }

        // ==========================================
        // 1. NHÓM TEST CASE HỢP LỆ (SUCCESS SCENARIOS)
        // ==========================================

        [TestMethod]
        public void SuaSinhVien_DuLieuHopLe_TraVeTrueVaDiemChinhXac()
        {
            double gpa;
            bool ketQua = bll.KiemTraThongTinSinhVien("SV001", "Nguyễn Văn An Cập Nhật", "DH24CT1", "Kỹ thuật phần mềm", "3.75", out gpa);

            Assert.IsTrue(ketQua);
            Assert.AreEqual(3.75, gpa, 0.001);
        }

        [TestMethod]
        public void SuaSinhVien_GPASuDungDauPhay_ChuyenDoiDungSoThuc()
        {
            double gpa;
            bool ketQua = bll.KiemTraThongTinSinhVien("SV001", "Trần Thị Cập Nhật", "DH24CT", "An toàn thông tin", "3,85", out gpa);

            Assert.IsTrue(ketQua);
            Assert.AreEqual(3.85, gpa, 0.001);
        }

        [TestMethod]
        public void SuaSinhVien_GPATaiGiaTriBien0Va4_TraVeTrue()
        {
            double gpaMin, gpaMax;
            bool hopLeMin = bll.KiemTraThongTinSinhVien("SV001", "Sinh Viên Min", "DH24CT", "Trí tuệ nhân tạo", "0.0", out gpaMin);
            bool hopLeMax = bll.KiemTraThongTinSinhVien("SV001", "Sinh Viên Max", "DH24CT2", "Kỹ thuật phần mềm", "4.0", out gpaMax);

            Assert.IsTrue(hopLeMin);
            Assert.AreEqual(0.0, gpaMin, 0.001);
            Assert.IsTrue(hopLeMax);
            Assert.AreEqual(4.0, gpaMax, 0.001);
        }

        // ==========================================
        // 2. NHÓM TEST CASE BỎ TRỐNG HOẶC RỖNG DỮ LIỆU
        // ==========================================

        [TestMethod]
        public void SuaSinhVien_MSSVRong_NemArgumentException()
        {
            try
            {
                bll.KiemTraThongTinSinhVien("", "Nguyễn Văn A", "DH24CT1", "Kỹ thuật phần mềm", "3.0", out _);
                Assert.Fail("Lẽ ra phải ném ArgumentException khi MSSV bị rỗng!");
            }
            catch (ArgumentException)
            {
                // Test Pass thành công vì đã bắt đúng ngoại lệ
            }
        }

        [TestMethod]
        public void SuaSinhVien_MSSVToanKhoangTrang_NemArgumentException()
        {
            try
            {
                bll.KiemTraThongTinSinhVien("    ", "Nguyễn Văn A", "DH24CT1", "Kỹ thuật phần mềm", "3.0", out _);
                Assert.Fail("Lẽ ra phải ném ArgumentException khi MSSV toàn khoảng trắng!");
            }
            catch (ArgumentException)
            {
                // Test Pass
            }
        }

        [TestMethod]
        public void SuaSinhVien_HoTenBoTrong_NemArgumentException()
        {
            try
            {
                bll.KiemTraThongTinSinhVien("SV001", "   ", "DH24CT1", "Kỹ thuật phần mềm", "3.0", out _);
                Assert.Fail("Lẽ ra phải ném ArgumentException khi Họ tên bị trống!");
            }
            catch (ArgumentException)
            {
                // Test Pass
            }
        }

        [TestMethod]
        public void SuaSinhVien_GPABoTrong_NemArgumentException()
        {
            try
            {
                bll.KiemTraThongTinSinhVien("SV001", "Nguyễn Văn A", "DH24CT1", "Kỹ thuật phần mềm", "", out _);
                Assert.Fail("Lẽ ra phải ném ArgumentException khi GPA bị trống!");
            }
            catch (ArgumentException)
            {
                // Test Pass
            }
        }

        // ==========================================
        // 3. NHÓM TEST CASE SAI QUY ĐỊNH LỚP / NGÀNH
        // ==========================================

        [TestMethod]
        public void SuaSinhVien_LopSaiQuyDinh_NemArgumentException()
        {
            try
            {
                bll.KiemTraThongTinSinhVien("SV001", "Nguyễn Văn A", "21DTH01", "Kỹ thuật phần mềm", "3.0", out _);
                Assert.Fail("Lẽ ra phải ném ArgumentException khi nhập sai lớp quy định!");
            }
            catch (ArgumentException)
            {
                // Test Pass
            }
        }

        [TestMethod]
        public void SuaSinhVien_NganhSaiQuyDinh_NemArgumentException()
        {
            try
            {
                bll.KiemTraThongTinSinhVien("SV001", "Nguyễn Văn A", "DH24CT1", "Hệ thống thông tin", "3.0", out _);
                Assert.Fail("Lẽ ra phải ném ArgumentException khi nhập sai ngành quy định!");
            }
            catch (ArgumentException)
            {
                // Test Pass
            }
        }

        // ==========================================
        // 4. NHÓM TEST CASE ĐIỂM GPA NGOÀI PHẠM VI HOẶC SAI KIỂU
        // ==========================================

        [TestMethod]
        public void SuaSinhVien_GPALonHon4_NemArgumentOutOfRangeException()
        {
            try
            {
                bll.KiemTraThongTinSinhVien("SV001", "Nguyễn Văn A", "DH24CT1", "Kỹ thuật phần mềm", "4.2", out _);
                Assert.Fail("Lẽ ra phải ném ArgumentOutOfRangeException khi GPA > 4.0!");
            }
            catch (ArgumentOutOfRangeException)
            {
                // Test Pass
            }
        }

        [TestMethod]
        public void SuaSinhVien_GPANhoHon0_NemArgumentOutOfRangeException()
        {
            try
            {
                bll.KiemTraThongTinSinhVien("SV001", "Nguyễn Văn A", "DH24CT1", "Kỹ thuật phần mềm", "-0.5", out _);
                Assert.Fail("Lẽ ra phải ném ArgumentOutOfRangeException khi GPA < 0.0!");
            }
            catch (ArgumentOutOfRangeException)
            {
                // Test Pass
            }
        }

        [TestMethod]
        public void SuaSinhVien_GPALaChuoiKyTu_NemFormatException()
        {
            try
            {
                bll.KiemTraThongTinSinhVien("SV001", "Nguyễn Văn A", "DH24CT1", "Kỹ thuật phần mềm", "ba_diem", out _);
                Assert.Fail("Lẽ ra phải ném FormatException khi GPA là chuỗi chữ cái!");
            }
            catch (FormatException)
            {
                // Test Pass
            }
        }
    }
}
