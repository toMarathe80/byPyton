// Семинар 8, задание 50
// Найти значение элемента по позиции в массиве, или сообщить что такого размера нет

int [,] array = new int[new Random().Next(1,10),new Random().Next(1,10)];
for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
        array[i,j] = new Random().Next(1, 50);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.Write("Введите номер строки (начинается с 0): ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца (начинается с 0): ");
int col = Convert.ToInt32(Console.ReadLine());

if (row < array.GetLength(0) && 
    col < array.GetLength(1)) Console.WriteLine(array[row,col]);
        else                  Console.WriteLine("Такого адреса нет");