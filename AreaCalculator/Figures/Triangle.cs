namespace AreaCalculator.Figures
{
    public class Triangle : IFigure
    {
        public double Area 
        {
            get
            {
                double p = (A + B + C) / 2;

                double s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

                return s;
            }
        }

        public bool IsRightAngled
        {
            get
            {
                double longestSide = Math.Max(Math.Max(A, B), C);

                if (longestSide == A)
                {
                    return Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2);
                }
                else if (longestSide == B)
                {
                    return Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2);
                }
                else
                {
                    return Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2);
                }
            }
        }

        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            CheckTriangle(a, b, c);

            A = a;
            B = b;
            C = c;
        }

        private void CheckTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными числами.");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует.");
            }
        }
    }
}
