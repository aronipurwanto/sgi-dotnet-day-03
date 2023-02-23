namespace StudyCase.Entity;

public class StatusTindakLanjut
{
    public int Id { get; set; }
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