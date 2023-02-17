// Семинар 8, задание 54
// Упорядочить по убыванию каждую строку 2-х мерного массива

int [,] CreatArray() {
  int [,] array = new int[3,4];
  for(int i=0; i<array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++){
      array[i,j] = new Random().Next(1,50);
    }
  }
  return array;
}
void PrintArray(int [,] array) {
  for (int i = 0; i < array.GetLength(0); i++){
    for (int j = 0; j < array.GetLength(1); j++){
      Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
int [,] SortArray(int [,] array){
  int maxNumber = array[0,0];
  for(int i=0; i<array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++){
        int pos= j;
        for(int k=j+1; k<array.GetLength(1); k++){
          if(array[i,k]>array[i,pos]) pos = k;
        }
        int temp = array[i,j];
        array[i,j] = array[i,pos];
        array[i,pos] = temp;
    }
  }
  return array;
}
int [,] numbers = CreatArray();
Console.WriteLine("Массив в случаном порядке:");
PrintArray(numbers);
int [,]sortNum = SortArray(numbers);
Console.WriteLine("Отсортированный массив:");
PrintArray(sortNum);