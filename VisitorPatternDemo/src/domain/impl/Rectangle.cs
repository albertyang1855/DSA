// Concrete Element: Rectangle
public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public void Accept(IShapeVisitor visitor)
    {
        visitor.VisitRectangle(this);
    }
}