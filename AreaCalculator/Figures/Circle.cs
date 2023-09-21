namespace AreaCalculator.Figures
{
    public class Circle : IFigure
    {
        public double Area => Math.PI * Math.Pow(Radius, 2);

        public double Radius { get; }

        public Circle(double radius)
        {
            CheckCircle(radius);

            Radius = radius;
        }

        private void CheckCircle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус круга должен быть положительным числом.");
            }
        }
    }
}
