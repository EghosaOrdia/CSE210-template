public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string videoTitle, string videoAuthor, int videoLength)
    {
        _title = videoTitle;
        _author = videoAuthor;
        _length = videoLength;
        _comments = new List<Comment>();
    }

    public void AddComment(string commentAuthor, string commentText)
    {
        Comment entry = new Comment(commentAuthor, commentText);
        _comments.Add(entry);
    }

    public void DisplayComments()
    {
        foreach (Comment c in _comments)
        {
            Console.WriteLine($"{c.GetAuthor()}: {c.GetComment()}");
        }
    }
    public string GetAuthor()
    {
        return _author;
    }
    public string GetTitle()
    {
        return _title;
    }
    public int GetLength()
    {
        return _length;
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }


}