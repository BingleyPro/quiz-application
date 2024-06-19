// Quiz Application by BingleyPro
// c# version

using System;
using System.Collections.Generic;

namespace QuizApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new quiz object
            Quiz quiz = new Quiz();

            // Add questions to the quiz
            quiz.AddQuestion("What is the capital of France?", "Paris");
            quiz.AddQuestion("What is the capital of Spain?", "Madrid");
            quiz.AddQuestion("What is the capital of Italy?", "Rome");
            quiz.AddQuestion("What is the capital of Germany?", "Berlin");
            quiz.AddQuestion("What is the capital of the United Kingdom?", "London");

            // Start the quiz
            quiz.Start();
        }
    }

    class Quiz
    {
        private List<Question> questions = new List<Question>();
        private int score = 0;

        public void AddQuestion(string question, string answer)
        {
            questions.Add(new Question(question, answer));
        }

        public void Start()
        {
            Console.WriteLine("Welcome to the quiz!");
            Console.WriteLine("Answer the following questions:");

            foreach (Question question in questions)
            {
                Console.WriteLine(question.GetQuestion());
                string userAnswer = Console.ReadLine();

                if (question.CheckAnswer(userAnswer))
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }

            Console.WriteLine("Quiz complete!");
            Console.WriteLine("You scored " + score + " out of " + questions.Count);
        }
    }

    class Question
    {
        private string question;
        private string answer;

        public Question(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }

        public string GetQuestion()
        {
            return question;
        }

        public bool CheckAnswer(string userAnswer)
        {
            return userAnswer.ToLower() == answer.ToLower();
        }
    }

    class multiChoiceQuestion {
        private string question;
        private string choices;
        private int answer;

        public multiChoiceQuestion(string question, string choices, int answer) {
            this.question = question;
            this.choices = choices;
        }

        public string GetQuestion()
        {
            return question;
        }

        public bool CheckAnswer(string userAnswer)
        {
            return userAnswer.ToLower() == answer.ToLower();
        }
    }
}