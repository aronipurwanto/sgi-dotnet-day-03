using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudyCase.Context;
using StudyCase.Entity;
using StudyCase.Model;
using StudyCase.Service;

namespace StudyCase.Pages.ExcepCust;

public class DetailCust01Model : PageModel
{
    public Excep01Detail Data { get; set; }
    public DbCustService DbService { get; set; }

    public DetailCust01Model(StudyCaseDbContext context)
    {
        DbService = new DbCustService(context);
    }

    public void OnGet(String custNo, String dataDate)
    {
        Data = DbService.GetData01(custNo, dataDate);
        TempData["success"] = "Load data successfully..!";
    }

    public async Task<IActionResult> OnPost1()
    {
        return Page();
    }
    
    public async Task<IActionResult> OnPost2()
    {
        return Page();
    }
}