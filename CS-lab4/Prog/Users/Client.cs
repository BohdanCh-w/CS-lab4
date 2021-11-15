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

        public Client(User _baseUser, uint _assignedDoctor, PatientData _data) : base(_baseUser) {
            assignedDoctor = _assignedDoctor;
            data = _data;
        }

        public override string ToString() {
            return String.Format("id-{0} : {1}. Assigned to {2}. {3}", userID, name, assignedDoctor, data.ToString());
        }
    }
}
