using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using HardestChallengeEver.Helpers;

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
            var date = DateTime.UtcNow;
            var userInfo = new UserInfo();
            var newGoal = new Goals();
            var entry = new Entry();
            var moodChoice = UserMood.Unanswered;
            var finished = new Finish();

            Console.Write("What is your name: ");
            userInfo.Name = Console.ReadLine();

            //var savedDate = $"date:{date}";
            //var savedMood = $"mood:{(int) moodChoice}";

            //var whatToSaveToFile = $"{savedDate}%20%{savedMood}";

            // Goal = "I love this information, especially since I can use the comma!"
            // WriteToFile(fileLocation, whatToSaveToFile);

            // FileText = "date:2019/04/25%20%mood:1";

            while (true)
            {
                Console.Clear();
                // Return User Info
                Console.WriteLine($"Hello {userInfo.Name}!\n");
                Console.WriteLine("What would you like to do today?");

                // print out menu choices
                var journalMenuChoices = Enum.GetValues(typeof(JournalMenu));

                foreach (var value in journalMenuChoices)
                {
                    Console.WriteLine($"{(int)value}: {value.ToString().ConvertToCamelCase()}");
                }
                int choice = Convert.ToInt32(Console.ReadLine());
                // return name
                Console.WriteLine("\n");
                Console.WriteLine($"Your name is: {userInfo.Name}\n");

                // mood choice
                Console.WriteLine($"Your mood is: {moodChoice}\n");

                // return goal
                Console.WriteLine($"Your goal for today is: {newGoal.Goal}\n");


                // return new entry
                Console.WriteLine("Today is " + date + $" and this is what you wrote: {entry.NewEntry}\n");

                // menu choice
                Console.Write("Please select your choice: ");
                var menuChoice = Console.ReadLine();
                var selectedMenuOption = Enum.Parse<JournalMenu>(menuChoice);
                Console.WriteLine($"You chose {Enum.Parse<JournalMenu>(menuChoice).ToString().ConvertToCamelCase()}\n");


                if (selectedMenuOption == JournalMenu.UpdateName)
                {
                    userInfo.Name = GetNameFromUser(userInfo.Name);
                }
                else if (selectedMenuOption == JournalMenu.Mood)
                {
                    moodChoice = GetMood();
                }
                else if (selectedMenuOption == JournalMenu.SetGoal)
                {
                    newGoal.Goal = GetGoalForDay();
                }
                else if (selectedMenuOption == JournalMenu.NewEntry)
                {
                    entry.NewEntry = GetNewEntryFromUser();
                }
                else if (selectedMenuOption == JournalMenu.SaveCurrentDay)
                {
                    entry.SaveEntry = SaveNewEntry();
                }
                else if (selectedMenuOption == JournalMenu.LoadPreviousEntry)
                {
                    entry.PreviousEntry = PreviousEntry();
                }
                else if (selectedMenuOption == JournalMenu.EditPreviousEntry)
                {
                    // open and edit previous entry
                    // add edit option to LoadPreviousEntry?
                }
                else if (selectedMenuOption == JournalMenu.ExitJournal)
                {
                    finished.EndToday = ExitJournal();
                }
            }
        }

        public string GetNameFromUser(string currentName)
        {
            Console.WriteLine(
                $"Your current name is {currentName}, what would you like your new name to be?");
            return Console.ReadLine();
        }

        public UserMood GetMood()
        {
            // instantiate mood list
            var moodMenuChoices = Enum.GetValues(typeof(UserMood));

            // print mood list
            foreach (var value in moodMenuChoices)
            {
                Console.WriteLine($"{(int)value}: {value.ToString().ConvertToCamelCase()}");
            }

            Console.WriteLine("Please select your mood choice: ");
            var userInput = Console.ReadLine();
            var selectedMood = Enum.Parse<UserMood>(userInput);
            return selectedMood;
        }

        public string GetGoalForDay()
        {
            Console.WriteLine("What goal did you have in mind?");
            return Console.ReadLine();
        }

        public string GetNewEntryFromUser()
        {
            Console.WriteLine("What would you like to write about?");
            return Console.ReadLine();
            // would you like to save?
        }

        public string SaveNewEntry()
        {
  
            Console.WriteLine("Your entry has been saved!");
            return Console.ReadLine();

        }

        public string PreviousEntry()
        {
            Console.WriteLine("Here is your previous entry.");
            return Console.ReadLine();
        }

        public void ExitJournal()
        {
            //Console.WriteLine("Goodbye!");
            var exitCode = Environment.ExitCode;
        }
    }
}
