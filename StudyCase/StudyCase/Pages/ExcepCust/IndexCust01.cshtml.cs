using Microsoft.AspNetCore.Mvc.RazorPages;
using StudyCase.Context;
using StudyCase.Entity;
using StudyCase.Service;

namespace StudyCase.Pages.ExcepCust;

public class IndexCust01Model : PageModel
{
    public List<ExcepCust01> Data { get; set; }
    public DbCustService dbService { get; set; }
    
    public IndexCust01Model(StudyCaseDbContext context)
    {
        dbService = new DbCustService(context);
    }

    public void OnGet()
    {
        Data = dbService.GetData01();
    }
}