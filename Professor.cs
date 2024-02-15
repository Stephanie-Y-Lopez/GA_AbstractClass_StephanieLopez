using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_StephanieLopez
{
    public class Professor : Person
    {
        public string Department_ { get; set; }
        //Field

        public Professor(string Name, int ID, string Department) : base(Name, ID)
        {
            Department_ = Department;
        }
        //Constructor

        public override string GetDetails()
        {
            return $"{Name_}, ID: {ID_}, Department: {Department_}";
        }
        //Displays Fields!
    }
}
