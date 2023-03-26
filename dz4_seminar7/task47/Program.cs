// Семинар 8, задание 47
// Заполнить случайными числами 2-х мерный массив м на н

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

 double [,] array = new double[row,col];
 for(int i = 0; i < row; i ++) {
    for(int j = 0; j < col; j ++) {
        array[i,j] = new Random().Next(-50, 50);
        array[i,j] = array[i,j] / 10; //чтоб получились дробные числа
        Console.Write($"{array[i,j]} ");
     }
     Console.WriteLine();
 }
