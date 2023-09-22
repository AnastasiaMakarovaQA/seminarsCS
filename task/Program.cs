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

double Dist(int x1, int x2, int x3, int y1, int y2, int y3){
    int x = y1 - x1;
    int y = y2 - x2;
    int z = y3 - x3;
    double res = Math.Round(Math.Sqrt(x * x + y * y + z * z),2);
    return res;
}
Console.WriteLine("Enter x1 point: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter x2 point: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter x3 point: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y1 point: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y2 point: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y3 point: ");
int y3 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Distance between points is {Dist(x1, x2, x3, y1, y2, y3)}");