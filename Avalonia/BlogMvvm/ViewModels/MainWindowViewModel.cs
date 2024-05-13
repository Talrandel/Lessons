using BlogMvvm.Models;
using System.Collections.Generic;
using System;

namespace BlogMvvm.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        BlogEntities =
        [
            new BlogEntity {Article = "Заголовок 1", Text = "text 1", TagsList = ["Tag1, Tag2"], ImagePath="happy.png"},
            new BlogEntity {Article = "Заголовок 2", Text = "text 2", TagsList = ["Tag12, Tag22"], ImagePath="happy.png"},
            new BlogEntity {Article = "Заголовок 3", Text = "text 3", TagsList = ["Tag13, Tag23"], ImagePath="happy.png"}
        ];
        NewsEntities =
        [
            new NewsEntity { Text = "news 1", PublishDate = DateTime.Now},
            new NewsEntity { Text = "news 2", PublishDate = DateTime.Now},
            new NewsEntity { Text = "news 3", PublishDate = DateTime.Now}
        ];
    }
    public List<BlogEntity> BlogEntities { get; set; }

    public List<NewsEntity> NewsEntities { get; set; }

}
