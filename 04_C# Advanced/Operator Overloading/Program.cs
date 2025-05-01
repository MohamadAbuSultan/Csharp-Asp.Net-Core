// var p1 = new Point(100, 200);
// var p2 = new Point(300, 400);
// var p3 = p1 + p2;
// Console.WriteLine($"X: {p3.X}, Y: {p3.Y}");

// var p4 = p2 - p1;
// Console.WriteLine($"X: {p4.X}, Y: {p4.Y}");

Point p5 = 5;
System.Console.WriteLine(p5.X + " " + p5.Y);

int x = p5;
System.Console.WriteLine(x);

public class Point
{
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public int X { get; set; }
    public int Y { get; set; }
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }

    public static Point operator *(Point p1, Point p2)
    {
        return new Point(p1.X * p2.X, p1.Y * p2.Y);
    }

    public static Point operator /(Point p1, Point p2)
    {
        return new Point(p1.X / p2.X, p1.Y / p2.Y);
    }

    public static Point operator ++(Point p1)
    {
        return new Point(p1.X + 1, p1.Y + 1);
    }

    public static Point operator --(Point p1)
    {
        return new Point(p1.X - 1, p1.Y - 1);
    }

    public static bool operator ==(Point p1, Point p2)
    {
        return p1.X == p2.X && p1.Y == p2.Y;
    }

    public static bool operator !=(Point p1, Point p2)
    {
        return !(p1 == p2);
    }

    public static bool operator >(Point p1, Point p2)
    {
        return p1.X > p2.X && p1.Y > p2.Y;
    }

    public static bool operator <(Point p1, Point p2)
    {
        return p1.X < p2.X && p1.Y < p2.Y;
    }

    public static bool operator >=(Point p1, Point p2)
    {
        return p1.X >= p2.X && p1.Y >= p2.Y;
    }

    public static bool operator <=(Point p1, Point p2)
    {
        return p1.X <= p2.X && p1.Y <= p2.Y;
    }

    public static implicit operator Point(int x)
    {
        return new Point(x, x);
    }
    // public static explicit operator Point(int x)
    // {
    //     return new Point(x, x);
    // }

    public static implicit operator int(Point p)
    {
        return p.X;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        if (ReferenceEquals(obj, null))
        {
            return false;
        }

        throw new NotImplementedException();
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}