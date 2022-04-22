using System;
using System.ComponentModel.DataAnnotations;

namespace HoangMaiCongDat.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public IEnumerable<News>? ListNews { get; set; }
    }
}