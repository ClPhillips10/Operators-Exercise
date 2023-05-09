namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            int quotient = (a / b);
            int Remainder = (a % b);


            int Radius = 3;

            if (a == 17 && b == 4) 
            {
                Console.WriteLine($"17/4 is {quotient} remainder {Remainder} ");
            }
        }
    }
}