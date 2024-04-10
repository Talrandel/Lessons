using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SecondApplication;

public partial class WindowOne : Window
{
    public WindowOne()
    {
        InitializeComponent();
    }

    public void ButtonOk_OnClick(object sender, RoutedEventArgs args)
    {
        Close(true);
    }
    public void ButtonCancel_OnClick(object sender, RoutedEventArgs args)
    {
        Close(false);
    }
}