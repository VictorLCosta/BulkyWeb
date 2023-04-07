namespace src.Models.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = String.Empty;
    public int DisplayOrder { get; set; }
}
