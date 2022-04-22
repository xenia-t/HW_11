/* Определите, является ли число степенью двойки:
   N = 16 -> "Является степенью двойки"
   N = 12 -> “Не является степенью двойки” */

int N = Promt("\nВведите значение числа N: ");
if (N > 0)
{
    if (Row(N)) System.Console.WriteLine($"\nЧисло {N} является степенью двойки\n");
    else System.Console.WriteLine($"\nЧисло {N} не является степенью двойки\n");
}
else System.Console.WriteLine("\nСтепенью двойки может быть только натуральное число\n");


int Promt(String message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

bool Row (int N)
{
    for (int i = N; i > 1; i /= 2)
    {
        if (i % 2 != 0) return false;
    }
    return true;
}
