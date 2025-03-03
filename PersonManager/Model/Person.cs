﻿namespace PersonManager.Model
{
    internal class Person
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }
        public Person(string firstName, string lastName ) { 
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public virtual string ToString()
        {
            return $"Name: {firstName} {lastName}\n";
        }
    }
}
