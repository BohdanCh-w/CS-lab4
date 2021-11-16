using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_lab4 {
    public abstract class User : IComparable<User>, IEquatable<User> {//модифікатор public
        internal uint userID { get; set; }//internal
        protected internal string name { get; set; }//protected || internal

        public User() {
            userID = 0;
            name = "";
        }
 
        public User(uint _userID, string _name) {
            userID = _userID;
            name = _name;
        }

        public User(User other) {
            userID = other.userID;
            name = other.name;
        }

        public int CompareTo(User other) => this.name.CompareTo(other.name);
        public bool Equals(User other) => this.userID.Equals(other.userID);
        public override int GetHashCode() => base.GetHashCode();

        public static implicit operator User(int id) => UserMock.usersList[id];
        public static explicit operator int(User obj) => (int)obj.userID;
        public static explicit operator string(User obj) => obj.name;
    }
}
