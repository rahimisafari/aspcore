using aspcore.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using aspcore.Data;
using Microsoft.AspNetCore.Mvc;

namespace aspcore.Pages;

public class EditBugModel:PageModel{

    public readonly BugDbContext _db;

    [BindProperty]
    public Bug selectedBug{get;set;}
    public EditBugModel(BugDbContext db)
    {
        _db=db;
    }
    public void OnGet(int id){
        selectedBug=_db.Bugs.Find(id);
    }

    public IActionResult OnPost(int id){
        var bug=_db.Bugs.Find(id);
        bug.name=selectedBug.name;
        bug.description=selectedBug.description;
        bug.isDone=selectedBug.isDone;
        _db.SaveChanges();
        TempData["msg"]="Record Updated.";
        return RedirectToPage("./index");

    }
    
}