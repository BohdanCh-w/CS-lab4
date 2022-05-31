using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4 {
    static class UserMock {
        private static uint userID;
        private static uint analisID;

        static public List<User> usersList {
            get {
                return new List<User>() {
                    new Doctor(userID++, "First", "Internist"),
                    new Doctor(userID++, "Second", "Psychiatrist"),
                    new Doctor(userID++, "Third", "Neurologist"),
                    new Doctor(userID++, "Fourth", "Anesthesiologist"),
                    new Client(userID++, "Fifth", userID - 5, new PatientData(BLOOD_TYPE.Group_A, "Fifth location", new List<AnalisisResult>(){
                        new AnalisisResult(analisID++, 37.9, "normal", null),
                        new AnalisisResult(analisID++, 36.6, "normal", null)
                    } )),
                    new Client(userID++, "Sixth", userID - 5, new PatientData(BLOOD_TYPE.Group_AB, "Sixth location", new List<AnalisisResult>() {
                        new AnalisisResult(4, 38.2, "normal", new Dictionary<string, string>(){{"preasure", "128/80"},{"cardio", "id318"}}),
                        new AnalisisResult(5, 36.9, "normal", new Dictionary<string, string>(){{"preasure", "123/76"},{"cardio", "id330"}})
                    } )),
                    new Client(userID++, "Seventh", userID - 5, new PatientData(BLOOD_TYPE.Group_O, "Seventh location", new List<AnalisisResult>(){
                        new AnalisisResult(6, 39.9, "normal", null),
                        new AnalisisResult(7, 38.4, "normal", null),
                        new AnalisisResult(8, 37.2, "normal", null)
                    } )),
                    new Client(userID++, "Eighth", userID - 5, new PatientData(BLOOD_TYPE.Group_O, "Eighth location", new List<AnalisisResult>() {
                        new AnalisisResult(4, 38.2, "normal", new Dictionary<string, string>(){{"preasure", "140/90"},{"physical", "id248"}}),
                        new AnalisisResult(5, 36.9, "normal", new Dictionary<string, string>(){{"preasure", "134/82"},{"physical", "id255"}})
                    } )),
                };
            }
        }
    }
}
