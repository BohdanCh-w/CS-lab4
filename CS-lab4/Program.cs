using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var userList = UserMock.usersList;
            var questionList = QuestionMock.questionList;

            SurveyEditor editor = new SurveyEditor();

            Survey survey = editor.CreateSurvey(userList[3].userID, userList[0].userID, "Cummer", int.MaxValue);
            survey.questionList = questionList;

            Console.WriteLine("Enter number of question:");
            int.TryParse(Console.ReadLine(), out int questionNumber);
            Question selectedQuestion = questionNumber;
            Console.WriteLine("Selected question iD: " + (int)selectedQuestion + ", question info:" + selectedQuestion);

            editor.ChangeQuestion(survey, questionList);

            Console.WriteLine("All questions in mock:");
            foreach (var question in questionList)
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
