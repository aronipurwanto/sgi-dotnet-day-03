using StudyCase.Context;
using StudyCase.Entity;

namespace StudyCase.Service;

public class DbCustService
{
    // prop untuk dbcontext
    public StudyCaseDbContext _Context { get; set; }
    
    // contructor
    public DbCustService(StudyCaseDbContext context)
    {
        _Context = context;
    }

    public List<ExcepCust01> GetData01()
    {
        var query = (from cus in _Context.ExcepCust01s
            join status in _Context.StatusTindakLanjuts on cus.TindakLanjutId equals status.Id
            select new Entity.ExcepCust01()
            {
                TindakLanjut = status,
                CustomerNumber = cus.CustomerNumber,
                CustomerName = cus.CustomerName,
                CustomerDate = cus.CustomerDate,
                TindakLanjutId = cus.TindakLanjutId,
                Notes = cus.Notes,
                LastUpdatedBy = cus.LastUpdatedBy,
                LastUpdatedAt = cus.LastUpdatedAt

            }).ToList();
        
        return query;
    }
}