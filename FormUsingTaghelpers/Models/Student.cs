using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormUsingTaghelpers.Models
{
    public class Student
    {
        public string name { get; set; }
        public int roll { get; set; }
        public int age { get; set; }
        public Gender Gender { get; set; }
        public string Married{ get; set; }
    }
    public enum Gender
    {
        male, female
    }
}
