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