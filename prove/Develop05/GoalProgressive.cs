public class GoalProgressive : Goal
{
    private int _requiredCompletions;
    private int _progressValue;
    private int _completions;

    public GoalProgressive(string name, int value, int requiredCompletions, int progressValue) : base (name, value)
    {
        _requiredCompletions = requiredCompletions;
        _progressValue = progressValue;
        _completions = 0;
    }
    public override string DisplayGoal()
    {
        return $"{GetName()}:\t \t{_progressValue}/{GetValue()} points\t-\tProgress: {_completions}/{_requiredCompletions}";   
    }
    public override int MarkComplete()
    {
        _completions += 1;

        if (_completions == _requiredCompletions)
        {
            Complete();
            return GetValue();
        }
        else
        {
            return _progressValue;
        }
    }
}