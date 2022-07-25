using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Capitulo15.DesafioHashSet.Entities
{
    class User
    {
        public string Name { get; set; }
        public DateTime AccessTime { get; set; }

        public User(string name, DateTime accessTime)
        {
            Name = name;
            AccessTime = accessTime;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is User))
                return false;

            User other = obj as User;
            return Name.Equals(other.Name);
        }

    }
}
