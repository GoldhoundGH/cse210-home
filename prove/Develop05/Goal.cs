using System.ComponentModel.DataAnnotations.Schema;

public abstract class Goal
{
    private string _name;
    private int _value;
    private int _complete;

    public Goal(string name, int value)
    {
        SetName(name);
        SetValue(value);
        Uncomplete();
    }

    public void SetName (string name)
    {
        _name = name;
    }
    public void SetValue (int value)
    {
        _value = value;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetValue()
    {
        return _value;
    }

    public int CheckComplete()
    {
        return _complete;
    }

    public void SetCompleteStatus(int number)
    {
        _complete = number;
    }

    public void Complete()
    {
        _complete = 1;
    }

    public void Uncomplete()
    {
        _complete = 0;
    }
    
    public virtual string DisplayGoal()
    {
        string label = "Incomplete";
        if (_complete == 1)
        {
            label = "Complete";
        }
        else if (_complete == 2)
        {
            label = "Ongoing";
        }
        return $"{_name}:\t \t{_value} points\t-\t{label}";
    }

    public abstract int MarkComplete();
}