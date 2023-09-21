using AreaCalculator.Figures;

namespace AreaCalculator.Tests.FiguresTests
{
    public class TriangleTests
    {
        [Fact]
        public void CorrectArea()
        {
            Triangle triangle = new Triangle(13, 84, 85);

            double area = triangle.Area;

            Assert.Equal(546, area);
        }

        [Fact]
        public void IsRightAngled()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            Assert.True(triangle.IsRightAngled);
        }

        [Fact]
        public void IsNotRightAngled()
        {
            Triangle triangle = new Triangle(3, 4, 6);

            Assert.False(triangle.IsRightAngled);
        }

        [Fact]
        public void IsNotExistingTriangle()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Triangle triangle = new Triangle(10, 4, 2);
            });
        }

        [Fact]
        public void NegativeSideTriangle()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Triangle triangle = new Triangle(-5, 4, 2);
            });
        }

        [Fact]
        public void ZeroSideTriangle()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Triangle triangle = new Triangle(0, 4, 2);
            });
        }
    }
}
