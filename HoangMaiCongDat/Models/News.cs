using System;
using System.ComponentModel.DataAnnotations;

namespace HoangMaiCongDat.Models
{
    public class News
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 50)]
        public string? Title { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 200)]
        public string? Content { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public string? Author { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [Required]
        public int CategoryId { get; set; }
        
        public Category? Category { get; set; }
        public IEnumerable<Comment>? ListComments { get; set; }
    }
}
