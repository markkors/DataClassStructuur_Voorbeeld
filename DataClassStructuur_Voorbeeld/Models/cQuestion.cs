using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClassStructuur_Voorbeeld.Models
{

    
    public class cQuestion

    {
        private string _question;
        public List<cAnswer> Answers;
        public cQuestion()
        {
            Guid g = Guid.NewGuid();
            _question = ($"Dit is een random gemaakte vraag - {g.ToString()}");
            Answers = App.SQL.getAnswers();

        }

        public string Question
        {
            get { return _question; }
            set { _question = value; }
        }
    }

    
}
