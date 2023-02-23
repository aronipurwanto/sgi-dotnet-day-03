using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyCase.Entity;

[Table("tbl_excep_cust01_detail")]
public class ExcepCust01Detail
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("cust_no")]
    public String CustomerNumber { get; set; }
    [Column("cust_name")]
    public String CustomerName { get; set; }
    [Column("cust_rek")]
    public String CustomerAccount { get; set; }
    
    [Column("trx_date")]
    public DateTime TransactionDate { get; set; }
    [Column("trx_branch")]
    public String BranchName { get; set; }
    [Column("data_date")]
    public DateTime DataDate { get; set; }

    public ExcepCust01Detail()
    {
    }

    public ExcepCust01Detail(string customerNumber, string customerName, 
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