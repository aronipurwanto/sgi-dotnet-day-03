namespace StudyCase.Entity;

public class ExcepCustomerDetail
{
    public String CustomerNumber { get; set; }
    public String CustomerName { get; set; }
    public String CustomerAccount { get; set; }
    public DateTime TransactionDate { get; set; }
    public String BranchName { get; set; }
    public DateTime DataDate { get; set; }

    public ExcepCustomerDetail()
    {
    }

    public ExcepCustomerDetail(string customerNumber, string customerName, 
        string customerAccount, DateTime transactionDate, 
        string branchName, DateTime dataDate)
    {
        CustomerNumber = customerNumber;
        CustomerName = customerName;
        CustomerAccount = customerAccount;
        TransactionDate = transactionDate;
        BranchName = branchName;
        DataDate = dataDate;
    }
}