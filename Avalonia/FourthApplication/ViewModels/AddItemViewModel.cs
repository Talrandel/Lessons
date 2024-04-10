using System.Reactive;

using FourthApplication.Models;

using ReactiveUI;

namespace FourthApplication.ViewModels;

public class AddItemViewModel : ViewModelBase
{
    private string _description;

    public AddItemViewModel()
    {
        var okEnabled = this.WhenAnyValue(
            x => x.Description,
            x => !string.IsNullOrWhiteSpace(x));

        Ok = ReactiveCommand.Create(
            () => new TodoItem { Description = Description }, 
            okEnabled);
        Cancel = ReactiveCommand.Create(() => { });
    }

    public string Description
    {
        get => _description;
        set => this.RaiseAndSetIfChanged(ref _description, value);
    }

    public ReactiveCommand<Unit, TodoItem> Ok { get; }
    public ReactiveCommand<Unit, Unit> Cancel { get; }
}