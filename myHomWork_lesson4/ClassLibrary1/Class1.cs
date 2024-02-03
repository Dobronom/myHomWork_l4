namespace ClassLibrary1
{
    public class PositiveCounterNegativeCounter
    {
    static void Counter(int[,] arrey)
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
    }
}
