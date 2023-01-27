// Семинар 6, задание 41
// Посчитать, сколько чисел больше 0 ввел пользователь

Console.WriteLine("Введите 4 числа");
int[] array = new int[4];
for (int i = 0; i < 4; i += 1) {
    Console.Write($"Номер {i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    int count = 0;
    foreach(int i in array) {
        if(i > 0) {
            count += 1;
            }
    }
    Console.WriteLine("чисел больше 0: "+count);