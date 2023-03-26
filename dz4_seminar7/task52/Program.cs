// Семинар 8, задание 52
// Найти среднее арифметическое по каждому столбцу в массиве

int [,] array = new int [new Random().Next(1,11),new Random().Next(1,11)];
double [] arrayAvg = new double[array.GetLength(0)];

for(int i=0; i<array.GetLength(0); i++) {
    for(int j=0; j<array.GetLength(1); j++) {
        array[i,j] = new Random().Next(1,50);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое столбцов: ");
for(int i=0; i<array.GetLength(1); i++) {
    for(int j=0; j<array.GetLength(0); j++) { 
        arrayAvg[i] += array[j,i];
    }
    arrayAvg[i] = Math.Round(arrayAvg[i]/array.GetLength(1),2);
    Console.Write($"{arrayAvg[i]} ");
}
Console.WriteLine();