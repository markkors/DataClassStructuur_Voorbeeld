using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataClassStructuur_Voorbeeld.Models;
using DataClassStructuur_Voorbeeld.Classes;
using System.Diagnostics;

namespace DataClassStructuur_Voorbeeld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private cQuiz ActiveQuiz;

        public MainWindow()
        {
            InitializeComponent();
            App.SQL = new cSQL();
            App.SQL.loadQuiz();
            ActiveQuiz = App.Quiz;
            Debug.WriteLine(ActiveQuiz.Questions.Count);
            
            foreach(cQuestion a in ActiveQuiz.Questions)
            {
                Debug.WriteLine(a.Question);

            }

        }

    }
}
