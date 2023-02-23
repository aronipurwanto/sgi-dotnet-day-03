using System.Runtime.InteropServices.JavaScript;
using StudyCase.Context;
using StudyCase.Entity;
using StudyCase.Model;

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

    public Excep01Detail GetData01(String custNo, String dataDate)
    {
        var cust01 = _Context.ExcepCust01s
            .Where(x => x.CustomerNumber.Equals(custNo) && x.CustomerDate.Equals(Convert.ToDateTime(dataDate)))
            .SingleOrDefault();

        var detail = _Context.ExcepCust01Details
            .Where(x => x.CustomerNumber.Equals(custNo) && x.DataDate.Equals(Convert.ToDateTime(dataDate)))
            .ToList();
        
        return new Excep01Detail(cust01, detail);
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