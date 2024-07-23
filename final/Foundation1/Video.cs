using System;

public class Video
{
    public string _title;
    public string _author;
    public int _lenght;
    public List<Comment> _comments;
    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
        _comments = new List<Comment>();
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }
}