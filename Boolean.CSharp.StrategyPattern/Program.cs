namespace Boolean.CSharp.StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Strategy Pattern Example");
            
            TravelPlanner travelPlanner = new TravelPlanner();

       


            travelPlanner.SetTravelStrategy(new Plane());
            travelPlanner.Drive(1100);

            Console.ReadKey();

        }
    }
}