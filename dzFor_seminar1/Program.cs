// // Семинар 1, Задача 2
// // Какое из двух чисел больше?

//  Console.WriteLine("Введите число: ");
//  int num1 = Convert.ToInt32(Console.ReadLine());
 
//  Console.WriteLine("Введите число: ");
//  int num2 = Convert.ToInt32(Console.ReadLine());
 
//     if(num1 > num2) {

//     Console.WriteLine("Первое число больше второго");
//   }
//     else if (num1 < num2) {

//     Console.WriteLine("Второе число больше первого");
//  }

//      else {
//     Console.WriteLine("Оба числа равны");
//  }



//  // Семинар 1, Задача 4
// // Какое из трех чисел самое большое?

//  Console.WriteLine("Введите число: ");
//  int num1 = Convert.ToInt32(Console.ReadLine());
 
//  Console.WriteLine("Введите число: ");
//  int num2 = Convert.ToInt32(Console.ReadLine());
 
//  Console.WriteLine("Введите число: ");
//  int num3 = Convert.ToInt32(Console.ReadLine());

//  int max = num1;

//     if(num2 > max) {

//     max = num2;
//     }

//     if (num3 > max) {

//     max = num3;
 
//      }
//      Console.WriteLine("из трех введеных чесел большее " + max);
  


//   // Семинар 1, Задача 6
// // Являеться ли число четным?

//  Console.WriteLine("Введите число: ");
//  int num1 = Convert.ToInt32(Console.ReadLine());
 
//     if (num1 % 2 == 0) {  
 
//     Console.WriteLine("число четное");
//     }
//     else {
//     Console.WriteLine("число нечетное");    
//     }        
 


// // Семинар 1, Задача 8
// // Вывести все четные числа до введенного в num

//  Console.WriteLine("Введите число: ");
//  int num1 = Convert.ToInt32(Console.ReadLine());
 
//  int count = 0;
//  Console.WriteLine();

//  while (count < num1) {
//     count +=1;

//     if (count % 2 == 0) {  
//     Console.WriteLine(count);
//     }
//  }