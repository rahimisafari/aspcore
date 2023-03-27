using aspcore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using aspcore.Models;

namespace aspcore.Pages;

public class CreateBugModel:PageModel {
    
    public readonly BugDbContext _db;

    public CreateBugModel(BugDbContext db)
    {
        _db=db;
    }
    [BindProperty]
    public string? name{get;set;}

    [BindProperty]
    public string? desc{get;set;}

    public void OnGet(){

    }

    public ActionResult OnPost(){
        _db.Bugs.Add(new Bug{name=name,description=desc,isDone=false});
        _db.SaveChanges();
        return RedirectToPage("./index");
    }
}