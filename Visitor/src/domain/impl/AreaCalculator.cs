// Concrete Visitor: Area Calculator
public class AreaCalculator : IShapeVisitor
{
    public void VisitCircle(Circle circle)
    {
        double area = Math.PI * circle.Radius * circle.Radius;
        Console.WriteLine($"[Circle] Area = {area:F2}");
    }

    public void VisitRectangle(Rectangle rectangle)
    {
        double area = rectangle.Width * rectangle.Height;
        Console.WriteLine($"[Rectangle] Area = {area:F2}");
    }
}