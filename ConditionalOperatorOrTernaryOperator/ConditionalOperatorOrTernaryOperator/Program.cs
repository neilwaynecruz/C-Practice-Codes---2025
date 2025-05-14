namespace ConditionalOperatorOrTernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conditional operator/ ternary operator = used in conditional assignment if a condition is true/false

            // (condition) ? x : y


            //Console.Write("Pogi ka ba? [Y/N]: ");
            //char answer = Convert.ToChar(Console.ReadLine().Substring(0,1).ToUpper());

            //String message = answer == 'Y' ? "WOW KAPAL MO NAMAN!" : "BUTI ALAM MO HAHA!!";

            int num1 = Convert.ToInt32(Console.ReadLine());

            String message2 = num1 == 1 ? "1 YARN!!" : 
                              (num1 == 2) ? "OO 2 TO!" : 
                              (num1 == 3) ? "3 NGANI!!" :
                              (num1 == 4) ? "4 TO BOII!!" : "HINDI KASAMA YAN BOI, WAG KA TANGA!!";

            Console.WriteLine(message2);



        }
    }
}
