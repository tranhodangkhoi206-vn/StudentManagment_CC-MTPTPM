using System.Data;
using Microsoft.Extensions.Logging;
using StudentManagment.DAL.Util;

namespace StudentManagment.BLL
{
public class TrangchuBLL
    {
        private readonly ILogger<TrangchuBLL> logger;
        private SinhvienDAL sinhVienDAL;
        private LopDAL lopDAL;
        private MonhocDAL monHocDAL;
	    public TrangchuBLL(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<TrangchuBLL>();
            sinhVienDAL = new SinhvienDAL(loggerFactory);
            lopDAL = new LopDAL(loggerFactory);
            monHocDAL = new MonhocDAL(loggerFactory);
        }

	    public int TinhTongSinhVien()
        {
            DataTable dt = sinhVienDAL.LayToanBoSinhVien();
            int tongSinhVien = dt.Rows.Count;
            return tongSinhVien;
        }
	    public int TinhTongLopHoc()
        {
            DataTable dt = lopDAL.LayToanBoLopHoc();
            int tongLopHoc = dt.Rows.Count;
            return tongLopHoc;
        }
	    public int TinhTongMonHoc()
        {
            DataTable dt = monHocDAL.LayToanBoMonHoc();
            int tongMonHoc = dt.Rows.Count;
            return tongMonHoc;
        }
    }
}
