using Data_Ordering;

public class CarComparer : IComparer<Car>
{
    public int Compare(Car? x, Car? y)
    {
        var result = 0;

        if (x is not null && y is not null)
        {
            if (x.MaxSpeed > y.MaxSpeed)
                result = 1;

            if (x.MaxSpeed < y.MaxSpeed)
                result = -1;
        }

        return result;
    }
}