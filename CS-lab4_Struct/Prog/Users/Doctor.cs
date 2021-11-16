using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4_Struct
{
    struct Doctor
    {
        internal uint userID { get; set; }
        internal string name { get; set; }
        public string specialisation { get; set; }

        public Doctor(uint _userID, string _name, string _specialisation) {
            specialisation = _specialisation;
            userID = _userID;
            name = _name;
        }

        public override string ToString() {
            return $"id-{userID} : {name}. Specialisation - {specialisation}";
        }

        public static implicit operator Doctor(int id) => UserMock.doctorList[id];
        public static explicit operator int(Doctor obj) => (int)obj.userID;
        public static explicit operator string(Doctor obj) => obj.name;
    }
}