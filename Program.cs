using System;

namespace OOP_semester_2_week_1_CA
{

    class program
    {
        public static int IntValidation(string output)
        {
            string num;
            int parsedNum;
            do
            {
                Console.WriteLine($"{output}");
                num = Console.ReadLine();
            } while (!int.TryParse(num, out parsedNum));
            return parsedNum;
        }
        public static double DoubleValidation(string output)
        {
            string num;
            double parsedNum;
            do
            {
                Console.WriteLine($"{output}");
                num = Console.ReadLine();
            } while (!double.TryParse(num, out parsedNum));
            return parsedNum;
        }

        
        static void Main(String[] args)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Wich exercise would you like to execute? or 0 to finish");
                for (int c = 1; c <= 7; c++)
                {
                    Console.WriteLine($"{c}. Question {c}");
                }
                String userInput = Console.ReadLine();

                if (userInput.Equals("0"))
                    {
                    return;
                    }
                    
                
                switch (userInput)
                {
                    case "1":
                        {
                            Exercise1.run();
                            break;
                        }
                    case "2":
                        {
                            Exercise2.run();
                            break;
                        }
                    case "3":
                        {
                            Exercise3.run();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Actually that question does not exist");
                            break;
                        }
                    case "5":
                        {
                            Exercise5.run();
                            break;
                        }
                    case "6":
                        {
                            Exercise6.run();
                            break;
                        }
                    case "7":
                        {
                            Exercise7.run();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("That is not an option");
                            break;
                        }
                }

            } while (flag);

        }



        public class Exercise1
        {
            /*
             *  Question 1
             *  Build a simple calculator. Read in two integers from the user and
             *      • add them together.
             *      • Subtract
             *      • Multiply
             *      • Division (display quotient and remainder separately)
             *   Print the results in a nice output statement. 
             */
            public static int Sum(int num1, int num2)
            {
                return num1 + num2;
            }
            public static int Subtract(int num1, int num2)
            {
                return num1 - num2;
            }
            public static int Multiply(int num1, int num2)
            {
                return num1 * num2;
            }
            public static int[] Divide(int num1, int num2)
            {
                int qutodient = num1 / num2;
                int reminder = num1 % num2;
                int[] result = new int[] { qutodient, reminder };
                return result;
            }



            public static void run()

            {

                bool flag = true;

                do
                {

                    Console.WriteLine("Which operation, would you like to perform");
                    Console.WriteLine("1.Add");
                    Console.WriteLine("2.Subtract");
                    Console.WriteLine("3.Multiply");
                    Console.WriteLine("4.Divide");
                    Console.WriteLine("0.To finish");
                    string userOption = Console.ReadLine();

                    if (userOption.Equals("0"))
                    {
                        return;
                    }

                    int parsedNum1, parsedNum2;
                    parsedNum1 = IntValidation("Input first number");
                    parsedNum2 = IntValidation("Input second number");

                    string output = " ";
                    string result = " ";

                    switch (userOption)
                    {
                        case "1":
                            {
                                output = "adding";
                                result = Sum(parsedNum1, parsedNum2).ToString();
                                break;
                            }
                        case "2":
                            {
                                output = "substracting";
                                result = Subtract(parsedNum1, parsedNum2).ToString();
                                break;
                            }
                        case "3":
                            {
                                output = "multipliying";
                                result = Multiply(parsedNum1, parsedNum2).ToString();
                                break;
                            }
                        case "4":
                            {
                                output = "dividing";
                                int[] preResult = Divide(parsedNum1, parsedNum2);
                                result = preResult[0].ToString() + "." + preResult[1].ToString();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Is not a valid option");
                                break;
                            }

                    }

                    Console.WriteLine($"The result of {output}, {parsedNum1} and {parsedNum2} is: {result}");
                    Console.WriteLine("");
                } while (flag);



            }




        }
        public class Exercise2
        {
            /*
             * Question 2
             * Write a program that asks the user for the length and width of their room.
             * Define a constant that represents the price of carpeting per square foot. Compute and display the cost of carpeting the room.
             */

            public static void run()
            {
                double lenght = DoubleValidation("Input lenght in square foots");
                double width = DoubleValidation("Input width in square foots");

                const double squarePrice = 22.5;
                double price = squarePrice * lenght * width;

                Console.WriteLine($"It would cost {price} to put a carpet in that room");
            }


        }
        public class Exercise3
        {
           /*
            *   Question 3
            *   Write a program that asks the user to enter a total amount of time in minutes only.
            *   Print to the console the same amount of time in hours and minutes.
            */

            public static void run()
            {
                int minutes = IntValidation("Enter the total amount of minutes");
                Console.WriteLine($"hour: {minutes/60}");
                Console.WriteLine($"minutes: {minutes%60}");
            }
        }
        public class Exercise5
        {
            /*
             *  Question 5
             *  Write a program that prompts the user for an hourly pay rate. 
             *  If the value entered is less than $7.50 or greater than $49.00, display an error message, otherwise display a message indicating that the rate is okay
             */
            public static void run()
            {
                double input = DoubleValidation("Enter the hourly rate between $7.50 and $49.00");
                
                if (input>=7.5 && input<=49)
                {
                    Console.WriteLine("The rate is ok");
                }
                else
                {
                    Console.WriteLine("Error, the payrate is not between 7.5 <= payrate < 49");
                }
            }
            



        }
        public class Exercise6
        {
            /*
             *  Question 6
             *  Write a program for a lawn-mowing service. 
             *  The lawn-mowing season lasts 20 weeks. 
             *  The weekly fee for mowing a lot under 400 square feet is $25. 
             *  The fee for a lot that is 400 square feet or more, but under 600 square feet, is $35 per week. 
             *  The fee for a lot that is 600 square feet or over is $50 per week. 
             *  Prompt the user for the length and width of a lawn, and then display the weekly mowing fee, as well as the total fee for the 20-week season.
             */
             public static void run()
            {
                double lenght = DoubleValidation("Input the lenght of your lot");
                double width = DoubleValidation("Input the width of your lot");
                double area = lenght * width;
                int price;
                if (area < 400)
                {
                    price = 25;
                }else if (area<600)
                {
                    price = 35;
                }else
                {
                    price = 50;
                }
                Console.WriteLine($"Lenght:{lenght}, Width:{width}");
                Console.WriteLine($"Mowin weekly fee: {price}, {price*20}");
            }
            

        }
        public class Exercise7
        {
            /*
             *  Question 7
             *  Write a program that generates a random number between 1 and 10. 
             *  Ask a user to guess the random number, then display the random number and a message indicating whether the user's guess was too high, too low, or correct.
             *  
             *  ------HINT-------
             *  You can create a random number that is at least min but less than max using the following statements:
             *      • Random randomGenerator = new Random();
             *      • int randomNumber = randomGenerator.Next(min,max); 1, 11
             */
            public static void run()
            {
                Random rand = new Random();
                int hideNumber = rand.Next(1, 11);
                bool flag = true;
                
                do
                {
                    int input = IntValidation("Input a number between 1 to 10 to guess the hide number");

                    if (input == hideNumber)
                    {
                        Console.WriteLine("Great you find the number");
                        flag = false;
                    }
                    else if (input < hideNumber)
                    {
                        Console.WriteLine("Your number is too low");
                    }
                    else
                    {
                        Console.WriteLine("Your number is too high");
                    }
                } while (flag);

            }

        }

    }
}

