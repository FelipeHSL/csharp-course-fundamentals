using System.Net.Mime;

namespace S8exercise2.Entities;

public class Comment
{
    public string Text { get; set; }
    
    public Comment(){

    }

    public Comment(string text)
    {
        Text = text;
    }
}

