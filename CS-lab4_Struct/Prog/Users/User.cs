using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab4_Struct
{
    struct User : IComparable<User>, IEquatable<User>
    {//модифікатор public
        internal uint userID { get; set; }//internal
        internal string name { get; set; }//protected || internal

        public User(uint _userID, string _name)
        {
            userID = _userID;
            name = _name;
        }

        public User(User other) : this(other.userID, other.name)
        {//this викликає інший конструктор даного класу

        }

        public int CompareTo(User other) => this.name.CompareTo(other.name);//this вказує що використовується саме поле даного класу
        public bool Equals(User other) => this.userID.Equals(other.userID);//this вказує що використовується саме поле даного класу
        public override int GetHashCode() => base.GetHashCode();//base пишеться, щоб не було рекусрсії

        //При перевантаженні неявного перетворення використовується implicit, а при явному explicit.
        public static explicit operator int(User obj) => (int)obj.userID;
        public static explicit operator string(User obj) => obj.name;
    }
}