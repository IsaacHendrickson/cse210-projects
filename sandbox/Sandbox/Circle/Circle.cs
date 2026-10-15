using System.Diagnostics.Contracts;

class Circle
{
    private double _radius;

    public Circle()
    {
        SetRadius(_radius);
    }

    public Circle(double radius)
    {
        SetRadius(radius);
    }

    public void SetRadius(double radius)
    {
        if (radius < 0.0)
        {
            Console.WriteLine("No");
            _radius = 1.0;
            
        }else
        {
            _radius = radius;
        }
    }

    public double CalculateCircle()
    {
        return _radius*_radius*3.14;
    }

    public double GetRadius()
    {
        return _radius;
    }


}