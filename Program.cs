using System;

//Console.WriteLine("Input your name");
//string user = Console.ReadLine();
//Console.WriteLine("Your username is: " + user);

//string fullName = "Emmanuel Oluwatosin Ikpefua";
//int charPo = fullName.IndexOf("O");
//string getMiddleAndLastName = fullName.Substring(charPo);
//Console.WriteLine(getMiddleAndLastName);

// USER INPUT & NUMBER
//Console.WriteLine("What is your house number?");
//int getHouseNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("My house number is " + getHouseNum + " Gbagada Estate.");

//int highestNum = 32;
//if(highestNum > 100 || )
//{
//    Console.WriteLine("Yes number 32 is greater");
//}
//else
//{
//    Console.WriteLine("32 cant be greater than 100. 100 is the greatest number");
//}

// Tenary Operator
//int timeIs = 12;
//string getTime = (timeIs <= 11) ? "Good evening" : "Go To Sleep";
//Console.WriteLine(getTime);

// Type Casting; This assign a value of a data type to another
//Implicit Casting: This convert smaller data type to a lager type, e.g ( char -> int -> long -> float -> double )

int intNum = 9;
double doubleNum = intNum;
Console.WriteLine("intNum is: " + intNum);
Console.WriteLine("doubleNum is: " + doubleNum);
double getDoubleNum = intNum * 20;
Console.WriteLine("getDoubleNum is:" + getDoubleNum);

// Explicit casting: This convert lager data type to a small type e.g ( double -> float -> long -> int -> char ),
// this type of casting is done manually, by incerting the data type inside a () in front of the value.
double myDouble = 7.98;
int myInt = (int)myDouble;
Console.WriteLine("MyDouble is: " + myDouble); // 7.98
Console.WriteLine("MyInt is: " + myInt); // 7

// Type Conversion: This is done by using an inbuilt method to change the value or a datatype explicitly, such methods are
//Convert.ToString, Convert.ToBoolean, Convert.ToDouble Convert.ToInt32 (int) Convert.ToInt64 (long); Example is given bellow;
//int getAge = 28;
//double getTime_24 = 12.30;
//bool getAns = true;
//Console.WriteLine("getAge is: " + Convert.ToString(getAge));
//Console.WriteLine("getAge is2: " + Convert.ToDouble(getAge));
//Console.WriteLine("double is: " + Convert.ToInt32(getTime_24));
//Console.WriteLine("bool is: " + Convert.ToString(getAns));

//Console.WriteLine("How old are you?");
//int getAGe = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("I'm " + getAGe + " Years Old");

// SWITCH CASE;
//int day = 5;
//switch (day)
//{
//    case 1:
//        Console.WriteLine("Monday");
//         break;
//    case 2:
//        Console.WriteLine("Teusday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//         break;
//    default:
//        Console.WriteLine("Please inpute a valid day");
//        break;
//}

string superHero = "Bartman";
switch (superHero)
{
    case "Bartman":
        Console.WriteLine("Bartman custome is dark, and he is filty rich");
        break;
    case "Superman":
        Console.WriteLine("super eye vision, red light");
        break;
    case "Green Lantern":
        Console.WriteLine("Weak, and little strength");
        break;
    default:
        Console.WriteLine("No Super Heros From DC was selected");
        break;
}

// WHILE loop; Loops can execute a block of code as long as a specified condition is reached.
// Loops are handy because they save time, reduce errors, and they make code more readable. "While" loop, goes through a block
// of code as long as the condition is true, an example is stated bellow.

int i = 0;
while(i < 7)
{
    Console.WriteLine(i); //0,1,2,3,4,5,6.
    i++;
}

// Do While LOOP;
int i_2 = 12;
do
{
    Console.WriteLine(i_2); // 12,11,10,9,8,7,6,5,4,3,2,1
    i_2--;
}
while (i_2 > 1);


