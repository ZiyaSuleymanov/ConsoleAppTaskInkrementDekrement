namespace ConsoleAppTaskHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Worker's monthly salary: ");
            string inputWorkerSalary = Console.ReadLine();

            double salary = Convert.ToDouble(inputWorkerSalary);
            salary += salary * 11;
            Console.WriteLine("Worker's annual salary: " + salary);

        }
    }
}
