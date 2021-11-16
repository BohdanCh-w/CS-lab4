using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4 {
    internal interface ISurveyEditor {//модифікатор internal(за замовчуванням)
        Survey CreateSurvey(long clientID, long doctorID, string diseaseName, int diseaseLevel);//public, навіть явно вказати не можна

        void ChangeQuestion(Survey survey, List<Question> questionList);//public, навіть явно вказати не можна
    }
}
