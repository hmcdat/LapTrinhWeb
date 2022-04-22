using System;
using System.ComponentModel.DataAnnotations;

namespace HoangMaiCongDat.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string? Content { get; set; }
        [Required]
        public string? Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        
        public News News {get; set; }
    }
}