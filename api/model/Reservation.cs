using System.Security.Cryptography.X509Certificates;

namespace api.model;

public interface IReservation : BaseEntity
{
    public Guid UserId { get; set; }
    public DateTime DateTime { get; set; }
    public int NumberOfGuests { get; set; }
    public OccasionType Occasion { get; set; }
}

public record Reservation : IReservation
{
    Guid IReservation.UserId { get; set; }
    DateTime IReservation.DateTime { get; set; }
    int IReservation.NumberOfGuests { get; set; }
    OccasionType IReservation.Occasion { get; set; }
    Guid BaseEntity.Id { get; set; }
    string BaseEntity.CreatedBy { get; set; }
    string BaseEntity.ModifiedBy { get; set; }
    DateTime BaseEntity.CreatedDate { get; set; }
    DateTime BaseEntity.ModifiedDate { get; set; }
}

public enum OccasionType
{
    Casual,
    Birthday,
    Anniversary,
    FamilyGathering,
    Business,
    Farewell,
    Graduation,
    RomanticDate,
    Reunion,
    BabyShower,
    EngagementParty
}
