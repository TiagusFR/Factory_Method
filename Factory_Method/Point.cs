namespace Factory_Method
{
    public class Point
    {
        private double x;
        private double y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoinrt(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta),rho * Math.Sin(theta));
        }

        public double X => x;
        public double Y => y;
    }
}
