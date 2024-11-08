namespace ConsoleAppTaskInkrementDekrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Enter A: ");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter B: ");
            string inputB = Console.ReadLine();
            
            int a = Convert.ToInt32(inputA);
            int b = Convert.ToInt32(inputB);
            
            int first = a++ +b;//a=31,b=15,first=45
            int second = ++a + b;//a=32,b=15,second=47
            int third = a + b--;//a=32,b=14,third= 47
            int fourth = a + --b;//a=32,b=13,fourth=45
            Console.WriteLine("First result: " + first);
            Console.WriteLine("Second result: " + second);
            Console.WriteLine("Third result: " + third);
            Console.WriteLine("Fourth result: " + fourth);*/

            

              
            int a = 5;
            int b = a++ + ++a + --a + a--;//d=5 c=6, d=12 c=7, d=18 c=6, d=24 c=5
            Console.WriteLine(b);
            
             


        }
    }
}
