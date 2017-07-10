using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods are a tool for us to create reusable pieces of code.
            //Methods are a way of collecting a series of instructions and then call  them
            //when we need them.

            //Methods are ALWAYS part of a class. Methods are ALWAYS children of classes.
            //This means a method will NEVER be created inside another method or member of the class.
            //However, methods are frequently CALLED inside of another class or method.


            //Console.WriteLine("Hello. Please enter the first number to be added.");
            //int numberOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second number to be added.");
            //int numberTwo = int.Parse(Console.ReadLine());

            //int answer = Add(numberOne, numberTwo);

            //Console.WriteLine("The sum of your two numbers is " + answer);

            //RobotWarning("Will Robinson");
            //Useless();
            //FavoriteFood("orange", "pizza");
            //RetirementCalculator(35);

            //string myBirthMonth = "September";
            //string myFriendBirthMonth = "December";
            //string myVehicle = Vehicle(myBirthMonth);
            //string myFriendVehicle = Vehicle(myFriendBirthMonth);

            //Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle {1}.", myVehicle, myFriendVehicle);

            double hoursWorked = 42.3d;
            double hourlyWage = 12.50d;

            Console.WriteLine("Your monthly wage is {0}.", WageCalculator(hoursWorked, hourlyWage));









        }

        //Method header
        //Access modifier - Return Type - Method Name (in Pascal Case) - Parentheses (sometimes with parameters)
        public static int Add(int firstNumber, int secondNumber)
        {
            //Method body
            //A complete method - header and body - is called a method declaration

            int sum = firstNumber + secondNumber;

            return sum;
            //The "return" keyword takes whatever value is determined by using this method
            //and send that value back to where I call my method
        }
        //If you have a method that does not have a return value, you would use the keyword
        //"void". When we have a "void" return type we DON'T need to use the keyword "return"

        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name + "!!");
        }

        public static void Useless()
        {
            Console.WriteLine("Blah blah blah");
        }



        public static string Vehicle(string birthMonth)
        {
            string vehicleFortune;
            if (birthMonth.ToUpper() == "SEPTEMBER" || birthMonth.ToUpper() == "OCTOBER")
            {
                vehicleFortune = "Hoverboard";
            }
            else
            {
                vehicleFortune = "Web swinging";
            }

            return vehicleFortune;
        }

        //Create a method called FavoriteFood
        public static void FavoriteFood(string name, string food)
        {
            Console.WriteLine(name + "{0}'s favorite food is {1}" + food);
        }
        //It should take two string parameters. One representing a name, and the other representing a favorite food
        //The return type should be void
        //The method should concatenate

        //Create a method called RetirementCalculator
        //It should take an int as a parameter representing the user's age
        //the method should calculate how many more years until the user retires using 65 as the age of retirement.
        //The return type should be void.
        //Once it calculates the user's retirement age it should print
        //"The user will retire in X years" where X represents the value that was calculated
        public static void RetirementCalculator(int userAge)
        {
            int retirement = 65 - userAge;
            Console.WriteLine($"The user will retire in {retirement} years");
        }



        public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
        {
            //This method should calculate the monthly wage
            double monthlyWage = (hoursWorkedWeekly * 52 * hourlyWage) / 12;
            return monthlyWage;
        }


    }
}
