// Семинар 5, Задание 38
// Найти разницу между мин и мах в массиве 
// [3 7 22 2 78] -> 76

int [] array = new int [5];
for(int i = 0; i < array.Length; i+= 1) {
    array[i] = new Random().Next(1, 100);
   }
   Console.WriteLine("Вот массив из "+ array.Length +" случайных цифр: ");
    foreach (int i in array) {
        Console.WriteLine(i);
    }
     Console.WriteLine();
     int max = array[0];
     int min = array[0];
     for(int i=0; i<array.Length; i += 1) { 
        if(max < array[i])  max = array[i];
        if(min > array[i])  min = array[i];
    }
    Console.WriteLine("Разница между max и min: "+(max - min));