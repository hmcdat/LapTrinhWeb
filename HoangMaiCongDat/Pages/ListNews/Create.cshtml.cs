#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HoangMaiCongDat.Data;
using HoangMaiCongDat.Models;

namespace HoangMaiCongDat.Pages.ListNews
{
    public class CreateModel : PageModel
    {
        private readonly HoangMaiCongDat.Data.HoangMaiCongDatContext _context;

        public CreateModel(HoangMaiCongDat.Data.HoangMaiCongDatContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public News News { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.News.Add(News);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
