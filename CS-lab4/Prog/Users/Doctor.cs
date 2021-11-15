using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4 { 
    class Doctor : User {
        public string specialisation { get; set; }

        public Doctor() : base() {
            specialisation = "";
        }

        public Doctor(User _baseUser, string _specialisation) : base(_baseUser) {
            specialisation = _specialisation;
        }

        public override string ToString() {
            return String.Format("id-{0} : {1}. Specialisation - {2}", userID, name, specialisation);
        }
    }
}
