namespace api.model;

using System;
using api.model;

public interface IEmployee : BaseEntity
{
    public string Address { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public decimal Commission { get; set; }
}

public record Employee : IEmployee
{
    public string Address { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public decimal Commission { get; set; }
    public Guid Id { get; set; }
    public string CreatedBy { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}
