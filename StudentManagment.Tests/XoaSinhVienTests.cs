using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Tests
{
    [TestClass]
    public class XoaSinhVienTests
    {
        private SinhVienBLL bll = null!;

        [TestInitialize]
        public void Setup()
        {
            bll = new SinhVienBLL();
        }

        [TestMethod]
        public void XoaSinhVien_MSSVRong_NemArgumentException()
        {
            try
            {
                bll.XoaSinhVien("");
                Assert.Fail("Lẽ ra phải ném ArgumentException khi MSSV bị rỗng!");
            }
            catch (ArgumentException)
            {
                // Test Pass
            }
        }

        [TestMethod]
        public void XoaSinhVien_MSSVToanKhoangTrang_NemArgumentException()
        {
            try
            {
                bll.XoaSinhVien("      ");
                Assert.Fail("Lẽ ra phải ném ArgumentException khi MSSV toàn khoảng trắng!");
            }
            catch (ArgumentException)
            {
                // Test Pass
            }
        }

        [TestMethod]
        public void XoaSinhVien_MSSVNull_NemArgumentException()
        {
            try
            {
                bll.XoaSinhVien(null!);
                Assert.Fail("Lẽ ra phải ném ArgumentException khi MSSV là null!");
            }
            catch (ArgumentException)
            {
                // Test Pass
            }
        }

        [TestMethod]
        public void XoaSinhVien_MSSVBoTrong_KiemTraThongDiepLoi()
        {
            try
            {
                bll.XoaSinhVien("");
                Assert.Fail("Không ném ArgumentException khi MSSV trống!");
            }
            catch (ArgumentException ex)
            {
                StringAssert.Contains(ex.Message, "Mã số sinh viên (MSSV) cần xóa không được để trống!");
            }
        }
    }
}
