﻿using System.ComponentModel.DataAnnotations;

namespace tranhoangkhai_project1.Models
{
    public class KhoUserModel
    {
        [Key]
        public int Id { get; set; }
        public string Ma_Dang_Nhap { get; set; }
        public int Kho_ID { get; set; }
    }
}
