using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentManagment.Tests
{
    [TestClass]
    public class SearchSinhVienTests
    {
        private SinhVienBLL _bll = null!;

        [TestInitialize]
        public void Setup()
        {
            _bll = new SinhVienBLL();
        }

        #region Kiểm tra ngoại lệ MSSV để trống hoặc chỉ có khoảng trắng

        [TestMethod]
        public void SearchSinhVienByMSSV_MSSVRong_NemArgumentException()
        {
            try
            {
                // Act
                _bll.SearchSinhVienByMSSV("");
                Assert.Fail("Lẽ ra phải ném ArgumentException khi MSSV rỗng nhưng không ném.");
            }
            catch (ArgumentException ex)
            {
                // Assert: Bắt đúng ngoại lệ
                StringAssert.Contains(ex.Message, "không được để trống");
            }
        }

        [TestMethod]
        public void SearchSinhVienByMSSV_MSSVKhoangTrang_NemArgumentException()
        {
            try
            {
                // Act
                _bll.SearchSinhVienByMSSV("   ");
                Assert.Fail("Lẽ ra phải ném ArgumentException khi MSSV khoảng trắng nhưng không ném.");
            }
            catch (ArgumentException ex)
            {
                // Assert: Bắt đúng ngoại lệ
                StringAssert.Contains(ex.Message, "không được để trống");
            }
        }

        #endregion

        #region Kiểm tra ngoại lệ MSSV sai định dạng (^SV\d{3}$)

        [TestMethod]
        [DataRow("sv001")]      // Chữ thường 'sv'
        [DataRow("SV01")]       // Thiếu số (chỉ có 2 số)
        [DataRow("SV0001")]     // Thừa số (có 4 số)
        [DataRow("SVABC")]      // Không phải số
        [DataRow("NV001")]      // Sai tiền tố (không phải 'SV')
        [DataRow("SV 01")]      // Có khoảng trắng ở giữa
        public void SearchSinhVienByMSSV_MSSVSaiDinhDang_NemArgumentException(string mssvSai)
        {
            try
            {
                // Act
                _bll.SearchSinhVienByMSSV(mssvSai);
                Assert.Fail($"Lẽ ra phải ném ArgumentException với MSSV sai định dạng '{mssvSai}' nhưng không ném.");
            }
            catch (ArgumentException ex)
            {
                // Assert: Bắt đúng thông báo lỗi định dạng
                StringAssert.Contains(ex.Message, "không đúng định dạng");
            }
        }

        #endregion

        #region Kiểm tra tìm kiếm với MSSV đúng định dạng

        [TestMethod]
        [DataRow("SV001")]
        [DataRow("SV010")]
        [DataRow("  SV001  ")] // Kiểm tra tự động Trim() khoảng trắng hai đầu
        public void SearchSinhVienByMSSV_MSSVDungDinhDang_KhongNemNgoaiLeDinhDang(string mssvDung)
        {
            try
            {
                // Act: Gọi hàm BLL với MSSV hợp lệ
                _bll.SearchSinhVienByMSSV(mssvDung);
            }
            catch (ArgumentException ex)
            {
                // Nếu ném ArgumentException nghĩa là regex kiểm tra định dạng bị sai
                Assert.Fail($"MSSV hợp lệ '{mssvDung}' nhưng bị ném lỗi định dạng: {ex.Message}");
            }
            catch (Exception)
            {
                // Bỏ qua lỗi kết nối CSDL (SqlException) nếu môi trường chạy test không kết nối được DB
            }
        }

        #endregion
    }
}
