using Web.Sql.Entities;
using Web.Views.Shared.Models;

namespace Web.Views.Home.Models;
public sealed record NotificationWidgetViewModel(NotificationEntity[] Notifications) : BasePartialViewModel
{
}