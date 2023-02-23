using StudyCase.Entity;

namespace StudyCase.Service;

public class CustomerService
{
    public List<ExcepCustomer> GetExcepDataJoin()
    {
        var query = (from cus in this.GetExcepData()
            join status in this.GetStatusTindakLanjut() on cus.Status equals status.Id
            select new Entity.ExcepCustomer()
            {
                TindakLanjut = status,
                CustomerNumber = cus.CustomerNumber,
                CustomerName = cus.CustomerName,
                CustomerDate = cus.CustomerDate,
                Status = cus.Status,
                Notes = cus.Notes,
                LastUpdatedBy = cus.LastUpdatedBy,
                LastUpdatedAt = cus.LastUpdatedAt

            }).ToList();
        
        return query;
    }
    public List<StatusTindakLanjut> GetStatusTindakLanjut()
    {
        List<StatusTindakLanjut> result = new List<StatusTindakLanjut>()
        {
            new StatusTindakLanjut(1, "-"),
            new StatusTindakLanjut(2, "In Proses"),
            new StatusTindakLanjut(3, "Suspicious"),
            new StatusTindakLanjut(4, "Not Suspicious")
        };
        return result;
    }
    
    public List<ExcepCustomer> GetExcepData()
    {
        List<ExcepCustomer> result = new List<ExcepCustomer>()
        {
            new ExcepCustomer("01221562","Nicky",
                new DateTime(2022,12,31),3,"Bermasalah",
                "Lusi",new DateTime(2022,2,22)
                ),
            new ExcepCustomer("12444232","Hansen",
                new DateTime(2022,11,31),3,"Bermasalah",
                "Lusi",new DateTime(2023,1,23)
            )
        };
        return result;
    }

    public List<ExcepCustomerDetail> GetExcepDetail()
    {
        List<ExcepCustomerDetail> result = new List<ExcepCustomerDetail>()
        {
            new ExcepCustomerDetail("01221562","Nicky","023131", new DateTime(2022,12,3,10, 30,0),
                "Pluit",new DateTime(2022,12,31)),
            new ExcepCustomerDetail("01221562","Nicky","023131", new DateTime(2022,12,3,10, 32,0),
                "Thamrin",new DateTime(2022,12,31)),
            new ExcepCustomerDetail("12444232","Hansen","323122", new DateTime(2022,11,22,14, 35,0),
                "Jakarta",new DateTime(2022,11,31)),
            new ExcepCustomerDetail("12444232","Hansen","323122", new DateTime(2022,11,22,14, 38,0),
                "Bandung",new DateTime(2022,11,31)),
        };
        return result;
    }
}