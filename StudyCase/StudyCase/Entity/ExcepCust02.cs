using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyCase.Entity;

[Table(("tbl_excep_cust02"))]
public class ExcepCust02
{
    [Key]
    public int Id { get; set; }
    
    [Column("branch")]
    public String Branch { get; set; }

    [Column("acc_no")]
    public String AccNo { get; set; }

    [Column("anomaly_amount")]
    public int AnomalyAmount { get; set; }

    [Column("data_date")]
    public DateTime DataDate { get; set; }

    [Column("status_tindak_lanjut")]
    public int StatusTindakLanjut { get; set; }

    public StatusTindakLanjut TindakLanjut { get; set; }

    [Column("notes")]
    public String Notes { get; set; }

    [Column("last_updated_by")]
    public String LastUpdatedBy { get; set; }
    [Column("last_updated_at")]
    public DateTime LastUpdatedAt { get; set; }
}