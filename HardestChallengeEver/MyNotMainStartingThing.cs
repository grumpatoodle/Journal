using System;
using System.Collections.Generic;
using System.Text;

namespace HardestChallengeEver
{
    public class MyNotMainStartingThing
    {
        public void NotMainMethod()
        {
            // Menu
            var listOfInputs = new List<string>();

            string DataFile = "C:/HardestChallengeEver/data.txt";
            string Content = "(Empty File)";

            // Greet the User
            Console.WriteLine("Welcome to your Console Journal!");

            // Instantiating New Variables
            var userInfo = new UserInfo();
            var newGoal = new Goals();

            Console.Write("What is your first name: ");
            userInfo.Name = Console.ReadLine();

            // Return User Info
            Console.WriteLine($"Hello {userInfo.Name}!");

            var date = DateTime.UtcNow;
            // Return Date and Time
            Console.WriteLine("Today is " + date);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do today?");

                var journalMenuChoices = Enum.GetValues(typeof(JournalMenu));

                foreach (var value in journalMenuChoices)
                {
                    Console.WriteLine($"{(int)value}: {value}");
                }

                Console.WriteLine($"Your goal for today is: {newGoal.Goal}");
                Console.Write("Please select your choice: ");
                var choice = Console.ReadLine();
                var selectedOption = Enum.Parse<JournalMenu>(choice);
                //Console.WriteLine($"You chose {(int)Enum.Parse<JournalMenu>(choice)} which is {Enum.Parse<JournalMenu>(choice)}");

                if (selectedOption == JournalMenu.UpdateName)
                {
                    userInfo.Name = GetNameFromUser(userInfo.Name);
                }
                else if (selectedOption == JournalMenu.SetGoal)
                {
                    newGoal.Goal = GetGoalForDay();
                }
            }
        }

        public string GetNameFromUser(string currentName)
        {
            Console.WriteLine(
                $"Your current name is {currentName}, what would you like your new name to be?");
            return Console.ReadLine();
        }

        public string GetGoalForDay()
        {
            Console.WriteLine("What goal did you have in mind?");
            return Console.ReadLine();
        }
    }
}
