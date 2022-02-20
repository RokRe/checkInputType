using System;

namespace foreachAndSwitchChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean valid = false;
            string inputValueType = String.Empty;
            bool validInput;

            while(true)
            {
                Console.WriteLine("\nEnter a value:");
            string inputValue = Console.ReadLine();
            
                Console.WriteLine("Which data type is your input? \n Press 1 for String \n Press 2 for Integer \n Press 3 for boolean");

                Console.Write("Enter:");
                // int inputType = Convert.ToInt32(Console.ReadLine());
                int inputType;
                validInput = int.TryParse(Console.ReadLine(), out inputType);

                if (validInput && (inputType<4 && inputType > 0))
                {
                    switch (inputType)
                    {
                        case 1:

                            valid = isAlphabetic(inputValue);
                            inputValueType = "string";
                            break;

                        case 2:
                            int retValue;
                            valid = int.TryParse(inputValue, out retValue);
                            inputValueType = "integer";
                            break;

                        case 3:
                            bool retFlag = false;
                            valid = bool.TryParse(inputValue, out retFlag);
                            inputValueType = "boolean";
                            break;

                        default:
                            Console.WriteLine("Input wrong");
                            break;
                    }
                    Console.WriteLine("You have entered {0}", inputValue);
                    if (valid)
                    {
                        Console.WriteLine("It is valid {0}", inputValueType);
                    }
                   
                    else
                    {
                        Console.WriteLine("It is an invalid {0} entry", inputValueType);
                    }

                }
                else
                {
                        Console.WriteLine("Your entry was wrong. Try again.");
                }

            }
        }

        static bool isAlphabetic (string value)
        {
            foreach(char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }
    }
}
