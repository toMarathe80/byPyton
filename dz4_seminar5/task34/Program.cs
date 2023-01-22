// Семинар 5, Задание 34
// Показать количество четных чисел в массиве из 3-х значных чисел
// [345, 897, 568, 234] -> 2

int [] array = new int [8];
for(int i = 0; i < array.Length; i+= 1) {
    array[i] = new Random().Next(100, 999);
   }
   Console.WriteLine("Вот массив из 8 случайных цифр: ");
    foreach (int i in array) {
        Console.WriteLine(i);
    }
     Console.WriteLine("количество четных чисел: ");
     int N = 0;
     foreach (int i in array) {     
        if(i % 2 == 0) 
        N += 1;
    }
    Console.WriteLine(N);

