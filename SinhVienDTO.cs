using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment
{
    public class SinhVienDTO
    {
        public string MSSV { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public string Khoa { get; set; } = string.Empty;
        public string Lop { get; set; } = string.Empty;
        public double DiemGPA { get; set; }

        public SinhVienDTO() { }

        public SinhVienDTO(string mssv, string hoTen, string khoa, string lop, double diemGPA)
        {
            this.MSSV = mssv;
            this.HoTen = hoTen;
            this.Khoa = khoa;
            this.Lop = lop;
            this.DiemGPA = diemGPA;
        }
    }
}
