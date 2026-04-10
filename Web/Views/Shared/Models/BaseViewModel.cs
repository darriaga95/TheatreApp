namespace Web.Views.Shared.Models;
public record BaseViewModel
{
    public ViewMessage? ViewMessage { get; set; }
}
public record BasePartialViewModel(ViewMessage? ViewMessage = null);