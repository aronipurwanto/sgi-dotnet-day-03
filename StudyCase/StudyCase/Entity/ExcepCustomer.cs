namespace StudyCase.Entity;

public class ExcepCustomer
{
    public String CustomerNumber { get; set; }
    public String CustomerName { get; set; }
    public DateTime CustomerDate { get; set; }
    public int Status { get; set; }
    
    public StatusTindakLanjut TindakLanjut { get; set; }
    public String Notes { get; set; }
    public String LastUpdatedBy { get; set; }
    public DateTime LastUpdatedAt { get; set; }

    public ExcepCustomer()
    {
    }

    public ExcepCustomer(string customerNumber, string customerName, DateTime customerDate, int status, string notes, string lastUpdatedBy, DateTime lastUpdatedAt)
    {
        CustomerNumber = customerNumber;
        CustomerName = customerName;
        CustomerDate = customerDate;
        Status = status;
        Notes = notes;
        LastUpdatedBy = lastUpdatedBy;
        LastUpdatedAt = lastUpdatedAt;
    }
}