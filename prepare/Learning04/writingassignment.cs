public class WritingAssignment : Assignment
{
    private string _title;

    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetWritingHomework()
    {
        return $"{_title} by {GetName()}";
    }
    
}