namespace BlogMvvm.ViewModels;
using BlogMvvm.Models;
using System.Collections.Generic;
using System;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        BlogEntities = new List<BlogEntity>
        {
            new BlogEntity {Article = "Заголовок 1", Text = "text 1", TagsList = new string[] {"Tag1, Tag2"}, ImagePath="happy.png"},
            new BlogEntity {Article = "Заголовок 2", Text = "text 2", TagsList = new string[] {"Tag12, Tag22"}, ImagePath="happy.png"},
            new BlogEntity {Article = "Заголовок 3", Text = "text 3", TagsList = new string[] {"Tag13, Tag23"}, ImagePath="happy.png"}
        };
        NewsEntities = new List<NewsEntity>
        {
            new NewsEntity { Text = "news 1", PublishDate = DateTime.Now},
            new NewsEntity { Text = "news 2", PublishDate = DateTime.Now},
            new NewsEntity { Text = "news 3", PublishDate = DateTime.Now}
        };
    }
    public List<BlogEntity> BlogEntities { get; set; }

    public List<NewsEntity> NewsEntities { get; set; }

}
