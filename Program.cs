namespace Calculator_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int num1, num2;
            bool flag;
            char opr;


            Console.WriteLine("Hello, welcome to Caly");
            Console.WriteLine("Caly is a Calculator Program");

            Console.WriteLine("");


            do
            {
                Console.WriteLine("Please enter your first number (a valid one):");
                flag = int.TryParse(Console.ReadLine(), out num1);

            } while (!flag);


            do
            {
                Console.WriteLine("Please enter your second number (a valid one):");
                flag = int.TryParse(Console.ReadLine(), out num2);

            } while (!flag);



                
            Console.WriteLine("What type of operation would you like to do ?");
            do
            {
                Console.WriteLine("Please enter a (add), s (subtract), m (mutiply), d (divide)");
                flag = char.TryParse(Console.ReadLine(), out opr);

                if (flag)
                {        
                 if (opr == 's' || opr == 'a' || opr == 'm' || opr == 'd')
                 {
                    flag = true;
                 }
                 else
                 {
                    flag = false;
                 }
                }

            } while (!flag);



            Console.WriteLine("");
            Console.WriteLine("********************************************************");
            Console.WriteLine("");


            Console.WriteLine("The Result:");

            if (opr == 'a')
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }
            if (opr == 's')
            {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }
            if (opr == 'm')
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }
            if (opr == 'd')
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }


            Console.ReadKey();
        }
    }
}
