// Семинар 8, задание 50
// Найти значение элемента по позиции в массиве, или сообщить что такого размера нет

int rows = new Random().Next(1,10);
int cols = new Random().Next(1,10);
int [,] array = new int[rows, cols];
for (int i = 0; i < rows; i++) {
    for (int j = 0; j < cols; j++) {
        array[i,j] = new Random().Next(1, 50);
    }
}
for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.Write("Введите номер строки (начинается с 0): ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца (начинается с 0): ");
int col = Convert.ToInt32(Console.ReadLine());

if (row > rows && col <= cols)      Console.WriteLine("Такого адреса нет");
else if (row <= rows && col > cols) Console.WriteLine("Такого адреса нет");
else if (row > rows && col > cols) Console.WriteLine("Такого адреса нет");
else                                Console.WriteLine(array[row,col]);