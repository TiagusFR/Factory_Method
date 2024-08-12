using Factory_Method;

public class Program
{
    public static void Main()
    {
        Point cartesianPoint = Point.NewCartesianPoint(3, 4);
        Console.WriteLine($"Cartesian Point: X = {cartesianPoint.X}, Y = {cartesianPoint.Y}");

        double rho = 5;
        double theta = Math.PI / 4;
        Point polarPoint = Point.NewPolarPoinrt(rho, theta);
        Console.WriteLine($"Polar Point: X = {polarPoint.X}, Y = {polarPoint.Y}");
    }
}