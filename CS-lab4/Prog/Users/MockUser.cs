using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4 {
    sealed class UserMock {
        public List<Doctor> Doctors { 
            get {
                return new List<Doctor>() {
                    new Doctor(new User(1, "First"), "Internist"),
                    new Doctor(new User(2, "Second"), "Psychiatrist"),
                    new Doctor(new User(3, "Third"), "Neurologist"),
                    new Doctor(new User(4, "Fourth"), "Anesthesiologist")
                };
            }
        }

        public List<Client> Clients {
            get {
                return new List<Client>() {
                    new Client(new User(5, "Fifth"), 1, new PatientData(BLOOD_TYPE.Group_O, "Fifth location", new List<AnalisisResult>() )),
                    new Client(new User(6, "Sixth"), 2, new PatientData(BLOOD_TYPE.Group_B, "Sixth location", new List<AnalisisResult>() )),
                    new Client(new User(7, "Seventh"), 2, new PatientData(BLOOD_TYPE.Group_AB, "Seventh location", new List<AnalisisResult>(){
                        new AnalisisResult(1, 37.9, "normal", null),
                        new AnalisisResult(2, 36.6, "normal", null)
                    } )),
                    new Client(new User(8, "Eighth"), 1, new PatientData(BLOOD_TYPE.Group_A, "Eighth location", new List<AnalisisResult>() )),
                    new Client(new User(9, "Ninth"), 3, new PatientData(BLOOD_TYPE.Group_B, "Ninth location", new List<AnalisisResult>() )),
                    new Client(new User(10, "Tenth"), 4, new PatientData(BLOOD_TYPE.Group_A, "Tenth location", new List<AnalisisResult>() {
                        new AnalisisResult(3, 36.6, "low red cells", null)
                    } )),
                    new Client(new User(11, "Eleventh"), 4, new PatientData(BLOOD_TYPE.Group_A, "Eleventh location", new List<AnalisisResult>() )),
                    new Client(new User(12, "Twelveth"), 2, new PatientData(BLOOD_TYPE.Group_AB, "Twelveth location", new List<AnalisisResult>() )),
                    new Client(new User(13, "Thirteenth"), 2, new PatientData(BLOOD_TYPE.Group_O, "Thirteenth location", new List<AnalisisResult>() {
                        new AnalisisResult(4, 38.2, "normal", new Dictionary<string, string>(){{"preasure", "128/80"},{"cardio", "id318"}}),
                        new AnalisisResult(5, 36.9, "normal", new Dictionary<string, string>(){{"preasure", "123/76"},{"cardio", "id330"}})
                    } )),
                    new Client(new User(14, "Fourteenth"), 4, new PatientData(BLOOD_TYPE.Group_A, "Fourteenth location", new List<AnalisisResult>(){
                        new AnalisisResult(6, 39.9, "normal", null),
                        new AnalisisResult(7, 38.4, "normal", null),
                        new AnalisisResult(8, 37.2, "normal", null)
                    } )),
                    new Client(new User(15, "Fifteenth"), 3, new PatientData(BLOOD_TYPE.Group_O, "Fifteenth location", new List<AnalisisResult>() )),
                    new Client(new User(16, "Sixteenth"), 2, new PatientData(BLOOD_TYPE.Group_B, "Sixteenth location", new List<AnalisisResult>() )),
                    new Client(new User(17, "Seventeenth"), 1, new PatientData(BLOOD_TYPE.Group_AB, "Seventeenth location", new List<AnalisisResult>() )),
                    new Client(new User(18, "Eighteenth"), 4, new PatientData(BLOOD_TYPE.Group_AB, "Eighteenth location", new List<AnalisisResult>() ))
                };
            }
        }

        public List<User> Uesrs {
            get {
                return this.Doctors.Join(this.Clients);
            }
        }
    }
}