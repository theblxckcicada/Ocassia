namespace api.model;

public interface ITableEntity : BaseEntity
{
    public int NumberOfSeats { get; set; }
    public string Description { get; set; }
}

public record TableEntity : ITableEntity
{
    public int NumberOfSeats { get; set; }
    public Guid Id { get; set; }
    public string CreatedBy { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string Description { get; set; }
}
