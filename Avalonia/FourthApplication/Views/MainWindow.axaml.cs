using Avalonia.Controls;

using FourthApplication.Services;
using FourthApplication.ViewModels;

namespace FourthApplication.Views;

public partial class MainWindow : Window
{
    public MainWindow(Database db)
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel(db);
    }
}
