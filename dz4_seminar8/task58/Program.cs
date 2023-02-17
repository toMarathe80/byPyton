// Семинар 8, задание 58
// Найти произведение 2-х матриц как в примере

int [,] numbers1 = {{2,4}, {3,2}};
int [,] numbers2 = {{3,4}, {3,3}};
int [,] MultMatrix(int [,] numbers1, int [,] numbers2) {
  int[,] result = new int[2, 2];
  for(int i=0; i<result.GetLength(0); i++) {
    for(int j=0; j<result.GetLength(1); j++) {
      int sum =0;
      for(int k=0; k<numbers1.GetLength(1); k++) {
      sum = sum + numbers1[i,k] * numbers2[k,j];
      }
      result[i, j] = sum;
    }
  }
  return result;
}
void PrintArray(int [,] array) {
  for (int i = 0; i < array.GetLength(0); i++) {
    for (int j = 0; j < array.GetLength(1); j++) {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}
int[,] multArray = MultMatrix(numbers1, numbers2);
PrintArray(multArray);