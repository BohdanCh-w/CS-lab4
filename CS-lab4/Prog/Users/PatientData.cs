using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum BLOOD_TYPE
{
    Group_O,
    Group_A,
    Group_B,
    Group_AB,
    UNSET
}

namespace CS_lab4 {
        class PatientData {
        public BLOOD_TYPE bloodType { get; set; }
        public string location { get; set; }
        public List<AnalisisResult> analisisHistory { get; set; }

        public PatientData() {
            location = "";
            analisisHistory = null;
        }

        public PatientData(BLOOD_TYPE _bloodType, string _location, List<AnalisisResult> _analisisHistory) {
            bloodType = _bloodType;
            location = _location;
            analisisHistory = _analisisHistory;
        }

        
        public override string ToString() {
            return String.Format("Blood type {0}, location {1}, {2} analises.", bloodType, location, analisisHistory.Count);
        }
    }
}