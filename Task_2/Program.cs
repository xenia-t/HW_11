/* Проверка на простое число:
   N = 13 -> "Это простое число"
   N = 12 -> “Это не простое число” */

int N = Promt("\nВведите значение числа N: ");
if (N > 0)
{
    int prime_num = 1;
    PrimeNum(N, prime_num);
}
else System.Console.WriteLine("\nПростыми могут быть только натуральные числа\n");


int Promt(String message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void PrimeNum (int N, int prime_num)
{
    for (int i = 2; i <= N / 2; i++)
    {
        if (N % i == 0)
        {
            prime_num = 0;
            break;
        }
    }
    if (prime_num == 1) System.Console.WriteLine($"\nЧисло {N} является простым\n");
    else System.Console.WriteLine($"\nЧисло {N} не является простым\n"); 
}

