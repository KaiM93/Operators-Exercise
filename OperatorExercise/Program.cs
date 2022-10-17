namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For division, create two integer variables called a and b

            var a = 17;
            var b = 4;
            var quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
        }
    }
}