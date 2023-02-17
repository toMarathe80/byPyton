// Семинар 8, задание 56
// Найти строку с наименьшей суммой элементов в 2-х мерном пространстве
int [,] FillArray(){
  int rows = new Random().Next(1,11);
  int cols = new Random().Next(1,11);
  int[,] array = new int[rows, cols];
  if(rows!=cols){
    for(int i=0; i<array.GetLength(0); i++){
      for(int j=0; j<array.GetLength(1); j++){
        array[i,j] = new Random().Next(1,10);
      }
    }
  }
  return array;
}
void PrintDoubleArray(int[,] array) {           // Выводим 2-x мерный массив для проверки
  for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}
int [] Sum (int [,] array) {          // Считаем сумму элементов в строке и записываем в одномерный массив
  int [] result = new int [array.GetLength(0)];
  for(int i=0; i<array.GetLength(0); i++) {
    int sum = 0;
    for(int j=0; j<array.GetLength(1); j++) {
      sum =sum + array[i,j];
    }
    result[i] = sum;
  }
  return result;
}
void PrintArray(int [] array) {         // Выводим одномерный массив
  for(int i=0; i<array.Length; i++) {
    Console.Write($"{array[i]} ");
  }
} 
void MinSum (int [] array) {
  int min = array[0];
  int row = 0;
  for(int i=0; i<array.Length; i++) {
    if(min > array[i]) {
      min = array[i];
      row = i;
    }
  }
  Console.WriteLine ($"Наименьшую сумму элементов имеет строка номер {row} (нумерация с 0)");
}
int[,] numbers = FillArray();
Console.WriteLine("Первый массив");
PrintDoubleArray(numbers);
int [] sumArray = Sum(numbers);
Console.WriteLine("Суммы по строкам:");
PrintArray(sumArray);
Console.WriteLine();
MinSum(sumArray);