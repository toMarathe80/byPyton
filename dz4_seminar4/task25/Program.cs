// Семинар 4, задание 25
// Возвести число А в натуральную степень В (3,5 -> 243)

Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int degree = Convert.ToInt32(Console.ReadLine());
int result = 1;
int step = 1;
while (step <= degree) {
    result = result * number; 
    step += 1;   
}
Console.WriteLine(result);
