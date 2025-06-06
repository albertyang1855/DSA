// Visitor Interface
public interface IShapeVisitor
{
    void VisitCircle(Circle circle);
    void VisitRectangle(Rectangle rectangle);
}