using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProjectApp
{
   public static class Program
    {
      const int numberOfQuestions = 2;
      const int numberOfAnswers = 4;

      public static  string[] questions = new string[numberOfQuestions];
      public static string[,] answer = new string[numberOfQuestions, numberOfAnswers];
      public static string[] hisanswer = new string[numberOfQuestions];
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
            questions[0] = "Кто ты?";
            questions[1] = "Что делаешь?";
            answer[0, 0] = "Человек";
            answer[0, 1] = "Крокодил";
            answer[0, 2] = "Жираф";
            answer[0, 3] = "Гуманитарий";
            answer[1, 0] = "Гуляю";
            answer[1, 1] = "Кушаю";
            answer[1, 2] = "Сижу";
            answer[1, 3] = "Читаю";
            rightanswer[0] = "Человек";
            rightanswer[1] = "Кушаю";

            
        }
    }
}
