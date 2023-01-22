// Семинар 5, Задание 36
// Найти сумму элементов в массиве стоящих на нечетных позициях 
// [3, 7, 23, 12] -> 19

int [] array = new int [4];
for(int i = 0; i < array.Length; i+= 1) {
    array[i] = new Random().Next(1, 10);
   }
   Console.WriteLine("Вот массив из 4 случайных цифр: ");
    foreach (int i in array) {
        Console.WriteLine(i);
    }
     Console.WriteLine("сумма нечетных чисел: ");
     int N = 0;
     foreach (int i in array) { 
        if(i % 2 != 0) 
        N += i;
    }
    Console.WriteLine(N);
