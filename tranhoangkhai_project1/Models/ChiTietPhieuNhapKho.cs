using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tranhoangkhai_project1.Models
{
    public class ChiTietPhieuNhapKho
    {
        [Key]
        public int Id { get; set; }
        public string Nhap_Kho_ID { get; set; }
        public int San_Pham_ID { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SL_Nhap { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Don_Gia_Nhap { get; set; }
    }
}
