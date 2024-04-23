using System.ComponentModel.DataAnnotations;

namespace tranhoangkhai_project1.Models
{
    public class SanPhamModel
    {
        [Key]
        public int Id { get; set; }
        public string Ma_San_Pham { get; set; }
        public string Ten_San_Pham { get; set; }
        public int Loai_San_Pham_ID { get; set; }
        public int Don_Vi_Tinh_ID { get; set; }
        public string Ghi_Chu { get; set; }
    }
}
