using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tranhoangkhai_project1.Models
{
    public class PhieuXuatKhoModel
    {
        [Key]
        public string So_Phieu_Xuat_Kho { get; set; }
        public string Kho_ID { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Ngay_Nhap_Kho { get; set; }
        public string Ghi_Chu { get; set; }
    }
}
