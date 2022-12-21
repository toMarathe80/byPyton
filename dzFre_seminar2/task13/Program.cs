// Семинар 2, Задача 13
// Вывести третью цифру введенного числа, или сообщения что ее нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) {
    
  Console.WriteLine("Здесь нет третьей цифры");
 }
 else {
  while (number > 999) {
    number = number / 10;
  }
  Console.WriteLine(number % 10);
}