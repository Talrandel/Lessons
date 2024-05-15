using System;
using System.Collections.Generic;
using BlogMvvmTwo.Models;

namespace BlogMvvmTwo.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        BlogsEntities = new List<BlogsEntity>()
        {
            new BlogsEntity() 
            {
                Article = "SHVAlex is Crazy", 
                Text = "Fedir fedisfsdfshklf pon", 
                Tags = new List<string> {"Tag1", "Tag2", "Tag3"},
                ImagePath = "happy.png"
            },
            new BlogsEntity() 
            {Article = "Майские указы", Text = "Назначен новый министр обороны!"},
            new BlogsEntity() 
            {Article = "Это конец?", Text = "С группой 9.5 занятий больше не будет"},
        };
        NewsEntities = new List<NewsEntity>
        {
            new() { Text = "Новость 1", PublishTime = DateTime.Now },
            new() { Text = "Новость 2", PublishTime = DateTime.Now.AddDays(-1) }
        };
    }

    public List<BlogsEntity> BlogsEntities {get; set;}
    public List<NewsEntity> NewsEntities {get; set;}

    
}
