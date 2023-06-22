namespace Tests
{
    public class ShapeTests
    {
        [Test]
        public void Circle_AreaCalculation_ReturnsCorrectValue()
        {
            double radius = 5;
            Circle circle = new Circle(radius);

            double area = circle.CalculateArea();

            Assert.AreEqual(78.539816339744831, area);
        }

        [Test]
        public void Triangle_AreaCalculation_ReturnsCorrectValue()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            double area = triangle.CalculateArea();

            Assert.AreEqual(6, area);
        }

        [Test]
        public void Triangle_IsRightTriangle_ReturnsTrueForRightTriangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.IsTrue(isRightTriangle);
        }
    }
}