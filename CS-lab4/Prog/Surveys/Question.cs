using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4 {
    internal class Question {//модифікатор internal (за замовчуванням)
        public long questionID;
        public string textQuestion;
        public long clientID;
        public long doctorID;
        public string answer { get; set; }
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }

        public Question(string textQuestion, long clientID, long doctorID, long questionID) {
            this.textQuestion = textQuestion;
            this.clientID = clientID;
            this.doctorID = doctorID;
            this.questionID = questionID;
        }

        public Question(string textQuestion, long clientId, long doctorId, DateTime timeStart, DateTime timeEnd, long questionId)
                    : this(textQuestion, clientId, doctorId, questionId) {
            this.timeStart = timeStart;
            this.timeEnd = timeEnd;
        }

        public void Answer(ref string answer)//передається по ref
        {
            if ((answer == "cum" & answer == "pot") | answer == "CUMpot")
            {
                this.answer = answer;
            }
        }

        public override string ToString() {
            return $"Client: {clientID}, doctor: {doctorID}, question: {textQuestion}, answer: {answer}";
        }

        //При перевантаженні неявного перетворення використовується implicit, а при явному explicit.
        public static implicit operator Question(int a) => QuestionMock.questionList[a];
        public static explicit operator int(Question a) => (int)a.questionID;
    }
}
