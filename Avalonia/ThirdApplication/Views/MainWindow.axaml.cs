using Avalonia.Controls;

using ThirdApplication.ViewModels;

namespace ThirdApplication;

public partial class MainWindow : Window
{
    public MainWindow(MainViewModel mainViewModel)
    {
        InitializeComponent();
        DataContext = mainViewModel;
    }
}