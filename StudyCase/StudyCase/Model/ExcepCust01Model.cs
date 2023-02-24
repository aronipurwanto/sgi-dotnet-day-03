using StudyCase.Entity;

namespace StudyCase.Model;
public class ExcepCust01Model
{
    public int Id { get; set; }
    public String CustomerNumber { get; set; }
    public String CustomerName { get; set; }
    public string CustomerDate { get; set; }
    public string TindakLanjutId { get; set; }
    public String Notes { get; set; }
    public String LastUpdatedBy { get; set; }
    public String LastUpdatedAt { get; set; }

    public ExcepCust01Model()
    {
    }

    public ExcepCust01Model(ExcepCust01 entity)
    {
        Id = entity.Id;
        CustomerNumber = entity.CustomerNumber;
        CustomerName = entity.CustomerName;
        CustomerDate = entity.CustomerDate.ToString("yyyy-MM-dd");
        TindakLanjutId = entity.TindakLanjut.Description;
        Notes = entity.Notes;
        LastUpdatedBy = entity.LastUpdatedBy;
        LastUpdatedAt = entity.LastUpdatedAt.ToString("yyyy-MM-dd");
    }
}