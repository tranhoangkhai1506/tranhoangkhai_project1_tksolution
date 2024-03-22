using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tranhoangkhai_project1.Models
{
    public class PhieuNhapKhoModel
    {
        [Key]
        public string So_Phieu_Nhap_Kho { get; set; }
        public string Kho_ID { get; set; }
        public string NCC_ID { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Ngay_Nhap_Kho { get; set; }
        public string Ghi_Chu { get; set; }
    }
}
