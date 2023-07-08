// A true or false game that stores user's correct answers as points. The method RunQuiz can be ran with paramaters of string[] questions and bool[] answers allowing multiple methods of different question combinations.

using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Our custom questions and answers
      string[] customQuestions = {"Dr. Pepper is the oldest soft drink in America.", "Fortune cookies were invented in China.", "The letter “J” is the only letter in the alphabet not included in the periodic table."};
      bool[] customAnswers = {true, false, true};


      RunQuiz(customQuestions, customAnswers);

    }

    static void RunQuiz(string[] questions, bool[] answers) {

      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);
      
      // Array to hold user responses
      bool[] responses = new bool[answers.Length];

      // Failsafe error to trigger if question amount and answer amount does not match up
      if (questions.Length != answers.Length) {
        Console.WriteLine("ERROR: Question amount does not match answer amount.");
      }

      int askingIndex = 0;  // variable to hold our index place for the question # we are on
      foreach (string question in questions) {
        string input;
        bool isBool;
        bool inputBool;
        
        // Asks question here
        Console.WriteLine(question);
        Console.WriteLine("True or False?");
        input = Console.ReadLine();
        
        // Parses user input to make sure the answer is in 'true' or 'false' format
        isBool = Boolean.TryParse(input, out inputBool);
        
          // Triggers if user did not reply with 'true' or 'false' and loops until user answers in correct format
          while (isBool == false) {
            Console.WriteLine("Please respond with 'true' or 'false'.");
            input = Console.ReadLine();
            isBool = Boolean.TryParse(input, out inputBool);
          }
        responses[askingIndex] = inputBool; // Store user response
        askingIndex++; // Proceeds to next question
      }

      int scoringIndex = 0;
      int score = 0;
      
      foreach (bool answer in answers) {
        bool record = responses[scoringIndex];
        Console.WriteLine($"Question #1 - Your Answer: {record} | Correct Answer: {answer}");

          if (record == answer) {
            score++;
          }
          scoringIndex++;
      }

      Console.WriteLine($"You got {score} out {questions.Length} points!");
      
    }
  }
}
