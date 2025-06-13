using System;
using System.Collections.Generic;
using System.Globalization;

abstract class Activity
{
    private DateTime _date;
    private double _length;

    public Activity(DateTime date, double length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
    }

    public double GetLength()
    {
        return _length;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} {GetType().Name} ({GetLength()} min) - Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}