namespace AllNumsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string nums = number.ToString();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int cifra = number % 10;
                number = number / 10;
                stack.Push(cifra);
            }
            Console.WriteLine(string.Join(" + ", stack) + " = " + stack.Sum());
        }
    }
}
