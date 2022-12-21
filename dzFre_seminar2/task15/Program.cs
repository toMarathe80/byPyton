// Семинар 2, Задача 15
// Являеться ли день недели выходным?

 Console.WriteLine("Введите цифрами день недели: ");
 int num = Convert.ToInt32(Console.ReadLine());
 
    if (num > 8) {
      Console.WriteLine("Расчет только на семь дней");
    }
    else if (num != 6 && num != 7) {  
 
    Console.WriteLine("день рабочий");
    }
    else {
    Console.WriteLine("день выходной");  

    }