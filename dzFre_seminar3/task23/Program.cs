// Семинар 3, Задача 23
// Вывести все числа в 3 степени до введенного в num

 Console.WriteLine("Введите число: ");
 int num1 = Convert.ToInt32(Console.ReadLine());
 
 int count = 0;
 Console.WriteLine();
 while (count < num1) {

    count += 1;
    Console.WriteLine(count*count*count);
    }
