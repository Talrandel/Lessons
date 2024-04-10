using ReactiveUI;

namespace FourthApplication.Models;

public class TodoItem : ReactiveObject
{
    public string Description { get; set; }
    public bool IsChecked { get; set; }
}