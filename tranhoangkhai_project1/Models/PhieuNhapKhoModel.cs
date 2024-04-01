using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tranhoangkhai_project1.Models
{
    public class PhieuNhapKhoModel
    {
        [Key]
        public string So_Phieu_Nhap_Kho { get; set; }
        public string Kho_ID { get; set; }
        [ForeignKey("Kho_ID")]
        public KhoModel Kho { get; set; }
        public string NCC_ID { get; set; }
        [ForeignKey("NCC_ID")]
        public NhaCungCapModel NhaCungCap { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Ngay_Nhap_Kho { get; set; }
        public string Ghi_Chu { get; set; }
    }
}
