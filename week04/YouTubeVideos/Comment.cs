using System;

public class Comment
{
    public string _author;
    public string _text;

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{_author}: {_text}");
    }
}