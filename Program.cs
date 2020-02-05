using System;
using System.IO;

namespace PracticeDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car myObj1 = new Car();
                Car myObj2 = new Car();
                Console.WriteLine(myObj1.color);
                Console.WriteLine(myObj2.color);

                Vehicle Ford = new Vehicle();
                Ford.model = "Mustang";
                Ford.color = "blue";
                Ford.year = 1969;

                Vehicle Opel = new Vehicle();
                Opel.model = "Astra";
                Opel.color = "white";
                Opel.year = 2005;

                Console.WriteLine(Ford.model);
                Console.WriteLine(Opel.model);

                //Object Members
                Bike myBike = new Bike();
                myBike.fullThrottle();

                //Using constructor
                Truck Man = new Truck("Mustang", "Red", 1969);
                Console.WriteLine(Man.color + " " + Man.year + " " + Man.model);

                //Test for private access modifier
                TestForPrivateAccess myTest = new TestForPrivateAccess();
                Person testPerson = new Person();
                Console.WriteLine("Not able to call the method myTest.model as it is a private variable in its class");
                Console.WriteLine(testPerson.Name);

                //Automatic properties
                Person myPerson = new Person();
                myPerson.Name = "Liam";
                Console.WriteLine(myPerson.Name);

                //Testing for inheritance
                Car myCar = new Car();

                myCar.honk();
                Console.WriteLine(myCar.brand + " " + myCar.modelName);

                //Testing for polymorphism
                Animal myAnimal = new Animal();  // Create a Animal object
                Animal myPig = new Pig();  // Create a Pig object
                Animal myDog = new Dog();  // Create a Dog object

                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();

                //Testing for abstraction
                Crow myCrow = new Crow(); // Create a Pig object
                myCrow.birdSound();  // Call the abstract method
                myCrow.sleep();  // Call the regular method

                //Using Interface
                DemoClass myDemo = new DemoClass();
                myDemo.myMethod();
                myDemo.myOtherMethod();

                //Using enum in a switch condition
                Level myVar = Level.Medium;
                switch (myVar)
                {
                    case Level.Low:
                        Console.WriteLine("Low level");
                        break;
                    case Level.Medium:
                        Console.WriteLine("Medium level");
                        break;
                    case Level.High:
                        Console.WriteLine("High level");
                        break;
                }

                //Writing to a file and reading it
                string writeText = "Hello World!";  // Create a text string
                File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

                string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
                Console.WriteLine(readText);  // Output the content

                //Testing for exceptions
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);

                //Testing the throw keyword
                checkAge(15);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }

            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }

            static void checkAge(int age)
            {
                if (age < 18)
                {
                    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
                }
                else
                {
                    Console.WriteLine("Access granted - You are old enough!");
                }
            }
        }

        enum Level
        {
            Low,
            Medium,
            High
        }

    }

    //Using multiple classes and objects


    //Class Members
    class Vehicle
    {
        public string model;
        public string color;
        public int year;
        public string brand = "Ford";

        // Vehicle method 
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle
    {
        public string color = "red";
        public string modelName = "Mustang";
    }


    class Bike
    {
        string color;                 // field
        int maxSpeed;                 // field
        public void fullThrottle()    // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }


    class Truck
    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public Truck(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }

    //Private access modifier
    class TestForPrivateAccess
    {
        private string model = "Mustang";
    }

    class Person
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    // Abstract class
    abstract class Bird
    {
        // Abstract method (does not have a body)
        public abstract void birdSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Crow : Bird
    {
        public override void birdSound()
        {
            // The body of birdSound() is provided here
            Console.WriteLine("The crow says: kow kow");
        }
    }

    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }


}
