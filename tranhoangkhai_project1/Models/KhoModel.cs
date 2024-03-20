using System.ComponentModel.DataAnnotations;

namespace tranhoangkhai_project1.Models
{
    public class KhoModel
    {
        [Key]
        public string Ten_Kho { get; set; }
        public string Ghi_Chu { get; set; }
    }
}
