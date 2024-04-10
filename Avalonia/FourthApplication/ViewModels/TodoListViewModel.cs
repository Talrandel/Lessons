using FourthApplication.Models;

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FourthApplication.ViewModels;

public class TodoListViewModel : ViewModelBase
{
    public TodoListViewModel(IEnumerable<TodoItem> items)
    {
        Items = new ObservableCollection<TodoItem>(items);
    }

    public ObservableCollection<TodoItem> Items { get; }
}
