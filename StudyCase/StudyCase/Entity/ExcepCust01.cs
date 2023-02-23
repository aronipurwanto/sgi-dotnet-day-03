using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyCase.Entity;

[Table(("tbl_excep_cus01"))]
public class ExcepCust01
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("cust_no")]
    public String CustomerNumber { get; set; }
    [Column("cust_name")]
    public String CustomerName { get; set; }
    [Column("cust_date")]
    public DateTime CustomerDate { get; set; }
    
    [Column("status_tindak_lanjut")]
    public int TindakLanjutId { get; set; }
    public StatusTindakLanjut TindakLanjut { get; set; }
    
    [Column("notes")]
    public String Notes { get; set; }
    [Column("last_updated_by")]
    public String LastUpdatedBy { get; set; }
    [Column("last_updated_at")]
    public DateTime LastUpdatedAt { get; set; }

    public ExcepCust01()
    {
    }

    public ExcepCust01(string customerNumber, string customerName, DateTime customerDate, int status, string notes, string lastUpdatedBy, DateTime lastUpdatedAt)
    {
        CustomerNumber = customerNumber;
        CustomerName = customerName;
        CustomerDate = customerDate;
        TindakLanjutId = status;
        Notes = notes;
        LastUpdatedBy = lastUpdatedBy;
        LastUpdatedAt = lastUpdatedAt;
    }
}