using StudyCase.Entity;
using StudyCase.Model;

namespace StudyCase.Service;

public class CustomerService
{
    //public ExcepCustomer UpdateData(String custNo, String date, int status)
    public ExcepCust01 UpdateData(ExcepCustomerUpdate Data)
    {
        DateTime customerDate = Convert.ToDateTime(Data.CustomerDate);
        // query data
        var data = this.GetExcepData()
            .Where(x => x.CustomerNumber.Equals(Data.CustomerNumber) && x.CustomerDate.Equals(customerDate))
            .SingleOrDefault();
        data.TindakLanjutId = Data.Status;
        // context 
        // context.saveChanges();
        
        // var data2 = query data2
        return data;
    }
    public List<ExcepCust01> GetExcepDataJoin()
    {
        var query = (from cus in this.GetExcepData()
            join status in this.GetStatusTindakLanjut() on cus.TindakLanjutId equals status.Id
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
    
    public List<ExcepCust01> GetExcepData()
    {
        List<ExcepCust01> result = new List<ExcepCust01>()
        {
            new ExcepCust01("01221562","Nicky",
                new DateTime(2022,12,31),3,"Bermasalah",
                "Lusi",new DateTime(2022,2,22)
                ),
            new ExcepCust01("12444232","Hansen",
                new DateTime(2022,11,31),3,"Bermasalah",
                "Lusi",new DateTime(2023,1,23)
            )
        };
        return result;
    }

    
    public List<ExcepCust01Detail> GetExcepDetail()
    {
        List<ExcepCust01Detail> result = new List<ExcepCust01Detail>()
        {
            new ExcepCust01Detail("01221562","Nicky","023131", new DateTime(2022,12,3,10, 30,0),
                "Pluit",new DateTime(2022,12,31)),
            new ExcepCust01Detail("01221562","Nicky","023131", new DateTime(2022,12,3,10, 32,0),
                "Thamrin",new DateTime(2022,12,31)),
            new ExcepCust01Detail("12444232","Hansen","323122", new DateTime(2022,11,22,14, 35,0),
                "Jakarta",new DateTime(2022,11,31)),
            new ExcepCust01Detail("12444232","Hansen","323122", new DateTime(2022,11,22,14, 38,0),
                "Bandung",new DateTime(2022,11,31)),
        };
        return result;
    }
}