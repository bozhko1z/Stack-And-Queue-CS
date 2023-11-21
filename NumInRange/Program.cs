namespace NumInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gornaGranica = int.Parse(Console.ReadLine());
            int dolnaGranica = int.Parse(Console.ReadLine());

            Queue<int> queueuе = new Queue<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                queueuе.Enqueue(nums);

                for (int j = dolnaGranica; j <= gornaGranica; j++)
                {
                    if (nums <= gornaGranica && nums >= dolnaGranica)
                    {
                        Console.WriteLine($"{nums} is in range");
                    }
                    else
                    {
                        Console.WriteLine("not in range");
                    }
                    break;
                }

            }
        }
}
