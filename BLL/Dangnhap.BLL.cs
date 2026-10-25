using Microsoft.Extensions.Logging;

namespace StudentManagment.BLL
{
    public class Dangnhap
    {
        private readonly ILogger<Dangnhap> _logger;
        // Khởi tạo constructor để lấy logger từ form
        public Dangnhap(ILogger<Dangnhap> logger)
        {
            _logger = logger;
        }
        public bool KiemTraDangNhap(string username, string password)
        {
            try
            {
                bool kiemTraUsername = string.IsNullOrEmpty(username);
                bool kiemTraPassword = string.IsNullOrEmpty(password);
                if (kiemTraUsername || kiemTraPassword)
                {
                    _logger.LogInformation("Nguoi dung chua nhap du thong tin");
                    return false;
                }
            }
            catch (Exception ex)
            {

            }
            return true;
        }
    }
}
