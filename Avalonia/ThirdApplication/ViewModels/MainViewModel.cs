using ReactiveUI;

using System;
using System.Windows.Input;

using ThirdApplication.Models;

namespace ThirdApplication.ViewModels;

public sealed class MainViewModel : ReactiveObject
{
    private Random _rand = new();
    public MainViewModel()
    {
        MainModel = new MainModel();

        GenerateNumberCommand = ReactiveCommand.Create(ButtonClick);
    }
    private string _text;

    public string Text
    {
        get => _text;
        set => this.RaiseAndSetIfChanged(ref _text, value);
    }

    public MainModel MainModel { get; set; }
    private void ButtonClick()
    {
        MainModel.Number = _rand.Next();
    }

    public ICommand GenerateNumberCommand { get; }
}
