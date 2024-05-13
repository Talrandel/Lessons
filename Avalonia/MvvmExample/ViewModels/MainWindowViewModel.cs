using System.Collections.Generic;

namespace MvvmExample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        Books =
        [
            new("Гарри Поттер", "Джоан Роулинг"),
            new("Мёртвые души", "Николай Гоголь"),
            new("Евгений Онегин", "Александр Пушкин"),
            new("Толковый словарь Даля", "В. И. Даль"),
            new("Вредные советы", "Григорий Остер"),
            new("Чистый код", "Роберт Мартин"),
        ];
    }

    public List<Book> Books { get; set; }
}
