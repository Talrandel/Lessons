using Avalonia.Controls;
using Avalonia.Interactivity;

namespace FirstApplication;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ButtonOne_OnClick(object sender, RoutedEventArgs args)
    {
        TextBoxOne.Text = "Default text!";
    }
}