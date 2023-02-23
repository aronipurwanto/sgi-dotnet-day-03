using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyCase.Entity;

[Table("tbl_status_tindak_lanjut")]
public class StatusTindakLanjut
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("description")]
    public String Description { get; set; }

    public StatusTindakLanjut()
    {
    }

    public StatusTindakLanjut(int id, string description)
    {
        Id = id;
        Description = description;
    }
}