namespace Web.Views.Shared.Models;
public record ViewMessage(string Message, ViewMessageType Type);
public enum ViewMessageType
{
    Success,
    Error,
    Message,
    Warning
}