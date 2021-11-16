using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var doctorList = UserMock.doctorList;
            var clientList = UserMock.clientList;
            var questionList = QuestionMock.questionList;

            SurveyEditor editor = new SurveyEditor();

            Survey survey = editor.CreateSurvey(clientList[0].userID, doctorList[0].userID, "Cummer", int.MaxValue);
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

            Console.WriteLine("\nAll doctors in mock:");
            foreach (var doctor in doctorList)
            {
                Console.WriteLine(doctor);
            }

            Console.WriteLine("\nAll clients in mock:");
            foreach (var client in clientList)
            {
                Console.WriteLine(client);
            }
        }
    }
}
