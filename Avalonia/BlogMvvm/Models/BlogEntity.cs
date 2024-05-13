namespace BlogMvvm.Models;
using Avalonia.Media;
using Avalonia.Media.Imaging;

public class BlogEntity {
    public string Article { get; set; }
    public string Text { get; set; }
    public string[] TagsList { get; set; }
    public string ImagePath { get; set; }
}