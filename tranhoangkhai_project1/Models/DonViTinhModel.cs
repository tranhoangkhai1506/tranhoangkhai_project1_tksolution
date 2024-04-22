using System.ComponentModel.DataAnnotations;

namespace tranhoangkhai_project1.Models
{
    public class DonViTinhModel
    {
        [Key]
        public int DonViTinhID { get; set; }
        public string Ten_Don_Vi_Tinh { get; set; }
        public string Ghi_Chu { get; set; }
    }
}
