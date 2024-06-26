﻿using System;
using System.Reactive;
using System.Reactive.Linq;

using Avalonia;

using FourthApplication.Models;
using FourthApplication.Services;

using ReactiveUI;

namespace FourthApplication.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase content;

    public MainWindowViewModel(Database db)
    {
        Content = List = new TodoListViewModel(db.GetItems());

        AddItemCommand = ReactiveCommand.Create(AddItem);
    }

    public ViewModelBase Content
    {
        get => content;
        private set => this.RaiseAndSetIfChanged(ref content, value);
    }
    public TodoListViewModel List { get; }
    public ReactiveCommand<Unit, Unit> AddItemCommand { get; }

    private void AddItem()
    {
        var vm = new AddItemViewModel();

        Observable.Merge(
            vm.Ok,
            vm.Cancel.Select(_ => (TodoItem)null))
            .Take(1)
            .Subscribe(model =>
            {
                if (model != null)
                {
                    List.Items.Add(model);
                }

                Content = List;
            });

        Content = vm;
    }
}
