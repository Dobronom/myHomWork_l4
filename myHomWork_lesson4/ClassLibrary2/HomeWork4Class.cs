namespace HomeWork4Library
{
    public class HomeWork4Class
    {
        public static void PositiveAndNegativeCounter(int[,] arrey)
        {
            int PositiveCounter = 0;
            int NegativeCounter = 0;
            int zero = 0;
            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1); j++)
                {
                    if (arrey[i, j] > 0)
                    {
                        PositiveCounter++;
                    }
                    else if (arrey[i, j] < 0)
                    {
                        NegativeCounter++;
                    }
                    else
                    {
                        zero++;
                    }
                }
            }
            Console.WriteLine($"Положительных: {PositiveCounter}\n отрецательных: {NegativeCounter}\n с нулевым значением: {zero} ");
        }
        public static void sorting(int[,] arrey, char a)
        {
            int qwer = 0;
            int qwer1 = 0;
            
            
            
                for (int i = 0; i < arrey.GetLength(0); i++)
           
                {
                
                    for (int j = 0; j < arrey.GetLength(1); j++)
               
                    {
                        for (int c = j + 1; c < arrey.GetLength(1); c++)
                        {
                            if (a == '+')
                            {
                                if (arrey[i, j] > arrey[i, c])
                                {
                                    qwer = arrey[i, j];
                                    arrey[i, j] = arrey[i, c];
                                    arrey[i, c] = qwer;
                                }
                            }
                            else
                            {
                               if (arrey[i, j] < arrey[i, c])
                               {
                                   qwer1 = arrey[i, j];
                                   arrey[i, j] = arrey[i, c];
                                   arrey[i, c] = qwer1;

                               }
                            }
                        }
                    }
                }
            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = 0; j < arrey.GetLength(1); j++)
                {

                    Console.Write(arrey[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void inversion(int[,] arrey)
        {
            for (int i = 0; i < arrey.GetLength(0); i++)
            {
                for (int j = arrey.GetLength(1) - 1; j >= 0; j--)
                {

                    Console.Write(arrey[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
 
}
