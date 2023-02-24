using StudyCase.Entity;

namespace StudyCase.Model;

public class ExcepCustCommon
{
    public string DataType { get; set; }
    public string AccNo { get; set; }
    public string AccName { get; set; }
    public string Branch { get; set; }
    public string BrancName { get; set; }
    public StatusTindakLanjut TindakLanjut { get; set; }
    public String Notes { get; set; }
    public String LastUpdatedBy { get; set; }
    public DateTime LastUpdatedAt { get; set; }
}