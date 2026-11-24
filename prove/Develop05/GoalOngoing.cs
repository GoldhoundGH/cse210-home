public class GoalOngoing : Goal
{
    public GoalOngoing(string name, int value) : base (name, value)
    {
        SetCompleteStatus(2);
    }

    public override int MarkComplete()
    {
        return GetValue();
    }
}