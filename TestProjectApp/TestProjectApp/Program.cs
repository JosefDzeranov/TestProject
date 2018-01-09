using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProjectApp
{
    static class Program
    {
      const int numberOfQuestions = 2;
      const int numberOfAnswers = 4;

      public static  string[] questions = new string[numberOfQuestions];
      public static string[,] answer = new string[numberOfQuestions, numberOfAnswers];
      public static string[] rightanswer = new string[numberOfQuestions];
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
