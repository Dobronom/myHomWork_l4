using System.Threading.Channels;

/* вывод всех нечётных чисел. от 1 до 100*/
//int[] arrey = new int[100];
//int a = 1;
//for (int i = 0; i < arrey.Length; i++)
//{
//    arrey[i] = a++;
//    if (arrey[i] % 2 != 0)
//    {
//        Console.WriteLine(arrey[i]);
//    }
//}

/*вывод массива в обратном порядке*/
//int[] arrey = new int[5];
//int a = 1;
//for (int i = 0; i < arrey.Length; i++)
//{
//    arrey[i] = a++;
//}
//for (int i = arrey.Length - 1; i >= 0; i--)
//{
//    Console.Write(arrey[i]);
//}

/*вывод суммы всех чисел до введённого*/
//Console.WriteLine("Введите любое целое положительное число.");
//int number = Convert.ToInt32(Console.ReadLine());
//int cum = 0;
//for (int i = 0; i <= number; i++)
//{
//    cum += i;
//}
//Console.WriteLine($"Сумма всех чисел до введённого = {cum}");

/*вывод значений с ходом в 7*/
//int a = 0;
//while (a % 7 == 0 & a < 98)
//{
//    a += 7;
//    Console.WriteLine(a);
//}

///*тоже самое из массива*/
//int[] arrey = new int[100];
//int b = 1;
//for (int i = 0; i < arrey.Length; i++)
//{
//    arrey[i] = b++;
//}
//int c = 0;
//while (arrey[c] < arrey.Length)
//{
//    c++;
//    if (arrey[c] % 7 == 0)
//        Console.WriteLine(arrey[c]);
//}

/*Среднее значение и их сравнение*/
//int[] arrey1 = new int[5];
//int[] arrey2 = new int[5];
//Random r = new Random();
//for (int i = 0; i < arrey1.Length; i++)
//{
//    arrey1[i] = r.Next(1, 101);
//    arrey2[i] = r.Next(1, 101);
//}
//int sum1 = 0;
//int sum2 = 0;
//foreach (int i in arrey1)
//{
//    Console.Write(i + " ");
//    sum1 += i;
//}
//Console.WriteLine("Среднее арифметическое первого массива " + sum1 / 5);
//foreach (int i in arrey2)
//{
//    Console.Write(i + " ");
//    sum2 += i;
//}
//Console.WriteLine("Среднее арифметическое второго массива " + sum2 / 5);
//if (sum1 > sum2)
//{
//    Console.WriteLine("У первого массива среднее значение выше");
//}
//else if ((sum1 / 5) < (sum2 / 5))
//{
//    Console.WriteLine("У второго массива среднее значение выше");
//}
//else
//{
//    Console.WriteLine("Средние значения равны");
//}























//Random r = new Random();
//for (int i = 0; i < arrey.Length; i++)
//{
//    arrey[i] =r.Next(1,101); 
//}