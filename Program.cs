namespace myParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("How many random integer numbers do you want to create?");
            int[] num = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"{num[i] = r.Next(1,100)}");
            }
            Console.WriteLine($"Total of the numbers array: {Add(num)}");
            Console.WriteLine($"Product of the numbers array: {Multiply(num)}");
        }

        static int Add(params int[] num)
        {
            int sum = 0;
            foreach (int i in num)
            {
                sum += i;
            }
            return sum;
        }

        static int Multiply(params int[] num)
        {
            int mul = 1;
            foreach(int i in num)
            { 
                mul *= i;
            }
            return mul;
        }
    }
}
