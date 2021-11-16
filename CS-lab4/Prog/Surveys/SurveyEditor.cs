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

        public static SurveyEditor surveyEditor {//в мене написано в звіті все про static конструктор та поля
            get { return editor ?? new SurveyEditor(); }
        }

        static SurveyEditor() {
            editor = new SurveyEditor();
        }

        public Survey CreateSurvey(long clientID, long doctorID, string diseaseName, int diseaseLevel) {
            Survey survey = new Survey(clientID, doctorID);
            object temp = diseaseLevel;//boxing приведення зі структури в клас = хуйово
            survey.SetDisease(diseaseName, (int)temp);//unboxing приведення зі класу в структуру, тоже хуйово
            return survey;
        }

        public void ChangeQuestion(Survey survey, List<Question> questionList) {
            survey.questionList = questionList;
        }
    }
}
