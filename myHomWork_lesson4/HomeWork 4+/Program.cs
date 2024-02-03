using System;
using HomeWork4Library;
Console.WriteLine("Введите длину матрицы");   
int Matrixlength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту матрицы");
int Matrixheight = Convert.ToInt32(Console.ReadLine());
int[,] arrey = new int[Matrixlength, Matrixheight];
Random r = new Random();
Console.WriteLine("Ваш массив готов:");
for (int i = 0; i < Matrixlength; i++)
{
    for (int j = 0; j < Matrixheight; j++)
    {
        for (int c = 0; c < arrey.Length; c++)
        {
            arrey[i,j] = r.Next(-99, 99);
        }
        Console.Write(arrey[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Чтоб узнать количество положительных и отрецательных значений нажмите \"1\"");
Console.WriteLine("Чтоб отсортировать от меньшего к большему введите \"2\"");
Console.WriteLine("Чтоб отсортировать от большего к мегтшему введите \"3\"");
Console.WriteLine("Чтоб произвести инверцию введите \"4\"");
int qw = 0;
while(qw == 0)
{
    Console.WriteLine("Введите команду от 1 до 4х");
    int a = Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        case 1:
            HomeWork4Class.PositiveAndNegativeCounter(arrey);
            Console.WriteLine();
            break;
        case 2:
            char c = '+';
            HomeWork4Class.sorting(arrey, c);
            Console.WriteLine();
            break;
        case 3:
            char b = 'q';
            HomeWork4Class.sorting(arrey, b);
            Console.WriteLine();
            break;
        case 4:
            HomeWork4Class.inversion(arrey);
            Console.WriteLine();
            break;
    }
    Console.WriteLine("чтоб продолжить работу введите 0");
    Console.WriteLine("Для выхода любую другую цифру");
    qw = Convert.ToInt32(Console.ReadLine());
}






