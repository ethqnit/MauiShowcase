namespace MauiShowcase;

public record Feature(string Icon, string Title, string Description);

public partial class MainPage : ContentPage
{
    private int _count;

    public List<Feature> Features { get; } = new()
    {
        new("Fast",      "Blazing Fast",            "Native performance on every platform"),
        new("Code",      "Single Codebase",         "One project → iOS, Android, Windows, Mac"),
        new("Reload",    "Hot Reload",              "See changes instantly while coding"),
        new("Theme",     "Dark Mode Ready",         "Beautiful light & dark themes out of the box"),
        new("Devices",   "All Platforms",           "iOS • Android • Windows • macOS • TV")
    };

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        _count++;

        CounterLabel.Text = _count == 1
            ? "Clicked 1 time!"
            : $"Clicked {_count} times!";

        SemanticScreenReader.Announce(CounterLabel.Text);
    }
}