using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4_Struct
{
    struct User : IComparable<User>, IEquatable<User> {
        internal uint userID { get; set; }
        internal string name { get; set; }

        public User(uint _userID, string _name) {
            userID = _userID;
            name = _name;
        }

        public User(User other) : this(other.userID, other.name) { }

        public int CompareTo(User other) => this.name.CompareTo(other.name);
        public bool Equals(User other) => this.userID.Equals(other.userID);
        public override int GetHashCode() => base.GetHashCode();

        public static explicit operator int(User obj) => (int)obj.userID;
        public static explicit operator string(User obj) => obj.name;
    }
}