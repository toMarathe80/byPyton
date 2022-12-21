// Семинар 2, Задача 10
// Вывести вторую цифру введенного трехзначного числа

 Console.WriteLine("Введите 3-х значное число: ");
 int num = Convert.ToInt32(Console.ReadLine());

    if (num < 100 || num >= 1000) {  
    Console.WriteLine("число не 3-х значное");
    }
    
    else {
    Console.WriteLine(num / 10 % 10);  
    }