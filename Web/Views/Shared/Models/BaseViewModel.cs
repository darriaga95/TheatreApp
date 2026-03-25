namespace Web.Views.Shared.Models;

public record BaseViewModel
{
    public string Success { get; set; } = "";
    public string Error { get; set; } = "";
    public string Message { get; set; } = "";
    public string Warning { get; set; } = "";
}
