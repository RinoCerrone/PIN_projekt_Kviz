using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kviz.Models
{
    public class QuizResult
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string Username { get; set; }
    }
}