using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4_Struct
{
    struct QuestionMock
    {
        private static int questionID;

        static public List<Question> questionList
        {
            get
            {
                return new List<Question>()
                {
                    new Question("Do you want to cum?", 3, 0, questionID++),
                    new Question("Yes i want", 4, 1, questionID++),
                    new Question("I already cum", 5, 2, questionID++)
                };
            }
        }
    }
}