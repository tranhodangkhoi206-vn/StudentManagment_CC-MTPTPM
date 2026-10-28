namespace StudentManagment.DTO
{
    public class MonhocDTO
    {
	    // MAMON CHAR(10) NOT NULL,
	    // TENMON NVARCHAR(100) NOT NULL,
	    // MANGANH CHAR(10) NOT NULL,
	    // SOTIETLYTHUYET INT NOT NULL,
	    // SOTIETTHUCHANH INT NOT NULL,
	    // GIANGVIEN NVARCHAR(100) NOT NUL
	    // TINHTRANG NVARCHAR(30) NOT NULL
	    public string Mamon { get; set; }
	    public string Tenmon { get; set;}
	    public string Manganh { get; set;}
	    public int Sotietlythuyet { get; set;}
	    public int Sotietthuchanh { get; set; }
	    public string Giangvien { get;set; }
	    public string Tinhtrang { get; set;}
    }
}
