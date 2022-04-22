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

namespace HoangMaiCongDat.Pages.ListNews
{
    public class IndexModel : PageModel
    {
        private readonly HoangMaiCongDat.Data.HoangMaiCongDatContext _context;

        public IndexModel(HoangMaiCongDat.Data.HoangMaiCongDatContext context)
        {
            _context = context;
        }

        public IList<News> News { get;set; }

        public async Task OnGetAsync()
        {
            News = await _context.News
                .Include(n => n.Category).ToListAsync();
        }
    }
}
