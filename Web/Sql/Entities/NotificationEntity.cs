using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Sql.Entities;
public sealed record NotificationEntity : IEntity<NotificationEntity>
{
    [Column("Notification_Id")]
    public string NotificationId { get; init; } = $"{Guid.NewGuid()}";

    [Column("Message")]
    public string Message { get; init; } = "";

    [Column("Created_On")]
    public DateTime CreatedOn { get; init; } = DateTime.UtcNow.ToUniversalTime();
}