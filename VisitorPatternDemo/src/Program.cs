class Program
{
    static void Main(string[] args)
    {
        List<IShape> shapes = new List<IShape>
        {
            new Circle { Radius = 3 },
            new Rectangle { Width = 4, Height = 5 }
        };

        IShapeVisitor visitor = new AreaCalculator();

        foreach (var shape in shapes)
        {
            shape.Accept(visitor);
        }
    }
}
