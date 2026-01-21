using System.ComponentModel.DataAnnotations;

namespace MyWebApi.Models
{
    public class LoaiModel
    {
        [Required]
        [MaxLength(100)]
        public string TenLoai { get; set; }
    }
}
