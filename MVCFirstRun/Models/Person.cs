using System;

namespace MVCFirstRun.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int Age 
        {
            get => DateTime.Now.Year - DateOfBirth.Year; 
        }

        public int AgeNextYear
        {
            get => Age + 1;
        }
    }
}