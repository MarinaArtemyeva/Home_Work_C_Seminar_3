// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Ввеедите число: ");
int cubenumber = Convert.ToInt32(Console.ReadLine());

void Cube (int[] cubenumber)
{
    int counter = 0;
    int length = cubenumber.Length;
    while (counter < length)
    {
        cubenumber[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}

void PrintArray(int[] collum)
{
    int count = collum.Length;
    int index = 0;
    while(index < count)
    {
        Console.Write(collum[index]+ " ");
        index++;
    }
}

int[] Array = new int[cubenumber+1];
Cube(Array);
PrintArray(Array);