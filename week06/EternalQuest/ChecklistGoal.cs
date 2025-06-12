using System;
using System.Collections.Generic;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        if (!isComplete())
        {
            _amountCompleted++;
        }
    }

    public override bool isComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string check = isComplete() ? "[X]" : "[ ]";
        return $" {check} {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }
}