namespace Debugging2
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            int a = 10;
            int b = 2;

            float answer = divide(a, b);

            Console.WriteLine(answer);
 
        }

        public static float divide(int a, int b)
        {
            Console.WriteLine("Dividing " + a + " by " + b);

            return a/b;
        }
    }
}
