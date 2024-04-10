using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SecondApplication;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ButtonOne_OnClick(object sender, RoutedEventArgs args)
    {
        var ownerWindow = this;
        var window = new WindowOne();
        var dialogResult = window.ShowDialog<bool>(ownerWindow).GetAwaiter().GetResult;
        TextBlockDialogResult.Text = dialogResult.ToString();
    }
}