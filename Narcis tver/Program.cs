namespace Narcis_tver
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int userNumber = int.Parse(Console.ReadLine());
            int temp = 0;
            int digit = 0;
            int degree = 0;
            int sum = 0;
            temp = userNumber;
            while (temp != 0)
            {
                temp /= 10;
                degree++;   
            }
            temp = userNumber;
            while (temp != 0)
            {
                digit =temp % 10;
                int multi = 1;
                for (int i = 0; i < degree; i++)
                {
                    multi *= digit;
                }

                sum += multi;
                temp /= 10;


            }
            if (sum==153)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
           




        }
    }
}