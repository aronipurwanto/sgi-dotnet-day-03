using StudyCase.Context;
using StudyCase.Entity;

namespace StudyCase.Service;

public class DbCustService
{
    public StudyCaseDbContext _Context { get; set; }
    public DbCustService(StudyCaseDbContext context)
    {
        _Context = context;
    }

    public List<ExcepCust01> GetData01()
    {
        return _Context.ExcepCust01s.ToList();
    }
}