using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication3;

public partial class Registration : Window
{
    public Registration()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Spasibo(object? sender, RoutedEventArgs e)
    {
        new Spasibo().Show();
    }
}