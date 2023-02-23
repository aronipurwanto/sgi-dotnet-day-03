using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudyCase.Model;
using StudyCase.Service;

namespace StudyCase.Pages.ExcepCustomer;

public class DetailModel : PageModel
{
    public ExcepCustomerUpdate Data { get; set; }
    public readonly CustomerService Service;
    public DetailModel()
    {
        Service = new CustomerService();
    }

    public void OnGet()
    {
        
    }

    public async Task<IActionResult> OnPostAsync(ExcepCustomerUpdate Data)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        Service.UpdateData(Data);
        return RedirectToPage("Index");
    }
}