using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClassStructuur_Voorbeeld.Models
{
    public class cAnswer
    {
        private string _answer;
        public cAnswer()
        {
            Guid g = Guid.NewGuid();
            _answer = ($"Dit is een random gemaakt antwoord - {g.ToString()}");
        }

        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        

    }
}
