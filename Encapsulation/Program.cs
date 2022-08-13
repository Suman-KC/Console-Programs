using System;
namespace program
{
    class Encapsulation
    {
        private string Name = "Alex";
        public string EmployeeName
        { // Property  
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        class Hello
        {
            static void Main(string[] args)
            {
                string Name2 = string.Empty;
                // use properties  
                Encapsulation e = new Encapsulation();
                Name2 = e.EmployeeName;
                Console.WriteLine("Employee Name: " + Name2);
                Console.ReadLine();
            }
        }
    }
}