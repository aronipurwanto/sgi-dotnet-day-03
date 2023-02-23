using StudyCase.Entity;

namespace StudyCase.Model;

public class Excep01Detail
{
    public ExcepCust01 Cust01 { get; set; }
    public List<ExcepCust01Detail> Details { get; set; }

    public Excep01Detail()
    {
    }

    public Excep01Detail(ExcepCust01 cust01, List<ExcepCust01Detail> details)
    {
        Cust01 = cust01;
        Details = details;
    }
}