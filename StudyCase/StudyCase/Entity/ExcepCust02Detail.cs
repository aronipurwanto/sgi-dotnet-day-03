using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyCase.Entity;

[Table("tbl_excep_cust02_detail")]
public class ExcepCust02Detail
{
    [Key] 
    [Column("id")]
    public int Id { get; set; }

    [Column("branch")]
    public String Branch { get; set; }

    [Column("branch_name")]
    public String BranchName { get; set; }

    [Column("acc_no")]
    public String AccNo { get; set; }

    [Column("acc_name")]
    public String AccName { get; set; }

    [Column("fasilitas")]
    public String Fasilitas { get; set; }

    [Column("plafond")]
    public Double Plafond { get; set; }

    [Column("plafond_real")]
    public Double PlafondReal { get; set; }

    [Column("data_date")]
    public DateTime DataDate { get; set; }
}