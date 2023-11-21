namespace ExistingNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int chisla = int.Parse(Console.ReadLine());
                queue.Enqueue(chisla);
            }
            int lastNum = int.Parse(Console.ReadLine());
            if (queue.Contains(lastNum))
            {
                Console.WriteLine($"num {lastNum} is here");
            }
            else
            {
                Console.WriteLine($"num {lastNum} is not here, sorry :(");
            }
        }
    }
}
