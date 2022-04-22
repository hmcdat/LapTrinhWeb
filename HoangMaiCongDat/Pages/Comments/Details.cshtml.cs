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

namespace HoangMaiCongDat.Pages.Comments
{
    public class DetailsModel : PageModel
    {
        private readonly HoangMaiCongDat.Data.HoangMaiCongDatContext _context;

        public DetailsModel(HoangMaiCongDat.Data.HoangMaiCongDatContext context)
        {
            _context = context;
        }

        public Comment Comment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Comment = await _context.Comment.FirstOrDefaultAsync(m => m.Id == id);

            if (Comment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
