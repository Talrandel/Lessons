using ReactiveUI;

namespace ThirdApplication.Models;

public sealed class MainModel : ReactiveObject
{
    private int _number;

    public int Number
    {
        get => _number;
        set => this.RaiseAndSetIfChanged(ref _number, value);
    }
}
