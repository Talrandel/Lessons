using Avalonia.Controls;
using Avalonia.Interactivity;

using System.Threading.Tasks;

namespace SecondApplication;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public async void ButtonOne_OnClick(object sender, RoutedEventArgs args)
    {
        var ownerWindow = this;
        var window = new WindowOne();
        var dialogResult = await window.ShowDialog<bool>(ownerWindow);
        TextBlockDialogResult.Text = dialogResult.ToString();
    }
}