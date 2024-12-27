namespace Assignment05Basic
{
    internal class Program
    {
        #region Question1 Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.



        #region 1-Passing By Value
        //static void Swap(int x , int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        #endregion

        #region 2-Passing By Reference
        //static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion

        #endregion

        #region Question2 Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example


        #region 1-Passing By Value
        //static void Func1(int[] arr)
        //{
        //    if(arr == null)
        //    {
        //        return;
        //    }
        //    //arr[0] = 100;

        //    arr = new int[] { 4,5,6,7 };

        //}

        #endregion

        #region 2-Passing By Reference
        //static void Func2(ref int[] arr)
        //{
        //    if (arr == null)
        //    {
        //        return;
        //    }
        //    //arr[0] = 100;

        //    arr = new int[] { 4, 5, 6, 7 };


        //}
        #endregion

        #endregion

        #region Question 3 Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

        //static void Sum_Sub(int num1, int num2, out int sum, out int sub)
        //{
        //    sum = num1+ num2;
        //    sub = num1 - num2;
        //}

        #endregion

        #region Question 4 Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //25 --> 2+5 = 7

        //static int SumOfDigits(int n)
        //{
        //    int sum = 0;

        //    while(n!=0)
        //    {
        //        //25
        //        sum += n % 10;  //5 // 2 ==7
        //        n /= 10; //2 //0
        //    }
        //    return sum;
        //}

        #endregion

        #region Question 5 Create a function named "IsPrime", which receives an integer number and returns true if it is prime, or false if it is not:

        //static bool IsPrime(int n)
        //{
        //    if (n < 2)
        //        return false;
        //    for(int i = 2; i < n; i++)
        //    {
        //        if(n % i ==0)
        //            return false;
        //    }

        //    return true;
        //}



        #endregion

        #region Question 6 Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

        //static void MinMaxArray(int[] arr, ref int max, ref int min)
        //{
        //    if (arr is null)
        //        return;
        //    max = arr[0];
        //    min = arr[0];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if(max < arr[i])
        //            max = arr[i];
        //        else if(min > arr[i])
        //            min = arr[i];
        //    }

        //}


        #endregion

        #region Question 7 Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

        //static long factorial(int num)
        //{
        //    int result = 1;
        //    for(int i = 1; i <= num; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        #endregion

        #region Question 8 Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

        //static string ChangeChar(string text, int index, char a)
        //{
        //    text = text.Remove(index, 1);
        //    text = text.Insert(index, a.ToString());
        //    return text;
        //}


        #endregion
        static void Main(string[] args)
        {
            #region Question 1 Value type parameters

            #region 1-Passing By Value
            //int n1 = 10, n2 = 20;
            //Swap(n1, n2);

            //Console.WriteLine($"1st number = {n1}");
            //Console.WriteLine($"1st number = {n2}");

            #endregion

            #region 2-Passing By Reference
            //int n1 = 10, n2 = 20;
            //Swap(ref n1, ref n2);

            //Console.WriteLine($"1st number = {n1}");
            //Console.WriteLine($"1st number = {n2}");
            #endregion

            #endregion

            #region Question 2 Reference type parameters



            #region 1-Passing By Value
            //int[] numbers = { 0, 1, 2, 3, 4 };
            //Func1(numbers);
            //Console.WriteLine(numbers[0]);
            #endregion

            #region 2-Passing By Reference

            //int[] numbers = { 0, 1, 2, 3, 4 };
            //Func2(ref numbers);
            //Console.WriteLine(numbers[0]);

            #endregion

            #endregion

            #region Question 3
            //try
            //{
            //    bool flag1, flag2;
            //    int n1,n2, sum, sub;

            //    do
            //    {
            //        Console.WriteLine("enter 1st number");
            //        flag1 = int.TryParse(Console.ReadLine(), out n1);

            //        Console.WriteLine("enter 2nd number");
            //        flag2 = int.TryParse(Console.ReadLine(), out n2);
            //    }
            //    while (!(flag1&&flag2));

            //    Sum_Sub(n1, n2 , out sum, out sub);
            //    Console.WriteLine($"sum = {sum}");
            //    Console.WriteLine($"sub = {sub}");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Question 4
            //try
            //{
            //    bool flag1;
            //    int num;
            //    int result = 0;

            //    do
            //    {
            //        Console.WriteLine("enter 1st number");
            //        flag1 = int.TryParse(Console.ReadLine(), out num);

            //    }
            //    while (!flag1);

            //    result = SumOfDigits(num);
            //    Console.WriteLine(result);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Question 5
            //try
            //{
            //    bool flag1;
            //    int num;
            //    bool result;


            //    do
            //    {
            //        Console.WriteLine("enter a number");
            //        flag1 = int.TryParse(Console.ReadLine(), out num);

            //    }
            //    while (!flag1);

            //    result = IsPrime(num);
            //    Console.WriteLine(result);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Question 6

            //try
            //{
            //    bool flag1;
            //    bool flag2;
            //    int size,min = 0,max = 0;
            //    int[] numbers;


            //    do
            //    {
            //        Console.WriteLine("enter size of array");
            //        flag1 = int.TryParse(Console.ReadLine(), out size);

            //    }
            //    while (!flag1);
            //    numbers= new int[size];

            //    for(int i = 0; i < size; i++)
            //    {
            //        do
            //        {
            //            Console.WriteLine("enter a value");
            //            flag2 = int.TryParse(Console.ReadLine(), out numbers[i]);

            //        }
            //        while (!flag2);
            //    }

            //    MinMaxArray ( numbers, ref max, ref min);
            //    Console.WriteLine($"max = {max}");
            //    Console.WriteLine($"min = {min}");


            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Question 7

            //int number;
            //long fact=0;
            //Console.WriteLine("enter a number");
            // number = int.Parse(Console.ReadLine());
            //fact = factorial(number);
            //Console.WriteLine($"factorial = {fact}");




            #endregion

            #region Question 8

            //Console.WriteLine("enter a string");
            //string word = Console.ReadLine();

            //char letter;
            //int index;
            //string result;

            //Console.WriteLine("enter index");
            //index = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter a letter");
            //letter = char.Parse(Console.ReadLine());

            //result = ChangeChar(word, index, letter);
            //Console.WriteLine($" new word = {result}"); 


            #endregion
        }
    }
}
