public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public string GetHomework()
    {
        return $"Section {_textbookSection}: Problems {_problems}";
    }

    public void SetSection(string section)
    {
        _textbookSection = section;
    }
    public void SetProblems(string problem)
    {
        _problems = problem;
    }
}