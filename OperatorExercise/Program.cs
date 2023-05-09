namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {




            //Add, subtract, multiply operations
            int sum1 = 4;
            int sum2 = 12;
            Console.WriteLine("Sum1 plus Sum2 is " + (sum1 +sum2) );
            var diff1 = 24;
            var diff2 = 12;
            Console.WriteLine("Diff1 minus diff2 is " + (diff1 - diff2));











            //Declare Variables for Excercise 1 

            var A = 17;
            var B = 4;
            int quotient = (A / B);
            int Remainder = (A % B);
            


            /*To have user input for excercise 1

            Console.Write("Enter variable A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter Variable B: ");
            int B = int.Parse(Console.ReadLine());
            int quotient = (A / B);
            int Remainder = (A % B);
            
             */


            
            // If statement Exercise 1 
            if (A == 17 && B == 4) 
            {
                Console.WriteLine($"17/4 is {quotient} remainder {Remainder}");
            }
            if (A != 17 && B != 4 )
            {
                Console.WriteLine($"{A}/{B} is {quotient} remainder {Remainder}");
            }


            //get user input for radius of circle
            Console.Write("Enter a radius for the Circle: ");
            var radius = double.Parse(Console.ReadLine());

            //Calculate the area of the circle by calling method 
            Console.WriteLine($"The Area of your circle is : {AreaOfCircle(radius)}");

        }

        //Method for calculating the area
        public static double AreaOfCircle(double radius)
        {

           var area = Math.PI* Math.Pow(radius, 2);

            return area;


        }




    }
}