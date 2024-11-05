using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Creat the list of questions
            List<string> questions = new List<string>
            {
                "What is your name?",
                "How old are you?",
                "Where do you live?",
                "What is your favorite color?",
                "What are you interested in?",
                "What kind of music do you prefer?",
                "What about food?",
                "What is your favorite time of year?",
                "Where would you like to go on vacation?",
                "What is your favorite movie?",
                "Do you have a hobby?",
                "Do you have any pets?",
                "What is your favorite pet?",
                "What is your favorite sport?",
                "What profession would you like to master?"
            };

            // 2. Save a list with an answer
            List<string> answers = new List<string>();

            // 3. We go through each question, ask it to the user and save the answer
            foreach (string question in questions)
            {
                Console.WriteLine(question);          // Print the q
                string answer = Console.ReadLine();   // Read an answer
                answers.Add(answer);                  // Add answers to the list
            }

            // 4. we display all the answers so that the user can see them
            Console.WriteLine("\nThank you for your time! That's what you said:");
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{questions[i]} - {answers[i]}");
            }

            // Pause befor the end
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}