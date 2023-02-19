// Семинар 9, задание 68
// Вычеслить с помощью ресурсии функцию Акермана. Задать два натуральных числа

long AkkermanRec(long m, long n) {
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkkermanRec(m - 1, 1);
    return (AkkermanRec(m - 1, AkkermanRec(m, n - 1)));
}

Console.Write("Введите неотрицательные числа <=3: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательные числа <=10: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m},{n}) = {AkkermanRec(m, n)}");