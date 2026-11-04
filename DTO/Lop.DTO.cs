namespace StudentManagment.DTO
{
public class LopDTO
    {
        // MALOP CHAR(10) NOT NULL,
        // MANGANH CHAR(10) NOT NULL,
        // TENLOP NVARCHAR(50) NOT NULL,
        // GIANGVIENPHUTRACH NVARCHAR(100) NOT NULL
        public string Malop { get; set; } = string.Empty;
        public string Manganh { get; set; } = string.Empty;
        public string Tenlop { get; set; } = string.Empty;
        public string Giangvienphutrach { get; set; } = string.Empty;
    }
}
