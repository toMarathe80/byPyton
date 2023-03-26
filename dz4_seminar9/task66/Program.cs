// Семинар 9, задание 66
// Выполнить с помощью ресурсии вывод суммы чисел от М до N

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int numberM, int NumberN) {
  if (numberM < numberN){
    if(numberM == numberN) return numberM;
    else {
    return numberM + SumNumbers(numberM+1, numberN);
    }
  }
  else {
    if (numberN == numberM) return numberN;
    else {
      return numberN + SumNumbers(numberN + 1, numberM);
    }
  }
}
Console.WriteLine(SumNumbers(numberM, numberN));
