using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HoangMaiCongDat.Pages;

public class IndexModel : PageModel
{
    // private readonly ILogger<IndexModel> _logger;

    // public IndexModel(ILogger<IndexModel> logger)
    // {
    //     _logger = logger;
    // }

    private readonly HoangMaiCongDat.Data.HoangMaiCongDatContext _context;

    public IndexModel(HoangMaiCongDat.Data.HoangMaiCongDatContext context)
    {
        _context = context;
    }

    public IList<HoangMaiCongDat.Models.News> News { get; set; }

    public async Task OnGetAsync()
    {
        News = await _context.News.ToListAsync();
    }

}