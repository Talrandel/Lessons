using System.Collections.Generic;

namespace MvvmExample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        Books = new List<Book>()
        {
            new("Гарри Поттер", "Джоан Роулинг"),
            new("Мёртвые души", "Николай Гоголь"),
            new("Евгений Онегин", "Александр Пушкин"),
        };
    }

    public List<Book> Books { get; set; }
}
