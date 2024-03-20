using System.ComponentModel.DataAnnotations;

namespace tranhoangkhai_project1.Models
{
    public class LoaiSanPhamModel
    {
        [Key]
        public string Ma_LSP { get; set; }
        public string Ten_LSP { get; set; }
        public string Ghi_Chu { get; set; }
    }
}
