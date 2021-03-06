using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4_Struct {
    struct Client {
        public uint assignedDoctor { get; set; }
        public PatientData data { get; set; }
        internal uint userID { get; set; }
        internal string name { get; set; }

        public Client(uint _userID, string _name, uint _assignedDoctor, PatientData _data) {
            assignedDoctor = _assignedDoctor;
            data = _data;
            userID = _userID;
            name = _name;
        }

        public override string ToString() {
            return $"id-{userID} : {name}. Assigned to {assignedDoctor}. {data.ToString()}";
        }

        public static implicit operator Client(int id) => UserMock.clientList[id];
        public static explicit operator int(Client obj) => (int)obj.userID;
        public static explicit operator string(Client obj) => obj.name;
    }
}