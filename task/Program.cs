int Quater(int num){
    int res = num * num;
    return res;
}
Console.WriteLine("Enter the number:");
int number = Convert.ToInt32(Console.ReadLine());
int quat = Quater();
quat += 2;
Console.WriteLine($"Your numb with quater is {quat}");

void MaxDigit(int num){
   int digit1 = num / 10;
    int digit2 = num % 10;
    if (digit1 > digit2){
    Console.WriteLine($"The biggest digit is {digit1}");
    }
    else{
       Console.WriteLine($"The biggest digit is {digit2}");
    }
}

int number = new Random().Next(10, 100);
Console.WriteLine($"Your number is {number}");
MaxDigit(number);

void CutNumber(int num = 0){
    if (num < 100 || num > 999){
       Console.WriteLine("Error");
    } 
    else
    {
        int first_digit = num / 100;
        int last_digit = num % 10;
       int new_num = (first_digit * 10) + last_digit;
       Console.WriteLine($"New num is {new_num}");
   }
}
Console.WriteLine("Enter numb:");
int number = Convert.ToInt32(Console.ReadLine());
CutNumber(number);

bool Check(int number){
   if (number % 7 == 0 && number % 23 == 0)
   return true;
    else
    {
       return false;
    }
}

Console.WriteLine("Enter the numb:");
int num = Convert.ToInt32(Console.ReadLine());
bool flag = Check(num);
if (flag){
   Console.WriteLine(flag);
}
else
{
   Console.WriteLine(flag);
}


bool AIsSquareOfB(int num1, int num2){
    if (num1 == num2 * num2 || num2 == num1 * num1){
        return true;
    }
    else {
        return false;
    }
}
Console.WriteLine("Input first numb:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second numb:");
int num2 = Convert.ToInt32(Console.ReadLine());
bool isSquare = AIsSquareOfB(num1, num2);
Console.WriteLine(isSquare);

void CheckCrat(int val1, int val2){
    if (val2 % val1 ==0)
    {
        Console.WriteLine("Number 2 is crat to number 1");
    }
    else
    {
        int res = val2 % val1;
        Console.WriteLine($"Number is not crat, {res}");
    }
}

Console.WriteLine("Enter first num:");
int val1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second num:");
int val2 = Convert.ToInt32(Console.ReadLine());
if (val1 == 0)
{
    Console.WriteLine("Error");
}
else
{
    CheckCrat(val1, val2);
}