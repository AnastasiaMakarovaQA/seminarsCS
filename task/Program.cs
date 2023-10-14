// int Quater(int num){
//     int res = num * num;
//     return res;
// }
// Console.WriteLine("Enter the number:");
// int number = Convert.ToInt32(Console.ReadLine());
// int quat = Quater();
// quat += 2;
// Console.WriteLine($"Your numb with quater is {quat}");

// void MaxDigit(int num){
//    int digit1 = num / 10;
//     int digit2 = num % 10;
//     if (digit1 > digit2){
//     Console.WriteLine($"The biggest digit is {digit1}");
//     }
//     else{
//        Console.WriteLine($"The biggest digit is {digit2}");
//     }
// }

// int number = new Random().Next(10, 100);
// Console.WriteLine($"Your number is {number}");
// MaxDigit(number);

// void CutNumber(int num = 0){
//     if (num < 100 || num > 999){
//        Console.WriteLine("Error");
//     } 
//     else
//     {
//         int first_digit = num / 100;
//         int last_digit = num % 10;
//        int new_num = (first_digit * 10) + last_digit;
//        Console.WriteLine($"New num is {new_num}");
//    }
// }
// Console.WriteLine("Enter numb:");
// int number = Convert.ToInt32(Console.ReadLine());
// CutNumber(number);

// bool Check(int number){
//    if (number % 7 == 0 && number % 23 == 0)
//    return true;
//     else
//     {
//        return false;
//     }
// }

// Console.WriteLine("Enter the numb:");
// int num = Convert.ToInt32(Console.ReadLine());
// bool flag = Check(num);
// if (flag){
//    Console.WriteLine(flag);
// }
// else
// {
//    Console.WriteLine(flag);
// }


// bool AIsSquareOfB(int num1, int num2){
//     if (num1 == num2 * num2 || num2 == num1 * num1){
//         return true;
//     }
//     else {
//         return false;
//     }
// }
// Console.WriteLine("Input first numb:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second numb:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// bool isSquare = AIsSquareOfB(num1, num2);
// Console.WriteLine(isSquare);

// void CheckCrat(int val1, int val2){
//     if (val2 % val1 ==0)
//     {
//         Console.WriteLine("Number 2 is crat to number 1");
//     }
//     else
//     {
//         int res = val2 % val1;
//         Console.WriteLine($"Number is not crat, {res}");
//     }
// }

// Console.WriteLine("Enter first num:");
// int val1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second num:");
// int val2 = Convert.ToInt32(Console.ReadLine());
// if (val1 == 0)
// {
//     Console.WriteLine("Error");
// }
// else
// {
//     CheckCrat(val1, val2);
// }

//Виды методов. Метод 1
// void Method1()
// {
//     Console.WriteLine("Автор...")
// }
// Method1();

//Метод 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

//Метод21
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count: 4);

//Метод 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

//Метод 4
// string Method4(int count, string text)
// {
// int i = 0;
// string result = String.Empty;
// while (i < count)
// {
//     result = result + text;
//     i++;
// }
// return result;
// }
//  string res = Method4(10, "asdf");
//  Console.WriteLine(res);

//Цикл for
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//         {
//             result = result + text;
//         }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);

//Метод for

// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// задача на изменение символов
// string text = "– Я думаю, – сказал князь, улыбаясь, – что,"
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля. "
// + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//    string result =  String.Empty;
// int length = text.Length;
// for (int i = 0; i < length; i++)
// {
//     if (text[i] == oldValue) result = result + $"{newValue}";
//     else result = result + $"{text[i]}";
// }

//    return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);

// int Quat (int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         return 1;
//     }
//     else if (x > 0 && y < 0)
//     {
//         return 4;
//     }
//     else if (x < 0 && y > 0)
//     {
//         return 2;
//     }
//     else 
//     {
//         return 3;
//     }
// }

// Console.WriteLine("Enter x point: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y point: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x!=0 && y!=0){
//     int quater = Quat(x,y);
//     Console.WriteLine($"the number of quater is {quater}");

// }
// else{
//     Console.WriteLine($"the number is not on quater");
// }

// double Dist(int x1, int y1, int x2, int y2){
//     int x = x2 - x1;
//     int y = y2 - y1;
//     double res = Math.Round(Math.Sqrt(x * x + y * y),3);
//     return res;
// }
// Console.WriteLine("Enter x1 point: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y1 point: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter x2 point: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y2 point: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Distance between points is {Dist(x1, y1, x2, y2)}");

// void Square(int num){
//     for (int i = 1; i <= num; i++){
// Console.Write($"{i * i} ");
//     }
// }
// Console.WriteLine("Enter a number: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// if(numb < 0){
// numb *= (-1);
// }
// else if (numb == 0){
//     Console.WriteLine("Wrong number");
// }
// Square(numb);

//1.2321   123.21



// bool Pal(int num){

// int num1 = num / 10000; //1
// int num5 = num % 10; //1
// int num2 = num / 1000 - num1 * 10; //2 
// int num4 = num % 100 / 10; //2
// if (num <10000 || num > 99999){
//         Console.WriteLine("Error");
//     }
// if (num1 == num5 && num2 == num4){

//     Console.WriteLine("true");
//     return true;
// }
// else {
//     Console.WriteLine("false");
//     return false;
// }
// }

// Console.WriteLine("Enter 5 character number: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// Pal(numb);


// void Square(int num){
//     for (int i = 1; i <= num; i++){
// Console.WriteLine($"{i * i * i} ");
//     }
// }
// Console.Write("N = ");
// int numb = Convert.ToInt32(Console.ReadLine());
// if(numb < 0){
// numb *= (-1);
// }
// else if (numb == 0){
//     Console.WriteLine("Wrong number");
// }
// Square(numb);

// double Dist(int x1, int x2, int x3, int y1, int y2, int y3){
//     int x = y1 - x1;
//     int y = y2 - x2;
//     int z = y3 - x3;
//     double res = Math.Round(Math.Sqrt(x * x + y * y + z * z),2);
//     return res;
// }
// Console.WriteLine("Enter x1 point: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter x2 point: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter x3 point: ");
// int x3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y1 point: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y2 point: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y3 point: ");
// int y3 = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine($"Distance between points is {Dist(x1, x2, x3, y1, y2, y3)}");

// Напиши программу, которая на вход принимает число (А) и выдает сумму чисел от 1 до А.
// using System.IO.Compression;

// void SumNumb(int numb){
// int res = 0;
// for (int i = 0; i <=numb; i++)
// {
//  res += i;   
// }
// Console.WriteLine($"Your sum from 1 to {numb} is {res}");
// }

// Console.WriteLine("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// SumNumb(num);

// void NumInDec(int numb){
//     int count = 0;
//     while (numb!= 0){
//         numb/= 10;
//         count++;
//     }
//     Console.WriteLine($"Count of number is {count}");
// }
// Console.WriteLine("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// NumInDec(num);

// напишите программу, которая на вход принимает число N и выдвет произведение от 1 до N.
// void Fact(int n){
//     if (n == 1){
//         Console.WriteLine($"Your composition is 1");
//     }
//     else {
//         double res = 1;
//         for (int i = 1; i <= n; i++){
//             res *= i;
//         }
//         Console.WriteLine($"Your composition is {res}");
//     }
// }
// Console.WriteLine("Enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Fact(num);

// Напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке

// int[] CreateNewArray()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < 8; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }
// ShowArray(CreateNewArray());

// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

// int [] CreateRandomArray(int min, int max, int size)
// {
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void CalcPosNeg(int[] array){
// int sumPos = 0;
// int sumNeg = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < 1)
//     {
//         sumNeg += array[i];
//     }
//     else
//     {
//         sumPos += array[i];
//     }
// }
// Console.WriteLine($"Summ of negative is {sumNeg} and summ of positive is {sumPos}");
// }

// Console.WriteLine("Enter min of array val:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max of array val:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter size of array val:");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateRandomArray(min, max, size);
// ShowArray(newArray);
// CalcPosNeg(newArray); 

//Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int [] CreateRandomArray(int min, int max, int size)
// {
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void ReverseArr(int [] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= (-1);
//     }
//     ShowArray(array);
// }

// Console.WriteLine("Enter min of array val:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max of array val:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter size of array val:");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateRandomArray(min, max, size);
// ShowArray(newArray);
// ReverseArr(newArray); 

// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

// int [] CreateRandomArray(int min, int max, int size)
// {
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// bool IsPresent(int [] array, int num){
//     bool flag = false;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// Console.WriteLine("Enter min of array val:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max of array val:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter size of array val:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter numb to search:");
// int numb = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateRandomArray(min, max, size);
// ShowArray(newArray);
// bool flag = IsPresent(newArray, numb);
// Console.WriteLine($"Element {numb} in array is {flag}");

// Задача 35: Задайте одномерный массив из 23 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

// int [] CreateRandomArray(int min, int max, int size)
// {
//     int [] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void ShowSumInRange(int [] array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 9 && array[i] < 100){
//             count++;
//         }
//     }
//     Console.WriteLine($"Count of numbers in range [10,99] is {count}");
// }

// Console.WriteLine("Enter min of array val:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max of array val:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter size of array val:");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateRandomArray(min, max, size);
// ShowArray(newArray);
// ShowSumInRange(newArray);

// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// int [] CreateArray(int min, int max, int size){
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//      array[i] = new Random().Next(min, max+1);   
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//      Console.Write($"{array[i]} ");
//     }
// }

// int [] ReverseArray(int [] array){
//     int sizeArr = array.Length;
//     for (int i = 0; i < sizeArr/2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[sizeArr-1-i];
//         array[sizeArr-1-i] = temp;
//     }
//     return array;
// }
// Console.WriteLine("Enter min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] newArray = CreateArray(min, max, size);
// ShowArray(newArray);
// Console.WriteLine();
// ShowArray(ReverseArray(newArray));

// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// bool IsTriangle(int a, int b, int c){
//     return a+b>c && b+c>a && c+a>b;
// }

// Console.WriteLine("Enter first part: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second part: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter third part: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (IsTriangle(a,b,c))
// {
//     Console.WriteLine($"Triangle is possible!");
// }
// else{
//     Console.WriteLine($"Triangle is impossible.");
// }


// Метод для двумерных массивов
// int [,] Create2dArray(int min, int max, int row, int col){
//     int [,] array = new int [row, col];
//     for (int i = 0; i < row; i++)
//     {
//      for (int j = 0; j < col; j++)
//      {
//         array[i,j] = new Random().Next(min, max+1);
//      }   
//     }
//     return array;
// }

// void Show2dArray(int [,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Enter number of rows in array: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of colums in array: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min value in array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max value in array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int [,] array = Create2dArray(min, max, row, col);
// Show2dArray(array);


// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// int [,] Create2dArrayWithIndex(int row, int col){
//     int [,] array = new int [row, col];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             array[i,j] = i + j;
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Enter number of rows in array: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of colums in array: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min value in array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max value in array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int [,] array = Create2dArrayWithIndex(row, col);
// Show2dArray(array);


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// int [,] Create2dArray(int min, int max, int row, int col){
//     int [,] array = new int [row, col];
//     for (int i = 0; i < row; i++)
//     {
//      for (int j = 0; j < col; j++)
//      {
//         array[i,j] = new Random().Next(min, max+1);
//      }   
//     }
//     return array;
// }

// void Show2dArray(int [,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] ChangeArray(int [,] array){
//     for (int i = 0; i < array.GetLength(0); i=+2)
//     {
//         for (int j = 0; j < array.GetLength(1); j=+2)
//         {
//             array[i,j] *= array[i,j];
//         }
//          Console.WriteLine();
//     }
//     return array;
// }

// Console.WriteLine("Enter number of rows in array: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of colums in array: ");
// int col = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min value in array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max value in array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int [,] array = Create2dArray(min, max, row, col);
// Show2dArray(array);
// Console.WriteLine();
// int [,] changedArr = ChangeArray(array);
// Show2dArray(changedArr);
// Console.WriteLine();
// Show2dArray(array);

// Задайте значение N. Напишите программу, которая выдает все натуральные числа из промежутка от 1 до N

// void ShowNumbers(int n){
//     if (n>1){
//         ShowNumbers(n-1);
//     }
//     Console.Write($"{n} ");
// }

// ShowNumbers(5);

//найдите значения M и N. Напишите программу, которая выведет все натуральные числа от M до N

// void ShowValuesRec(int n, int m){
//     if (Math.Max(m,n) != Math.Min(m,n)){
//         ShowValuesRec(Math.Max(n,m), Math.Min(m,n)+1);
//     }
//         Console.Write($"{Math.Min(m,n)} ");
// }

// Console.WriteLine("Enter n numb: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter m numb: ");
// int m = Convert.ToInt32(Console.ReadLine());

// ShowValuesRec(Math.Min(n,m), Math.Max(n,m));

int SumDigits(int n)
{
    n = Math.Abs(n);
    if(n>10)
    {
        return SumDigits(n / 10) + n % 10;
    }
    else
    {
        return n;
    }
}

Console.WriteLine("Enter M numb");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits of number {M} is {SumDigits(M)}.");