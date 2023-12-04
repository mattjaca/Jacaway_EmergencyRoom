using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacaway_EmergencyRoom
{
    internal class Patient
    {
        private string FirstName;
        private string LastName;
        private int Priority;
        DateOnly Birthdate = new DateOnly();
        public Patient(string firstName, string lastName, int priority, DateOnly birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Priority = priority;
            Birthdate = birthdate;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
