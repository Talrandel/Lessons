using ReactiveUI;

using System;
using System.Windows.Input;

using ThirdApplication.Models;

namespace ThirdApplication.ViewModels
{
    public sealed class MainViewModel : ReactiveObject
    {
        private Random _rand = new();
        public MainViewModel()
        {
            var okEnabled = this.WhenAnyValue(
                x => x.Text,
                x => !string.IsNullOrWhiteSpace(x));

            OkCommand = ReactiveCommand.Create(
                () => Number = "42");
        }
        private string _text;

        public string Text
        {
            get => _text;
            set => this.RaiseAndSetIfChanged(ref _text, value);
        }

        private string _number;

        public string Number
        {
            get => _number;
            set => this.RaiseAndSetIfChanged(ref _number, value);
        }

        private void ButtonClick()
        {
            
        }

        public ICommand OkCommand { get; }
    }
}
