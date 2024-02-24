// int N = 100;
// int i = 1;
// while (i <= N)
// {
//     Console.Write(i);
//     Console.Write(' ');
//     i = i + 1;
// }


/*РЕКУРСИЯ*/
void openMatryoshka (int size)
{
    if (size ==1)
    {
        Console.WriteLine ($"Достигнут базовый случай {size}");
        return;
    }
    Console.WriteLine($"Открытый размер матрешки {size}...");
    openMatryoshka (size-1);
    Console.WriteLine($"Раскрутка рекурсии {size}...");
    
}

openMatryoshka (5);






