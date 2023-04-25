using System;


namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> numList = new List<int>();

            int enterNum = -9999999;

            Console.WriteLine("Continue entering numbers until you are satisfied and once you're done enter in 0.");

            while(enterNum != 0)
            {
                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();
                enterNum = int.Parse(userInput);
                

                if (enterNum != 0)
                {
                    numList.Add(enterNum);
                }
            }

            int sum = 0;
            foreach(int number in numList)
            {
                sum += number;
            }

            Console.WriteLine($"The sum of the numbers in the list is: {sum}");

            float average = ((float)sum / numList.Count);

            Console.WriteLine($"The average is: {average}");

            int max = numList[0];

            foreach(int number in numList)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            
            Console.WriteLine($"The maximum is: {max}");
        }
    }
}