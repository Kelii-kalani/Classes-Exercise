namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
           Car car1 = new Car();
            car1.Make = "Subaru";
            car1.Model = "Impreza WRX STi";
            car1.Year = 2005;

            Console.WriteLine($"The make of the car: {car1.Make}.");
            Console.WriteLine($"The model of car: {car1.Model}.");
            Console.WriteLine($"The year of the car: {car1.Year}.");

        }
    }
}
