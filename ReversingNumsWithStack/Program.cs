namespace ReversingNumsWithStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
