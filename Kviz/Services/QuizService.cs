using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Kviz.Models;

namespace Kviz.Services
{
    public class QuizService
    {
        private Quiz _quiz;
        public int CurrentQuestionIndex { get; set; }

        public QuizService()
        {
            // Initialize the quiz data or load it from an external source
            _quiz = InitializeQuiz();
            CurrentQuestionIndex = 0;
        }

        // Method to get the quiz
        public Quiz GetQuiz()
        {
            return _quiz;
        }

        // Method to validate answers and calculate the score
        public int CalculateScore(List<string> userAnswers)
        {
            int score = 0;

            for (int i = 0; i < _quiz.Questions.Count; i++)
            {
                if (_quiz.Questions[i].CorrectAnswer == userAnswers[i])
                {
                    score++;
                }
            }

            return score;
        }

        // Helper method to initialize the quiz data
        private Quiz InitializeQuiz()
        {
            Quiz quiz = new Quiz();
            quiz.Title = "My Quiz";

            // Add questions to the quiz
            Question question1 = new Question
            {
                Text = @"""Na zastavi Novog Zelanda u gornjem lijevom kutu se nalazi Union Jack,
                a pored njega četiri zvijezde koje predstavljaju koje zviježđe latinskog imena Crux?""",
                Answers = new List<string> { "Južni križ", "Sjeverni čvor", "Južni trokut","Veliki medvjed" },
                CorrectAnswer = "Južni križ"
            };
            quiz.Questions.Add(question1);

            Question question2 = new Question
            {
                Text = "Koje godine je počeo Američki građanski rat?",
                Answers = new List<string> { "1883", "1861", "1872","1868" },
                CorrectAnswer = "1861"
            };
            quiz.Questions.Add(question2);

            Question question3 = new Question
            {
                Text = "Koje godine je počeo Američki građanski rat?",
                Answers = new List<string> { "1883", "1861", "1872","1868" },
                CorrectAnswer = "1861"
            };
            quiz.Questions.Add(question3);

            Question question4 = new Question
            {
                Text = "Koje godine je počeo Američki građanski rat?",
                Answers = new List<string> { "1883", "1861", "1872","1868" },
                CorrectAnswer = "1861"
            };
            quiz.Questions.Add(question4);

            Question question5 = new Question
            {
                Text = "Koje godine je počeo Američki građanski rat?",
                Answers = new List<string> { "1883", "1861", "1872","1868" },
                CorrectAnswer = "1861"
            };
            quiz.Questions.Add(question5);

            Question question6 = new Question
            {
                Text = "Koje godine je počeo Američki građanski rat?",
                Answers = new List<string> { "1883", "1861", "1872","1868" },
                CorrectAnswer = "1861"
            };
            quiz.Questions.Add(question6);

            Question question7 = new Question
            {
                Text = "Koje godine je počeo Američki građanski rat?",
                Answers = new List<string> { "1883", "1861", "1872","1868" },
                CorrectAnswer = "1861"
            };
            quiz.Questions.Add(question7);

            Question question8 = new Question
            {
                Text = "Koje godine je počeo Američki građanski rat?",
                Answers = new List<string> { "1883", "1861", "1872","1868" },
                CorrectAnswer = "1861"
            };
            quiz.Questions.Add(question8);

            Question question9 = new Question
            {
                Text = "Koje godine je počeo Američki građanski rat?",
                Answers = new List<string> { "1883", "1861", "1872","1868" },
                CorrectAnswer = "1861"
            };
            quiz.Questions.Add(question9);

            Question question10 = new Question
            {
                Text = "Koje godine je počeo Američki građanski rat?",
                Answers = new List<string> { "1883", "1861", "1872","1868" },
                CorrectAnswer = "1861"
            };
            quiz.Questions.Add(question10);

            // Add more questions...

            return quiz;
        }
    }
}
