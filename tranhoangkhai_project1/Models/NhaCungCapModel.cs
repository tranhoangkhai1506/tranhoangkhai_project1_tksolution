using System.ComponentModel.DataAnnotations;

namespace tranhoangkhai_project1.Models
{
    public class NhaCungCapModel
    {
        [Key]
        public int Id { get; set; }
        public string Ma_NCC { get; set; }
        public string Ten_NCC { get; set; }
        public string Ghi_Chu { get; set; }
    }
}
