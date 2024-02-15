using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_StephanieLopez
{
    public abstract class Person
    {
        public string Name_ { get; set; }
        public int ID_ { get; set; }
        //Fields

        public Person(string Name, int ID)
        {
            this.Name_ = Name;
            ID_ = ID;
        }
        //Constructor

        public abstract string GetDetails();
        //Method for detail return
    }
}
