using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Kviz.Models
{
    public class Quiz
    {
        public string Title { get; set; }
        public List<Question> Questions { get; set; }
        public string CurrentQuestionId { get; set; }
        public Dictionary<string, string> UserAnswers { get; set; }

        public Quiz()
        {
            Questions = new List<Question>();
            UserAnswers = new Dictionary<string, string>();
        }
    }
}
