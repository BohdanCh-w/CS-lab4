using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4 {
    class Client : User {
        public uint assignedDoctor { get; set; }
        public PatientData data { get; set; }

        public Client() : base() {
            assignedDoctor = 0;
            data = null;
        }

        public Client(uint _userID, string _name, uint _assignedDoctor, PatientData _data) : base(_userID, _name) {
            assignedDoctor = _assignedDoctor;
            data = _data;
        }

        public override string ToString() {
            return $"id-{userID} : {name}. Assigned to {assignedDoctor}. {data.ToString()}";
        }

        public static explicit operator int(Client obj) => (int)obj.userID;
        public static explicit operator string(Client obj) => obj.name;
    }
}
