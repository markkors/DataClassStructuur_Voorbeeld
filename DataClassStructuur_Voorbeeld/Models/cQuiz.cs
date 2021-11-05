using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClassStructuur_Voorbeeld.Classes;

namespace DataClassStructuur_Voorbeeld.Models
{
    public class cQuiz
    {

        private string _QuizName;

        public List<cQuestion> _Questions;

        public cQuiz(string n)
        {
            _QuizName = n;
        }

        public List<cQuestion> Questions {
            get { return _Questions; }
            set { _Questions = value; }
        }

        public string QuizName { get; set; }

    }
}
