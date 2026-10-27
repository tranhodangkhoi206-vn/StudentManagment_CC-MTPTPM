namespace StudentManagment.DTO
{
    public class SinhvienDTO
    {
        // MASV CHAR(10) NOT NULL,
        // HOVATEN NVARCHAR(50) NOT NULL,
        // MALOP CHAR(10) NOT NULL,
        // NGAYSINH DATE NOT NULL,
        // GIOITINH NVARCHAR(10) NOT NULL,
        // MANGANH CHAR(10) NOT NULL,
        // TINHTRANG NVARCHAR(30) NOT NULL

        public  string MaSinhVien { get; set; }
	    public  string HoVaTen { get; set;} 
	    public  string MaLop { get; set;}
	    public DateTime NgaySinh { get; set;}
	    public string GioiTinh { get; set;}
	    public string MaNganh { get; set;}
	    public string TinhTrang { get; set;}
    }
}
