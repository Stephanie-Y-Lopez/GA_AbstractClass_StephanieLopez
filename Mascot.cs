using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_StephanieLopez
{
    internal class Mascot : Person
    {
        public string Animal_ { get; set; }
        //Field

        public Mascot(string Name, int ID, string Animal) : base(Name, ID)
        {
            Animal_ = Animal;
        }
        //Constructor

        public override string GetDetails()
        {
            return $"{Name_}, ID: {ID_}, Mascot: {Animal_}";
        }
        //Displays Fields!
    }
}
