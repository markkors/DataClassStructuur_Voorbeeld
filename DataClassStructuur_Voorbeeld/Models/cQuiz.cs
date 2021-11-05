using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataClassStructuur_Voorbeeld.Classes;

namespace DataClassStructuur_Voorbeeld.Models
{
    public class cQuiz : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _ActiveQuestionID;

        public List<cQuestion> _Questions;

        public cQuiz(string n)
        {
           QuizName = n;
        }

        public List<cQuestion> Questions {
            get { return _Questions; }
            set { _Questions = value; }
        }

        public string QuizName { get; set; }

        public string ActiveQuestionID { 
            get { 
                return _ActiveQuestionID;
            }
            set { 
                _ActiveQuestionID = value;
                OnPropertyChanged("ActiveQuestionID");            
            } 
        }


        // speciaal voor Binding werking
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
