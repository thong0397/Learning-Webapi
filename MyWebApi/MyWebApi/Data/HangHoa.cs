using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Data
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public Guid MaHH { get; set; }
        [Required]
        [MaxLength(100)]
        public string TenHH { get; set; }

        public string MoTa { get; set; }
        [Range(0, double.MaxValue)]

        public double DonGia { get; set; }
        public byte GiamGia { get; set; }
    }
}
