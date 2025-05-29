using System;
using System.Collections.Generic;

public class Video
{
    public List<Comment> _comments = new List<Comment>();
    public string _title = "";
    public string _author = "";
    public int _length = 0;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void GetVIdeoInformation()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of Comments: {_comments.Count}");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }

        Console.WriteLine("----------------------------------------------");
    }
}