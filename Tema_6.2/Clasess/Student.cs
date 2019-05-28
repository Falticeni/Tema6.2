using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_6._2.Clasess
{
    // Problema 1.
    public class Student : ICloneable, IComparable<Student>
    {
        // Proprietati:
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public Enumeratii.University University { get; set; }
        public Enumeratii.Faculty Faculty { get; set; }
        public Enumeratii.Specialty Speciality { get; set; }

        // Override la GetHashCode() si Cream SSN-ul:
        private static Random RandomDigit = new Random();
        public override int GetHashCode()
        {
            int ssn = 0;
            for (int i = 0; i < 9; i++)
            {
                ssn = ssn * 10 + RandomDigit.Next(0, 9);
            }
            return ssn;
        }

        //Constructorul:
        public Student(string firstName, string lastName,
                       string address, string mobilePhone, string email, int course,
                       Enumeratii.University university, Enumeratii.Faculty faculty, Enumeratii.Specialty speciality, string middleName = "") //SSN-ul e generat automat de metoda GetHashCode()
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = GetHashCode();
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Speciality = speciality;
        }

        //Override la Equals(object obj):
        public override bool Equals(object obj)
        {
            if (this.SSN == (obj as Student).SSN) return true;
            else return false;
        }

        //Override la ToString()
        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.Append($"First Name:{FirstName}\n");
            data.Append($"Middle Name: {MiddleName}\n");
            data.Append($"Last Name: {LastName}\n");
            data.Append($"SSN: {SSN}\n");
            data.Append($"Address: {Address}\n");
            data.Append($"Mobile Phone: {MobilePhone}\n");
            data.Append($"Email: {Email}\n");
            data.Append($"Course: {Course}\n");
            data.Append($"University: {University}\n");
            data.Append($"Faculty: {Faculty}\n");
            data.Append($"Specialty: {Speciality}\n");
            return data.ToString();
        }

        //Override la operatorii "==" si "!="
        public static bool operator ==(Student Student1, Student Student2)
        {
            if (Student1.Equals(Student2 as Object)) return true;
            else return false;
        }

        public static bool operator !=(Student Student1, Student Student2)
        {
            if (!Student1.Equals(Student2 as Object)) return true;
            else return false;
        }

        //Problema 2:
        public object Clone()
        {
            Student Copie = new Student(FirstName, LastName, Address, MobilePhone, Email, Course, University, Faculty, Speciality, MiddleName);
            Copie.SSN = this.SSN; // copiem, nu generam un nou SSN
            return Copie;
        }

        //Problema 3:
        public int CompareTo(Student Student3)
        {
            int c = 0;
            c += string.Compare(this.FirstName, Student3.FirstName);
            c += string.Compare(this.LastName, Student3.LastName);
            c += string.Compare(this.MiddleName, Student3.MiddleName);

            if (this.SSN > Student3.SSN) c++;
            else
            {
                if (this.SSN < Student3.SSN) c--;
            }
            return c;
        }
    }
}
