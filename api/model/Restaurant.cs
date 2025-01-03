namespace api.model;

using api.model;

public interface IRestaurant
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public string Website { get; set; }
    public string CreatedBy { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}

public record Restaurant : IRestaurant
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    public string Website { get; set; }
    public string CreatedBy { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}
