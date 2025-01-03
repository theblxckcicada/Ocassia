namespace api.model;

public interface IDrink : IMeal
{
    public DrinkType Type { get; set; }
}

public record Drink : IDrink
{
    Guid BaseEntity.Id { get; set; }
    string BaseEntity.CreatedBy { get; set; }
    string BaseEntity.ModifiedBy { get; set; }
    DateTime BaseEntity.CreatedDate { get; set; }
    DateTime BaseEntity.ModifiedDate { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DrinkType Type { get; set; }
}

public enum DrinkType
{
    Beverage,
    Refresher
}
