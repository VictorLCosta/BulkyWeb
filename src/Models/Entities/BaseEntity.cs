namespace BulkyWeb.Models.Entities;

public class BaseEntity
{
    public Guid Id { get; set; }

    protected BaseEntity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
    }

    private DateTime? _createdAt;

    public DateTime? CreatedAt
    {
        get => _createdAt;
        set => _createdAt = value ?? DateTime.UtcNow;
    }

    public DateTime? UpdatedAt { get; set; }
}
