using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using aspcore.Data;
using aspcore.Models;

namespace aspcore.Pages;

public class DeleteBugModel:PageModel{

    public readonly BugDbContext _db;
    [BindProperty]
    public Bug selectedBug{get;set;}
    public DeleteBugModel(BugDbContext db)
    {
        _db=db;
    }

    public void OnGet(int id){
        selectedBug=_db.Bugs.Find(id);
    }
    public IActionResult OnPost(int id){
        _db.Bugs.Remove(_db.Bugs.Find(id));
        _db.SaveChanges();
        TempData["msg"]="Bug deleted succesed.";
        return RedirectToPage("./index");
    }
}