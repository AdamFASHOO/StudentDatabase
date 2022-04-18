public class Program
{
    public static void Main()
    {
        bool goAgain = true;
        while (goAgain == true)
        {
            string[] names = { "Adam", "Ryan", "Ian" };
            string[] hometown = { "Pinckney", "Ann Arbor", "Kalamazoo" };
            string[] favoriteFood = { "pizza", "tacos", "sushi" };

            int studentNumber = int.Parse(GetUserInput("Which of our student's information would you like to display? (1-3)"));
            int index = studentNumber - 1;
            if (index == 0)
            {
                string name = names[0];
                string home = hometown[0];
                string food = favoriteFood[2];

                Console.WriteLine("Student 1: " + name);
                string info = GetUserInput($"Would you like to display {name}'s hometown or favorite food?");
                if (info.ToLower().Contains("home") || info.ToLower().Contains("town"))
                {
                    Console.WriteLine($"{name} is from {home}.");
                }
                else if (info.ToLower().Contains("food"))
                {
                    Console.WriteLine($"{name}'s favorite food is {food}.");
                }
                else
                {
                    Console.WriteLine("I'm sorry, but that wasn't an option. Please try again.");
                    continue;
                }
            }
            else if (index == 1)
            {
                string name = names[1];
                string home = hometown[1];
                string food = favoriteFood[0];

                Console.WriteLine("Student 2: " + name);
                string info = GetUserInput($"Would you like to display {name}'s hometown or favorite food?");
                if (info.ToLower().Contains("home") || info.ToLower().Contains("town"))
                {
                    Console.WriteLine($"{name} is from {home}.");
                }
                else if (info.ToLower().Contains("food"))
                {
                    Console.WriteLine($"{name}'s favorite food is {food}.");
                }
                else
                {
                    Console.WriteLine("I'm sorry, but that wasn't an option. Please try again.");
                    continue;
                }
            }
            else if (index == 2)
            {
                string name = names[2];
                string home = hometown[2];
                string food = favoriteFood[1];

                Console.WriteLine("Student 3: " + name);
                string info = GetUserInput($"Would you like to display {name}'s hometown or favorite food?");
                if (info.ToLower().Contains("home") || info.ToLower().Contains("town"))
                {
                    Console.WriteLine($"{name} is from {home}.");
                }
                else if (info.ToLower().Contains("food"))
                {
                    Console.WriteLine($"{name}'s favorite food is {food}.");
                }
                else
                {
                    Console.WriteLine("I'm sorry, but that wasn't an option. Please try again.");
                    continue;
                }
            }
            else
            {
                if (studentNumber > names.Length || studentNumber < 1)
                {
                    Console.WriteLine("That is not a student number, please try again.");
                    continue;
                }
            }

            string allStu = GetUserInput("Would you like to see a list of all students? y/n");
            if (allStu == "y")
            {
                foreach (string stu in names)
                {
                    Console.WriteLine(stu);
                }
            }
            else
            {
                Console.WriteLine("Alright, we'll keep the full list hidden.");
            }

            goAgain = RunAgain();
        }
    }

    public static string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine().ToLower();
        return input;
    }

    public static bool RunAgain()
    {
        string answer = GetUserInput("\nWould you like to learn more about another student? y/n ").ToLower();

        if (answer == "y")
        {
            return true;
        }
        else if (answer == "n")
        {
            Console.WriteLine("Goodbye!");
            return false;
        }
        else
        {
            Console.WriteLine("\nI'm sorry, I didn't understand that. \nPlease input y or n\nTry again:");
            return RunAgain();
        }
    }

}