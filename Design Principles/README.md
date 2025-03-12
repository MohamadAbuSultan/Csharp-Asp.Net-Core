

---

# RICH DOMAIN MODEL

RICH DOMAIN MODEL  
OUR DOMAIN LOGIC IS PART OF OUR DOMAIN ENTITIES  

```csharp
public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Make { get; set; }

    public void Drive()
    {
        // Logic for driving the car
    }

    public void Stop()
    {
        // Logic for stopping the car
    }

    public void Turn(string direction)
    {
        // Logic for turning the car
    }

    public void Accelerate(int speed)
    {
        // Logic for accelerating the car
    }
}
```

---

# ANEMIC DOMAIN MODEL

ANEMIC DOMAIN MODEL  
IT IS A MODEL, WHICH SEPARATES DATA AND OPERATION  

```csharp
public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Make { get; set; }
}

public class CarManager
{
    public void Drive(Car car)
    {
        // Logic for driving the car
    }

    public void Stop(Car car)
    {
        // Logic for stopping the car
    }

    public void Turn(Car car, string direction)
    {
        // Logic for turning the car
    }

    public void Accelerate(Car car, int speed)
    {
        // Logic for accelerating the car
    }
}
```

---