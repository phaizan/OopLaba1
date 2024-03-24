using System;
public class drobi
{
    public int Numerator { get; private set; }
    public int Denominator { get; private set; }
    public bool drob = true;
    public drobi(int a1, int a2)
    {
        if (a2 == 0)
        {
            throw new ArgumentException("Делитель не может быть равен 0", nameof(a2));
        }
        Numerator = a1;
        Denominator = a2;
        sokrashenie();
    }

    public override string ToString()
    {
        if (drob)
            return $"{Numerator}/{Denominator}";
        else
            return $"{Numerator}";
    }



    public static drobi operator +(drobi q1, drobi q2)
    {
        return new drobi(q1.Numerator * q2.Denominator + q1.Denominator * q2.Numerator, q1.Denominator * q2.Denominator).sokrashenie();
    }
    public static drobi operator -(drobi q1, drobi q2)
    {
        return new drobi(q1.Numerator * q2.Denominator - q1.Denominator * q2.Numerator, q1.Denominator * q2.Denominator).sokrashenie();
    }
    public static drobi operator *(drobi q1, drobi q2)
    {
        return new drobi(q1.Numerator * q2.Numerator, q1.Denominator * q2.Denominator).sokrashenie();
    }
    public static drobi operator /(drobi q1, drobi q2)
    {
        if (q2.Numerator == 0)
            throw new ArgumentException("Делитель не может быть равен 0", nameof(q2));
        return new drobi(q1.Numerator * q2.Denominator, q1.Denominator * q2.Numerator).sokrashenie();
    }
    public static bool operator ==(drobi q1, drobi q2)
    {
        q1 = q1.sokrashenie();
        q2 = q2.sokrashenie();
        if (q1.Numerator == q2.Numerator && q1.Denominator == q2.Denominator)
            return true;
        else
            return false;
    }
    public static bool operator !=(drobi q1, drobi q2)
    {
        q1 = q1.sokrashenie();
        q2 = q2.sokrashenie();
        if (q1.Numerator != q2.Denominator || q1.Denominator != q2.Numerator)
            return true;
        else
            return false;
    }
    public static bool operator <(drobi q1, drobi q2)
    {
        q1 = q1.sokrashenie();
        q2 = q2.sokrashenie();
        if (q1.Numerator * q2.Denominator < q1.Denominator * q2.Numerator)
            return true;
        else
            return false;
    }
    public static bool operator >(drobi q1, drobi q2)
    {
        q1 = q1.sokrashenie();
        q2 = q2.sokrashenie();
        if (q1.Numerator * q2.Denominator > q1.Denominator * q2.Numerator)
            return true;
        else
            return false;
    }
    public static bool operator <=(drobi q1, drobi q2)
    {
        q1 = q1.sokrashenie();
        q2 = q2.sokrashenie();
        if (q1.Numerator * q2.Denominator <= q1.Denominator * q2.Numerator)
            return true;
        else
            return false;
    }
    public static bool operator >=(drobi q1, drobi q2)
    {
        q1 = q1.sokrashenie();
        q2 = q2.sokrashenie();
        if (q1.Numerator * q2.Denominator >= q1.Denominator * q2.Numerator)
            return true;
        else
            return false;
    }
    public static drobi operator - (drobi q1)
    {
          return new drobi(-q1.Numerator, q1.Denominator).sokrashenie();
    }
    public drobi sokrashenie()
    {
        int ma, num, denom;
        if ((Numerator > 0 && Denominator < 0) || (Numerator < 0 && Denominator < 0))
        {
            Numerator = -Numerator;
            Denominator = -Denominator;
        }
        if (Numerator < 0)
            num = -Numerator;
        else
            num = Numerator;
        if (Denominator < 0)
            denom = -Denominator;
        else
            denom = Denominator;
        if (num > denom)
            ma = num;
        else
            ma = denom;
        for (int i = ma; i > 0; i--)
        {
            if (Denominator % i == 0 && Numerator % i == 0)
            {
                Denominator /= i;
                Numerator /= i;
                if (Denominator == 1)
                    drob = false;
                else
                    drob = true;
                break;
            }
        }
        return this;
    }
}

