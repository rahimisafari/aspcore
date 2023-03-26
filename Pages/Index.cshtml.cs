using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using aspcore.Classes;

namespace aspcore.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public string? currentYear{get;set;}
    public Bugs bugs=new Bugs();
    public void OnGet()
    {
        currentYear=DateTime.Now.Year.ToString();
        
    }
}
