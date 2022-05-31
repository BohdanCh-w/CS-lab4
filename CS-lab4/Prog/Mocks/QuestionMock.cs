using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4 {
    static class QuestionMock {
        private static int questionID;
        static public List<Question> questionList {
            get {
                return new List<Question>() {
                    new Question("Ask first question?", 3, 0, questionID++),
                    new Question("Ask second question?", 4, 1, questionID++),
                    new Question("Ask third question?", 5, 2, questionID++),
                    new Question("Ask fourth question?", 2, 1, questionID++),
                    new Question("Ask fifth question?", 6, 4, questionID++)
                };
            }
        }
    }
}
