// Семинар 4, задание 27
// Найти сумму цифр во введенном числе (452 -> 11, 82 -> 10, 9012 -> 12)

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = 0;
while(number > 0) {
    digit = digit + number % 10;
    number = number / 10;
}
Console.WriteLine("Сумма цифр числа: "+digit);
