namespace GA_AbstractClass_StephanieLopez
{
    // Stephanie Lopez
    // 2/15/2024
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating list to hold people
            List<Person> SchoolDataBase = new List<Person>();

            //Adding 2 instances from each class!
            SchoolDataBase.Add(new Professor("Mr. Cram", 224, "Computer Science"));
            SchoolDataBase.Add(new Professor("Mrs. Montes", 206, "Spanish"));
            //Professors

            SchoolDataBase.Add(new Student("Yolis Chavoya", 288, 3.9));
            SchoolDataBase.Add(new Student("Nelly Montes", 003, 3.7));
            //Students

            SchoolDataBase.Add(new Faculty("David Eager", 374, "Coach"));
            SchoolDataBase.Add(new Faculty("Franis Eager", 275, "Principal"));
            //Faculty

            SchoolDataBase.Add(new Mascot("Chains", 018, "Rottwelier"));
            SchoolDataBase.Add(new Mascot("Spike", 025, "Bee"));
            //Mascot


            //Creating loop to display each persons information :)
            foreach (var person in SchoolDataBase)
            {
                Console.WriteLine(person.GetDetails());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}