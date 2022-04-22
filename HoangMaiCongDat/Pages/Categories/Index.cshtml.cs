#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HoangMaiCongDat.Data;
using HoangMaiCongDat.Models;

namespace HoangMaiCongDat.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly HoangMaiCongDat.Data.HoangMaiCongDatContext _context;

        public IndexModel(HoangMaiCongDat.Data.HoangMaiCongDatContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
