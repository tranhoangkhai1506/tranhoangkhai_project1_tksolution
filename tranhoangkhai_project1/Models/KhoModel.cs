using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tranhoangkhai_project1.Models
{
    public class KhoModel
    {
        [Key]
        public int KhoId { get; set; }
        public string Ten_Kho { get; set; }
        public string Ghi_Chu { get; set; }
    }
}
