using System.ComponentModel.DataAnnotations.Schema;
using Web.Sql.Models;

namespace Web.Sql.Entities;

public sealed record UserEntity : IProperty<UserEntity>
{
    [Column("User_Id")]
    public string UserId { get; init; } = $"{Guid.NewGuid()}";

    [Column("User_Id")]
    public Address Address { get; init; } = new();
}

