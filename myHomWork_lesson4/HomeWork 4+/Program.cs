using System;
using ClassLibrary2;
Console.WriteLine("Введите длину матрицы");   
int Matrixlength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту матрицы");
int Matrixheight = Convert.ToInt32(Console.ReadLine());
int[,] arrey = new int[Matrixlength, Matrixheight];
Random r = new Random();

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
//Счётчик отрецательных и положительных чисел
Class1 qwe = new Class1();
qwe.Counter(arrey);

    

//сортировка от меньшего к большему
int qwer = 0;
int qwer1 = 0;
Console.WriteLine(arrey.Length);
for (int i = 0; i < Matrixlength; i++)
{
    for (int j = 0; j < Matrixheight; j++)
    {
        for(int c = j + 1;c < arrey.GetLength(1); c++)
        {
            if (arrey[i,j] > arrey[i,c])
            {
                qwer = arrey[i, j];
                arrey[i, j] = arrey[i, c];
                arrey[i, c] = qwer;

            }
        }
    }
}




for (int i = 0; i < Matrixlength; i++)
{
    for (int j = 0; j < Matrixheight; j++)
    {
        
        Console.Write(arrey[i, j] + " ");
    }
    Console.WriteLine();
}
//сортировка от большего к меньшему.
for (int i = 0; i < Matrixlength; i++)
{
    for (int j = 0; j < Matrixheight; j++)
    {
        for (int c = j + 1; c < arrey.GetLength(1); c++)
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

for (int i = 0; i < Matrixlength; i++)
{
    for (int j = 0; j < Matrixheight; j++)
    {

        Console.Write(arrey[i, j] + " ");
    }
    Console.WriteLine();
}































//Random r = new Random();
//for (int i = 0; i < arrey.Length; i++)
//{
//    arrey[i] =r.Next(1,101); 
//}