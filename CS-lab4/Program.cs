using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4
{
    //ref використовується при передачі параметрів у функцію і означає, що значення передається не по значенню, а по силці(пишеться і в параметрах функції, і при виклику).
    //out працює аналогічно до ref, але вимагає ініціалізації змінної в функції.
    //in працює протилежно до out, тобто забороняє ініціалізацію змінної в функції.

    class Program
    {
        static void Main(string[] args)
        {
            var userList = UserMock.usersList;
            var questionList = QuestionMock.questionList;

            SurveyEditor editor = new SurveyEditor();

            Survey survey = editor.CreateSurvey(userList[3].userID, userList[0].userID, "Cummer", int.MaxValue);
            survey.questionList = questionList;
            foreach (var question in survey.questionList)
            {
                string answer = "CUMpot";
                question.Answer(ref answer);//передається ref
            }

            Console.WriteLine("Enter number of question:");
            int.TryParse(Console.ReadLine(), out int questionNumber);
            Question selectedQuestion = questionNumber;
            Console.WriteLine("Selected question iD: " + (int)selectedQuestion + ", question info:" + selectedQuestion);

            editor.ChangeQuestion(survey, questionList);

            Console.WriteLine("\nAll questions in survey:");
            foreach (var question in survey.questionList)
            {
                Console.WriteLine(question);
            }

            Console.WriteLine("\nAll users in mock:");
            foreach (var user in userList)
            {
                Console.WriteLine(user);
            }
        }
    }
}
