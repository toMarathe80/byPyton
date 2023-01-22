// Семинар 4, задание 29
// Вывести на экран массив из 8-ми случайных элементов

int [] array = new int [8];
for(int i = 0; i < array.Length; i+= 1) {
    array[i] = new Random().Next(0, 10);
   }
   Console.WriteLine("Массив из 8 случайных цифр: ");
    for (int i = 0; i < array.Length; i+= 1) {
        Console.WriteLine(array[i]);
    }
