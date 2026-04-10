using Web.Sql.Entities;
using Web.Views.Shared.Models;

namespace Web.Views.Home.Models;
public sealed record IndexViewModel(NotificationEntity[] Notifications) : BaseViewModel
{
    public bool HasNotifications { get; init; } = Notifications.Length > 0;
}