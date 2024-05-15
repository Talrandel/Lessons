namespace BlogMvvmTwo.Models;
using System.Collections.Generic;

public class BlogsEntity
{
    public string Article {get; set; }
    public string Text  {get; set; }
    public string ImagePath {get; set; } //null
    public List<string> Tags {get; set; } //null

}