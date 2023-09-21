using AreaCalculator.Figures;

namespace AreaCalculator.Tests.FiguresTests
{
    public class CircleTests
    {
        [Fact]
        public void CorrectArea()
        {
            Circle circle = new Circle(10);

            double roundedArea = Math.Round(circle.Area, 2);

            Assert.Equal(314.16, roundedArea);
        }

        [Fact]
        public void NegativeRadiusException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Circle circle = new Circle(-1);
            });
        }

        [Fact]
        public void ZeroRadiusException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Circle circle = new Circle(0);
            });
        }
    }
}
