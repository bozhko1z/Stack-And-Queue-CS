namespace ExistingNumWithStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                stack.Push(number);
            }
            int search = int.Parse(Console.ReadLine());
            bool exists = false;
            for (int i = 0; i < stack.Count; i++)
            {
                if (stack.Pop() == search)
                {
                    exists = true;
                    break;
                }
            }

            if (exists == true)
            {
                Console.WriteLine($"{search} exists in the stack.");
            }
            else Console.WriteLine($"{search} doesn't exist in the stack.");
        }
    }
}
