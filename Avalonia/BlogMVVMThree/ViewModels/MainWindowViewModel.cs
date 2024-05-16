using BlogMVVMThree.Models;

using System;
using System.Collections.Generic;

namespace BlogMVVMThree.ViewModels
{
  public class MainWindowViewModel : ViewModelBase
  {
    public List<BlogEntity> BlogEntities { get; set; }

    public List<NewsEntity> NewsEntities { get; set; }

    public MainWindowViewModel()
    {
      BlogEntities = new List<BlogEntity>()
      {
        new BlogEntity() {ImagePath = "happy.png", Article = "art of code", Text = "Lorem Ipsum ", Tags = new List<string> {"tag1", "tag2", "tag3"} } ,
        new BlogEntity() {ImagePath = "happy.png", Article = "article", Text = "Dor ati amet", Tags = new List<string> {"tag4", "tag5", "tag6"} }
      };

      NewsEntities = new List<NewsEntity>()
      {
        new NewsEntity() {Text = "News 1: CAT" , PublishDate = DateTime.Now},

        new NewsEntity() {Text = "News 2: DOG" , PublishDate = DateTime.Now.AddDays(-3)}
      };
    }
  }
}