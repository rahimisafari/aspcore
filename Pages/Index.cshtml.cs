using Microsoft.AspNetCore.Mvc;
using aspcore.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using aspcore.Classes;
using aspcore.Models;

namespace aspcore.Pages;

public class IndexModel : PageModel
{
    //private readonly ILogger<IndexModel> _logger;
    public readonly BugDbContext _db;
    
    public IndexModel(BugDbContext db)
    {
        _db = db;
    }

    // public IndexModel(ILogger<IndexModel> logger)
    // {
    //     _logger = logger;
    // }

    public string? currentYear{get;set;}
    //public Bugs bugs=new Bugs();
    public IList<Bug>? bugs;
    public void OnGet()
    {
        currentYear=DateTime.Now.Year.ToString();
        bugs=_db.Bugs.ToList();
    }
}
