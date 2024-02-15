using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_AbstractClass_StephanieLopez
{
    public class Student : Person
    {
        public double GPA_ { get; set; }
        //Field
        
        public Student(string Name, int ID, double GPA) : base(Name, ID)
        {
            GPA_ = GPA;
        }
        //Constructor

        public override string GetDetails()
        {
            return $"{Name_}, ID: {ID_}, GPA: {GPA_}";
        }
        //Displays Fields!
    }
}
