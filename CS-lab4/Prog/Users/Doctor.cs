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

        public Doctor(uint _userID, string _name, string _specialisation) : base(_userID, _name) {
            specialisation = _specialisation;
        }

        public override string ToString() {
            return $"id-{userID} : {name}. Specialisation - {specialisation}";
        }

        //При перевантаженні неявного перетворення використовується implicit, а при явному explicit.
        public static explicit operator int(Doctor obj) => (int)obj.userID;
        public static explicit operator string(Doctor obj) => obj.name;
    }
}
