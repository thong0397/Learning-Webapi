namespace MyWebApi.Models
{
    public class HangHoaVM
    {
        public string TenHangHoa { get; set; }
        public string DonGia { get; set; }
    }

    public class HangHoa1 : HangHoaVM
    {
        public Guid MaHangHoa { get; set; }
    }
}
