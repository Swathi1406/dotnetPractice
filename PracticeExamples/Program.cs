// See https://aka.ms/new-console-template for more information
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using PracticeExamples;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

// FACTORIAL (n! = n*(n-1)...1)  


//int input = 3;
//long output = calFactorial(input );

//Console.WriteLine($"Factorial of {input} is : {output}");

//static long calFactorial(int n)
//{
//    if (n == 0 || n == 1)
//    {
//        return 1;
//    }
//    else {
//        return n * calFactorial(n-1);
//    }
//}





//SWAPPING of 2 numbers without using temp variable

//int a = 4;
//int b = 6;
//a = a + b;
//b = a - b;
//a = a - b;

//Console.WriteLine($"a : {a}, b={b}");





//Reversing a String , SWATHI to IHTAWS

//string input = "abfgh";
//string output = reverseString(input);

//static string reverseString(string n)
//{
//    char[] cArray = n.ToCharArray();
//    int min = 0;
//    int max = cArray.Length - 1;
//    while (min < max)
//    {
//        char temp = cArray[min];
//        cArray[min] = cArray[max];
//        cArray[max] = temp;
//        min++;
//        max--;
//    }
//    return new string(cArray );
//}

//Console.WriteLine($"reverse string : {output }");




//Is PRIME number or not (2,3,5,7,11...)

//int input = 10;
//static bool isprime(int n)
//{
//    if (n <= 1)
//    {
//        return false;
//    }

//    for (int i=2;i<=Math.Sqrt (n);i++)
//    {
//        if (n%i == 0)
//        {
//            return false;
//        }
//    }

//    return true;
//}

//if (isprime(input))
//{
//    Console.WriteLine($"{input} is prime number");
//}
//else
//{
//    Console.WriteLine($"{input} is not prime number");
//}



//Palindrome

//int input = 121;

//static bool isPalindrome(int n)
//{
//    int original = n;
//    int reverse = 0;

//    while (n > 0)
//    {
//        int digit = n % 10;//3,2,1
//        reverse = reverse * 10 + digit;//3,32,321
//        n = n / 10;//12,1,0
//    }
//    return original == reverse;
//}
//if (isPalindrome(input))
//{
//    Console.WriteLine($"{input} is  polindrome");
//}
//else {
//    Console.WriteLine($"{input} is not polindrome");
//}
// int a = 10;
//int b = 20;
//int c = a + b;
//Console.WriteLine($"Final result is : {c} .....");

////Array sorting
//string[] cars = { "xyz","abc"};
// Array.Sort(cars);
//Console.WriteLine(cars);

//foreach (string index in cars)
//{
//    Console.WriteLine(index);
//}

////Lambda Expression using List

//List<int> numbers = new List<int> { 1,2,3,4,5};
//var evenNo = numbers.Where(n => n%2 == 0);
//foreach (var num in evenNo ) {
//    Console.WriteLine($"even number is :{num}");
//}

//DIContainer.RegisterServices();
//var myService = DIContainer.ServiceProvider.GetRequiredService<ILoggerService>();

//myService.logError("I am from main");

//Product p = new Product(myService);



//final Practice


//array sorting - {5,2,3,1,} --{1,2,3,5}

//print prime numbers from 1 to 50, 2,3,5,7

// 3,6,9 - fizz   5,10 - buzz    15-fizzbuzz


int[] input = { 8,-1,0,5, 1, 3 ,2,9};


static int[] sortAsc(int[] arr, int a)
{
    int n = arr.Length;
    if (a == 0)
    {
        for (int i = 0; i < (n - 1); i++)
        {
            for (int j = 0; j < (n - 1); j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
        }
    }
    else {
        for (int i = 0; i < (n - 1); i++)
        {
            for (int j = 0; j < (n - 1); j++)
                if (arr[j] < arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
        }
    }
        return arr;
    

}

//Console.Write("{" +string.Join(',',sortAsc(input,1))+ "}");

//IList <student> studentList = new List<student>()
//{
//new student(){ Id = 1, Name = "John",  Age = 16, Grade =1},
//new student(){ Id = 2, Name = "Ram",  Age = 20, Grade =1},
//new student(){ Id = 3, Name = "Sam",  Age = 18, Grade =2}
//};

//var studentNames = studentList.Where(s => s.Age > 16)
//                                .Select(s => s.Name);
//foreach (string name in studentNames)
//{
//    //Console.WriteLine(name);
//}


//var client = new MongoClient("mongodb://localhost:27017");

//var database = client.GetDatabase("test");

//var collection = database.GetCollection<UserData>("users");

//var userList = GetUserData(collection);

//static List<UserData> GetUserData(IMongoCollection <UserData> collection )
//{
//    var filter = Builders<UserData>.Filter.Empty;
//    var userList = collection.Find(filter).ToList();
//    return userList;
//}


var client = new MongoClient("mongodb://localhost:27017");

var database = client.GetDatabase("test");

var collection = database.GetCollection<UserData>("users");

var userList = GetUserData(collection);

static List<UserData> GetUserData(IMongoCollection<UserData> collection )
{
    var filter = Builders<UserData>.Filter.Empty;
    var userList = collection.Find(filter).ToList ();
    return userList;

}

// print the names
foreach (UserData user in userList)
{
    Console.WriteLine(user.name);
}