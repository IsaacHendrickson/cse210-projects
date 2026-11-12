class Circle : Shape
{
    double _radius = 5;


    public Circle(double radius, string color)
    {
        _radius = radius;
        SetColor(color);
    }
    public override double GetArea()
    {
        return _radius*_radius*3.14159;
    }
}