using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Kviz.Models;
using Kviz.Services;
using Kviz.Data;


namespace Kviz.Controllers
{
    [Route("[controller]")]
    public class QuestionController : Controller
    {
        private readonly QuizService _quizService;
        private readonly ApplicationDbContext _context;

        public QuestionController(QuizService quizService, ApplicationDbContext context)
        {
            _quizService = quizService;
            _context = context;
        }

        [HttpGet("Quiz/{quizName}")]
        public IActionResult Quiz(string quizName)
        {
            Quiz quiz = _quizService.GetQuizByName(quizName);
            if (quiz == null)
            {
                
                return RedirectToAction("Index","Home");
            }

            return View(quiz);
        }

        [HttpGet("CorrectAnswers/{quizName}")]
        public IActionResult CorrectAnswers(string quizName)
        {
            Quiz quiz = _quizService.GetQuizByName(quizName);
            if (quiz == null)
            {
                return RedirectToAction("Index", "Home");
            }

            
            return View("CorrectAnswers", quiz);
        }

        [HttpPost("Submit")]
        public IActionResult Submit(string quizName,Dictionary <string,string> answers)
        {

            
           


             Console.WriteLine($"quizName: {quizName}");

            Quiz quiz = _quizService.GetQuizByName(quizName);
            quiz.UserAnswers = answers;
            
            foreach (var answer in answers)
            {
                Console.WriteLine($"Selected Answer: {answer.Value} for Question: {answer.Key}");
            }


            if (answers.Count-1 == quiz.Questions.Count){
    
            int score = _quizService.CalculateScore(quizName, quiz.UserAnswers.Values.ToList());

            var quizResult = new QuizResult
            {
                Title=quizName,
                Score = score,
                Username = User.Identity.Name 
            };

            _context.QuizResults.Add(quizResult);
            _context.SaveChanges();

                return RedirectToAction("QuizResults", new { score = score , title = quizName});
            }
            else
            {
                return RedirectToAction("Quiz", new { quizName = quizName });
            }
        }


         


        [HttpGet("QuizResults")]
        public IActionResult QuizResults(int score,string title)
        {
            var quizResult = new QuizResult
            {
                Title = title,
                Score = score
                
            };

            return View(quizResult);
        }

        
    }
}
