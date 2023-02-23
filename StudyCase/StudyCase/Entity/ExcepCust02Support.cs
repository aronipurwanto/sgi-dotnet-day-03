using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyCase.Entity;

[Table("tbl_excep_cust_02_support")]
public class ExcepCust02Support
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("acc_no")]
    public String AccNo { get; set; }

    [Column("acc_name")]
    public String AccName { get; set; }

    [Column("Fasilitas")]
    public String Fasilitas { get; set; }

    [Column("plafond")]
    public Double Plafond { get; set; }

    [Column("saldo")]
    public Double Saldo { get; set; }

    [Column("periode")]
    public DateTime Periode { get; set; }
}