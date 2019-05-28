using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema_6._2.Clasess;

namespace Tema_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> TotiStudentii = new List<Student> { new Student("Robert", "Ciocan", "str. Mihai Viteazul",
                                                                            "0744525411", "robert.ciocan@yahoo.com", 4,
                                                                            Enumeratii.University.University1,
                                                                            Enumeratii.Faculty.Faculty2,
                                                                            Enumeratii.Specialty.Specialty1,
                                                                            "Alin"),

                                                              new Student("Mircea", "Vasiliu", "str. Mihai Eminescu",
                                                                            "0744525222", "mircea.vasiliu@yahoo.com", 2,
                                                                            Enumeratii.University.University3,
                                                                            Enumeratii.Faculty.Faculty5,
                                                                            Enumeratii.Specialty.Specialty4),

                                                              new Student("Alin", "Tudor", "str. Domnul Fluture",
                                                                            "072295411", "alin.Tudor@yahoo.com", 3,
                                                                            Enumeratii.University.University1,
                                                                            Enumeratii.Faculty.Faculty1,
                                                                            Enumeratii.Specialty.Specialty2,
                                                                            "Gabriel"),
            };
            //Am adaugat in lista o clona:
            TotiStudentii.Add(TotiStudentii[1].Clone() as Student);

            // verificam daca avem in lista de studenti persoane identice
            bool identici = false;
                        for (int i = 0; i < TotiStudentii.Count - 1; i++)
            {
                for (int j = i + 1; j < TotiStudentii.Count; j++)
                {
                    if (TotiStudentii[i] == TotiStudentii[j])
                    {
                        identici = true;
                        Console.WriteLine("Studentul {0} este identic cu Studentul {1}.", TotiStudentii[i].FirstName, TotiStudentii[j].FirstName);
                    }
                }
            }
            if (!identici)
            {
                Console.WriteLine("Nu avem studenti identici.");
            }

            // meteda de sortare
            for (int i = 0; i < TotiStudentii.Count - 1; i++)
                for (int j = i + 1; j < TotiStudentii.Count; j++)
                {
                    if (TotiStudentii[i].CompareTo(TotiStudentii[j]) > 0)
                    {
                        Student varStudent = TotiStudentii[i].Clone() as Student; 
                        TotiStudentii[i] = TotiStudentii[j].Clone() as Student; 
                        TotiStudentii[j] = varStudent.Clone() as Student;
                    }
                }

            foreach (Student student in TotiStudentii)
            {
                Console.WriteLine(student);
            }

            Console.ReadKey();
        }
    }
}
