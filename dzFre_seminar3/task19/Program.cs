// Семинар 3, Задача 19
// Проверить 5 значное число на палиндром

Console.Write("Введите 5-ти значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 9999 || number > 99999) {
    Console.Write("это не 5-значное число");
    }
else {
    int numberReverse = 0;
    int numberCopy = number;
    while (number > 0) {
        int temp = number % 10;
        numberReverse = numberReverse * 10 + temp; // если разбиваем число с помощью коэф.10, то можно обратно
        number = number / 10;
        }
    if (numberReverse == numberCopy) {
        Console.WriteLine("Это палиндром!");
        }
    else { 
    Console.WriteLine("Это не палиндром!");
      }
    }