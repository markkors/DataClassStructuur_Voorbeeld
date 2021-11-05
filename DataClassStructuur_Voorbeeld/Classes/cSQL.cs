using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClassStructuur_Voorbeeld.Models;

namespace DataClassStructuur_Voorbeeld.Classes
{
    public class cSQL
    {

        public void loadQuiz()
        {
            // make it global
            App.Quiz = new cQuiz("Quiz Nr 1");
            App.Quiz.Questions = getQuestions();

        }

        public List<cQuestion> getQuestions()
        {
            // haal de vragen op uit bijvoorbeeld SQL
            List<cQuestion> _questions = new List<cQuestion>();
            for (int i=0;i < 10; i++)
            {
                cQuestion q = new cQuestion();
                _questions.Add(q);

            }
            return _questions;
        }


        public List<cAnswer> getAnswers()
        {
            // haal de antwoorden op uit bijvoorbeeld SQL
            List<cAnswer> _answers = new List<cAnswer>();
            for (int i = 0; i < 4; i++)
            {
                cAnswer a = new cAnswer();
                _answers.Add(a);
            }
            return _answers;
        }
    }
}
