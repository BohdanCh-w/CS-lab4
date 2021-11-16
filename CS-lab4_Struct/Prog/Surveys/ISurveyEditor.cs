using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4_Struct {
    internal interface ISurveyEditor {
        Survey CreateSurvey(long clientID, long doctorID, string diseaseName, int diseaseLevel);

        void ChangeQuestion(Survey survey, List<Question> questionList);
    }
}