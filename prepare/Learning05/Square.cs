class Square : Shape
{
    double _side = 6;

    public Square(double side, string color)
    {
        _side = side;
        SetColor(color);
    }
    public override double GetArea()
    {
        return _side*_side;
    }
}