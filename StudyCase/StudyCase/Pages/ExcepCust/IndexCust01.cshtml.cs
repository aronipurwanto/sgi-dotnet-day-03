using Microsoft.AspNetCore.Mvc.RazorPages;
using StudyCase.Context;
using StudyCase.Entity;
using StudyCase.Model;
using StudyCase.Service;

namespace StudyCase.Pages.ExcepCust;

public class IndexCust01Model : PageModel
{
    // data binding
    public List<ExcepCust01Model> Data { get; set; }
    // dbservice
    public DbCustService dbService { get; set; }
    
    // contructor
    public IndexCust01Model(StudyCaseDbContext context)
    {
        dbService = new DbCustService(context);
    }

    public void OnGet()
    {
        Data = dbService.GetData01()
            .Select(x => new ExcepCust01Model(x))
            .ToList();
        
        TempData["success"] = "Load Data is Success";
    }
}