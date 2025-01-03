namespace api.model;

public record Meal : IMeal
{
    Guid BaseEntity.Id { get; set; }
    string BaseEntity.CreatedBy { get; set; }
    string BaseEntity.ModifiedBy { get; set; }
    DateTime BaseEntity.CreatedDate { get; set; }
    DateTime BaseEntity.ModifiedDate { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
