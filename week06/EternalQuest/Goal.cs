using System;
using System.Collections.Generic;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();
    public abstract bool isComplete();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
    {
        return $" [ ] {_name} ({_description})";
    }

  
}