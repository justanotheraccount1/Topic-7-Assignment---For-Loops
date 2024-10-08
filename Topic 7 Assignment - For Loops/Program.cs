namespace Topic_7_Assignment___For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int y;
            for (int i = 10; i >= 1; i = i - 1)
                Console.Write(i + ".\t");
            Console.WriteLine();
            Console.WriteLine();
            for (int i = -10; i <= 10; i = i + 2)
            {
                y = i * i;
                Console.WriteLine(i + "\t" + y);
            }
            Console.WriteLine();

            Console.WriteLine("What is your name?");
            name = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (name == "ALDWORTH")
                for (int i = 1; i <= 5; i = i + 1)
                    Console.WriteLine(name);
            else
            {
                for (int i = 1; i <= 10; i = i + 1) 
                    Console.WriteLine(name);
            }
        }
    }
}
