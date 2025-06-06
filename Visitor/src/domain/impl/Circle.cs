// Concrete Element: Circle
public class Circle : IShape
{
    public double Radius { get; set; }

    public void Accept(IShapeVisitor visitor)
    {
        visitor.VisitCircle(this);
    }
}