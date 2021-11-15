using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4 {
    class Survey {
        public List<Question> questionList { get; set; }
        public long clientID { get; set; }
        public long doctorID { get; set; }
        private Disease disease { get; set; }
        class Disease {
            public string diseaseName { get; set; }
            private int diseaseLevel;
            public int DiseaseLevel
            {
                get { return diseaseLevel; }
                set { diseaseLevel = value; }
            }
        }

        public Survey(long clientID, long doctorID) {
            this.questionList = new List<Question>();
            this.clientID = clientID;
            this.doctorID = doctorID;
        }

        public void SetDisease(string diseaseName, int diseaseLevel) {
            Disease disease = new Disease();
            disease.diseaseName = diseaseName;
            disease.DiseaseLevel = diseaseLevel;
        }
    }
}
