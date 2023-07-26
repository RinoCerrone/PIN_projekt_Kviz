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

        public QuestionController(QuizService quizService,ApplicationDbContext context)
        {
            _quizService = quizService;
            _context = context;
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            Quiz quiz = _quizService.GetQuiz();
            List<Question> questions = quiz.Questions;
            return View(quiz);
        }

[HttpPost("Submit")]
public IActionResult Submit(Dictionary<string, string> answers)
{
    Quiz quiz = _quizService.GetQuiz();
    quiz.UserAnswers = answers;

    if (answers.ContainsKey("action"))
    {
        string action = answers["action"];
        if (action == "previous")
        {
            _quizService.CurrentQuestionIndex--;
        }
        else if (action == "next")
        {
            _quizService.CurrentQuestionIndex++;
        }
    }

    if (answers.ContainsKey(quiz.Questions.Last().Text))
    {
        int score = _quizService.CalculateScore(quiz.UserAnswers.Values.ToList());

        // Create a new QuizResult instance
        var quizResult = new QuizResult
        {
            Score = score,
            Username = User.Identity.Name
        };

        // Save the quiz result to the database
        _context.QuizResults.Add(quizResult); // Update variable name to _context
        _context.SaveChanges(); // Update variable name to _context

        return RedirectToAction("QuizResults", new { score = score });
    }
    else
    {
        return RedirectToAction("Index");
    }
}





        [HttpGet("QuizResults")]
         public IActionResult QuizResults(int score)
         {
          return View(score);
        }
        [HttpPost("NextQuestion")]
        public IActionResult NextQuestion()
        {
            _quizService.CurrentQuestionIndex++;
            return RedirectToAction("Index");
        }

        [HttpPost("PreviousQuestion")]
        public IActionResult PreviousQuestion()
        {
            _quizService.CurrentQuestionIndex--;
            return RedirectToAction("Index");
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}







