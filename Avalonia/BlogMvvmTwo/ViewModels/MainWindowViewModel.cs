﻿using System;
using System.Collections.Generic;
using BlogMvvmTwo.Models;

namespace BlogMvvmTwo.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        MainMenuEntity = new() 
        { 
            Home = "Home", 
            About = "About", 
            MainTopicsList = new List<string> {"Main topic 1","Main topic 2", "Main topic 3"},
            Profile = "RSS"
        };
        
        BlogsEntities = new List<BlogsEntity>()
        {
            new BlogsEntity() 
            {
                Article = "Lorem Ipsum", 
                Text = "Fedir fedisfsdfshklf pon", 
                ImagePath = "happy.png",
                Tags = new List<string> {"Tag1", "Tag2", "Tag3"}
            },
            new BlogsEntity() 
            {Article = "Майские указы", Text = "Назначен новый министр обороны!"},
            new BlogsEntity() 
            {Article = "Это конец?", Text = "С группой 9.4 занятий больше не будет"},
        };
        NewsEntities = new List<NewsEntity>
        {
            new() { Text = "Новость 1", PublishTime = DateTime.Now },
            new() { Text = "Новость 2", PublishTime = DateTime.Now.AddDays(-1) }
        };
    }

    public MainEntity MainMenuEntity {get; set;}
    public List<BlogsEntity> BlogsEntities {get; set;}
    public List<NewsEntity> NewsEntities {get; set;}

    
}
