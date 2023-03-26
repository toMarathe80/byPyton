// Семинар 9, задание 64
// Выполнить с помощью ресурсии вывод всех чисел до N

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
void PrintNumbers(int number) {
  if(number == 1) Console.WriteLine(number);
  else{
    Console.WriteLine(number);
    PrintNumbers(number-1);
  }
}
PrintNumbers(number);