namespace TaskLibrary
{
    public class Circle:ICalculation
    {
        private double _radius;

        public Circle(double radius)
        {
            if(radius > 0)
            {
                _radius = radius;
            }
            else
            {
                throw new Exception("Радиус не может быть <= 0");
            }
        }

        public double CalculateArea()
        {
            return Math.PI*Math.Sqrt(_radius);
        }
    }
}
