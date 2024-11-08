namespace ConsoleAppTaskTemperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Fahrenheit: ");
            string inputTemperature = Console.ReadLine();


            
            
            double temperature = Convert.ToDouble(inputTemperature);
            temperature = (temperature - 32) / 1.87;
            Console.WriteLine("Celsius: " + temperature);


      



        }
    }
}
