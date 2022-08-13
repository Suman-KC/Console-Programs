using System;

namespace ConsoleApp3
{
    class Program
    {

        class Person
        {
            private int _age; // field
            public int age  // property
            {
              
                     get
                        {
                            return _age;
                        }
                    
                set { if (age > 0) { _age = value; } }
            }
                
   
             
            
        }

        class ConsoleApp3
        {
            static void Main(string[] args)
            {
                Person myObj = new Person();
                myObj.age = -5;
                Console.WriteLine(myObj.age);
            }
        }
    }
    
}
