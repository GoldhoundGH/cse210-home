using System.Runtime.InteropServices.Java;

public class GoalSimple : Goal
{
    public GoalSimple(string name, int value) : base (name, value) {}
    
    public override int MarkComplete()
    {
        Complete();
        return GetValue();
    }
}