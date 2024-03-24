using System;
using System.Globalization;
using System.Text;

public abstract class Time
{
    public CultureInfo myCIintl;

    public virtual string ShowTime()
    {
        return DateTime.Now.ToString(myCIintl);
    }

    public Time(CultureInfo myCIintl)
    {
        this.myCIintl = myCIintl;
    }
}

public class TimeEU : Time
{
    public TimeEU() : base(new CultureInfo("es-ES", false)) { }
}

public class TimeUS : Time
{
    public TimeUS() : base(new CultureInfo("en-US", false)) { }
}

public class Decorator : Time
{
    protected Time _time;
    protected int CharValue = 0;
    protected char _char;

    public Decorator(Time time, int ChVal, char ch) : base(time.myCIintl)
    {
        _time = time;
        CharValue = ChVal;
        _char = ch;
    }
}

public class TimeEUDecorator : Decorator
{
    public TimeEUDecorator(TimeEU timeEU, int ChVal, char ch) : base(timeEU, ChVal, ch) { }

    public override string ShowTime()
    {
        StringBuilder sb = new StringBuilder(base.ShowTime());
        sb.Append(' ');
        for (int i = 0; i < CharValue; i++)
            sb.Append(_char);
        return sb.ToString();
    }
}

public class TimeUSDecorator : Decorator
{
    public TimeUSDecorator(TimeUS timeUS, int ChVal, char ch) : base(timeUS, ChVal, ch) { }

    public override string ShowTime()
    {
        StringBuilder sb = new StringBuilder(base.ShowTime());
        sb.Append(' ');
        for (int i = 0; i < CharValue; i++)
            sb.Append(_char);
        return sb.ToString();
    }
}
