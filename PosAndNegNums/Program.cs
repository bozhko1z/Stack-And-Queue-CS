namespace PosAndNegNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<int> posNums = new Stack<int>();
            Stack<int> negNums = new Stack<int>();

            foreach (string put in input)
            {
                int num = int.Parse(put);

                if (num >= 0)
                {
                    posNums.Push(num);
                }
                else
                {
                    negNums.Push(num);
                }
            }

            while (posNums.Count > 0)
            {
                Console.Write(posNums.Pop() + " ");
            }
            Console.WriteLine();

            while (negNums.Count > 0)
            {
                Console.Write(negNums.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}
