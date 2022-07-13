namespace prime_factorization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int num = 10;
            int i,j;
            int count = 0;
            int flag = 0;

            Console.WriteLine("");
            for ( i = 2; i<num; i++)
            {
                if(num % i == 0)
                {
                    count = 0;
                    for(j=1; j<=i; j++)
                    {
                        if (i % j == 0)
                            count++;
                    }
                    if (count == 2)
                    {
                        flag =1;
                        Console.WriteLine(i + " ");

                    }
                }
                
            }
            if(flag == 0)
                Console.WriteLine("no prime : " + num);
        }
    }
}