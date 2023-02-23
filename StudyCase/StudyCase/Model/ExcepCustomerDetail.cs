using StudyCase.Entity;

namespace StudyCase.Model;

public class ExcepDetail
{
    public ExcepCust01 Cust01 { get; set; }
    public List<ExcepCust01Detail> Details { get; set; }
}