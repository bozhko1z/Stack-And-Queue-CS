namespace SortingNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueu = new Queue<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                queueu.Enqueue(nums);
            }
            int num = int.Parse(Console.ReadLine());
            queueu.Enqueue(num);
            List<int> sorted = queueu.ToList();
            sorted.Sort();
            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}
