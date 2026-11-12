class Rectangle : Shape
{
    double _length = 2;
    double _width = 3;

    public Rectangle(double side, double side2, string color)
    {
        _length = side;
        _width = side2;
        SetColor(color);
    }

    public override double GetArea()
    {
        return _length*_width;
    }
}