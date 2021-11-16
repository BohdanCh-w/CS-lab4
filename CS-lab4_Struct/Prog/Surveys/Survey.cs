using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4_Struct
{
    struct Survey
    {
        public List<Question> questionList { get; set; }
        public long clientID { get; set; }
        public long doctorID { get; set; }
        Disease disease { get; set; }//private
        struct Disease
        {//private, не можна створити екземпляр поза класом Survey, бо модифікатор private
            //клас Survey не має доступу до полів Disease і навпаки
            public string diseaseName { get; set; }
            public int DiseaseLevel { get; set; }
        }

        public Survey(long clientID, long doctorID)
        {
            this.questionList = new List<Question>();
            this.clientID = clientID;
            this.doctorID = doctorID;
            this.disease = new Disease();
        }

        public void SetDisease(in string diseaseName, in int diseaseLevel)
        {//передається по in
            Disease disease = new Disease();
            disease.diseaseName = diseaseName;
            disease.DiseaseLevel = diseaseLevel;
        }
    }
}