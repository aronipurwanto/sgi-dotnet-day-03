using Microsoft.AspNetCore.Mvc.RazorPages;
using StudyCase.Service;

namespace StudyCase.Pages.ExcepCustomer;

public class IndexModel : PageModel
{
    public List<Entity.ExcepCust01> Data { get; set; }
    public void OnGet()
    {
        CustomerService service = new CustomerService();
        Data = service.GetExcepDataJoin();
    }
}