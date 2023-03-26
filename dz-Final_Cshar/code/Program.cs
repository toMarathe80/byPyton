// Из массива строк сформировать новый массив строк с эллементами 
// равными или меньше 3 символа

string[]array1 = {"hello","2","world",":-)"};
string[] array2 = new string[array1.Length-1];
int index = 0;
for(int i = 0; i < array1.Length; i += 1){
    if (array1[i].Length <= 3){
        array2[index] = array1[i];  
        index += 1;        
    }
}
Console.WriteLine(string.Join(" ",array2));
