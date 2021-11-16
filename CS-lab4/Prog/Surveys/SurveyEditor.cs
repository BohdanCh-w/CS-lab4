using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4
{
    class SurveyEditor : ISurveyEditor
    {
        private static SurveyEditor editor;

        public static SurveyEditor surveyEditor {
            get { return editor ?? new SurveyEditor(); }
        }

        static SurveyEditor() {
            editor = new SurveyEditor();
        }

        public Survey CreateSurvey(long clientID, long doctorID, string diseaseName, int diseaseLevel) {
            Survey survey = new Survey(clientID, doctorID);
            object temp = diseaseLevel;
            survey.SetDisease(diseaseName, (int)temp);
            return survey;
        }

        public void ChangeQuestion(Survey survey, List<Question> questionList) {
            survey.questionList = questionList;
        }
    }
}
