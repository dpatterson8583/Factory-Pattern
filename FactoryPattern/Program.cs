namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newveh1 = VehicleFactory.GetVehicle(4);

            var newveh2 = VehicleFactory.GetVehicle(2);

            Console.WriteLine($"{newveh1.GetType()} ");
            newveh1.Drive();

            Console.WriteLine($"{newveh2.GetType()}");
            newveh2.Drive();

        }
    }
}
