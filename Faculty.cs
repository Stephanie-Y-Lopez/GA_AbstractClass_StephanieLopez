using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_StephanieLopez
{
    public class Faculty : Person
    {
        public string Role_ { get; set; }
        //Field

        public Faculty(string Name, int ID, string Role) : base(Name, ID)
        {
            Role_ = Role;
        }
        //Constructor

        public override string GetDetails()
        {
            return $"{Name_}, ID: {ID_}, Role: {Role_}";
        }
        //Displays Fields!
    }
}
