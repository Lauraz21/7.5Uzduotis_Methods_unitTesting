namespace _7._5Uzduotis_Methods_unitTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite cilindro spinduli ir auksti: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            double together = CalculateCylinderVolume(radius, height);
            Console.WriteLine("turis: " + together);
        }
        public static double CalculateCylinderVolume(double spind, double aukstis)
        {
             return 3.14 * (Math.Pow(spind, 2)) * aukstis;
        }
    }
}