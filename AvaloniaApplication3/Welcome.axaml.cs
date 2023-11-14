using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication3;

public partial class Welcome : Window
{
    public Welcome()
    {
        InitializeComponent();
    }

    private void Button_On_Enter(object? sender, RoutedEventArgs e)
    {
        new Enter().Show();
    }
    
    private void Button_On_Reg(object? sender, RoutedEventArgs e)
    {
        new Registration().Show();
        Close();
    }
}