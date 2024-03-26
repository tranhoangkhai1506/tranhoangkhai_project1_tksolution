using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tranhoangkhai_project1.Models
{
    public class ChiTietPhieuNhapKho
    {
        [Required]
        public string Nhap_Kho_ID { get; set; }
        [Required]
        public string San_Pham_ID { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SL_Nhap { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Don_Gia_Nhap { get; set; }
    }
}
