﻿// Семинар 8, задание 60
// Сделать 3-х мерный массив из неповторяющихся 2-х значных чисел и   
// построчно вывести с индексами каждого элемента.

int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintArray(array);
void PrintArray(int[,,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++) {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
void FillArray(int[,,] arr) {
    Random rand = new Random();
    int temp;
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            for (int k = 0; k < arr.GetLength(2); k++) {
            restart:
                temp = rand.Next(10, 100);
                for (int x = 0; x < arr.GetLength(0); x++) {
                    for (int y = 0; y < arr.GetLength(1); y++) {
                        for (int z = 0; z < arr.GetLength(2); z++) {
                            if (arr[x, y, z] == temp) goto restart;
                        }
                    }
                }
                arr[i, j, k] = temp;
            }
        }
    }
}
