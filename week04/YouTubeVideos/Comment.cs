public class Comment
{
    private string _author;
    private string _comment;

    public Comment(string Commentauthor, string CommentText)
    {
        _author = Commentauthor;
        _comment = CommentText;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetComment()
    {
        return _comment;
    }
}