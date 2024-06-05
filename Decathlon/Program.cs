using Decathlon.Bicycles;
using Decathlon.Bicycles.Builder;

namespace Decathlon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBicycleBuilder bicycleBuilder = new DefaultBicycleBuilder();

            Bicycle retroBicycle = bicycleBuilder.GetBicycle(BicycleType.RetroBicycle);
            Bicycle plusBicycle = bicycleBuilder.GetBicycle(BicycleType.PlusBicycle);

            Console.WriteLine($"The cost of RetroBicycle is ${retroBicycle.GetCost()}");
            Console.WriteLine($"The cost of PlusBicycle is ${plusBicycle.GetCost()}");
        }
    }
}
