namespace TaskLibrary
{
    public class Triangle:ICalculation
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            if(isExist(a, b, c))
            {
                _a = a;
                _b = b;
                _c = c;
            }
        }

        private bool isExist(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Сторона не может быть <= 0");
            }

            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new Exception("Сторона не может быть больше суммы двух других сторон");
            }

            return true;
        }

        public double CalculateArea()
        {
            double p = (_a + _b + _c) / 2;
            double result = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
            return result;
        }

        public bool isStraightTriangle()
        {
            bool isStraight = (_a == Math.Sqrt(Math.Sqrt(_b) + Math.Sqrt(_c))
                               || _b == Math.Sqrt(Math.Sqrt(_a) + Math.Sqrt(_c))
                               || _c == Math.Sqrt(Math.Sqrt(_a) + Math.Sqrt(_b)));

            return isStraight;
        }
    }
}
