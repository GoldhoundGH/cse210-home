public class Assignment
{
    private string _studentName;
    private string _topic;

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public void SetName(string name)
    {
        _studentName = name;
    }
    public string GetName()
    {
        return _studentName;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
}