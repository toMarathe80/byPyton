// Семинар 8, задание 62
// Заполнить 2-х мерный массив 4х4 "змейкой"
void FillSryral(int[,] spyral) {
    int currentNum = 1, i = 0, j = 0;
    while (currentNum <= 16) {
        spyral[i, j] = currentNum;
        currentNum++;
        if (i <= j + 1 && i + j < spyral.GetLength(1) - 1) j++;
        else if (i < j && i + j >= spyral.GetLength(0) - 1) i++;
        else if (i >= j && i + j > spyral.GetLength(1) - 1) j--;
        else i--;
    }
}
void PrintArray(int[,] matr) {
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            if(matr[i,j] < 10) Console.Write(0);
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}
int[,] spyral = new int[4, 4];
FillSryral(spyral);
PrintArray(spyral);
