using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAPServiceStudentProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1

    {

        List<Student> students = new List<Student>();

       
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        
        public Student FindStudent(string ID)
        {
            foreach (Student Student in students)
            {
                if (Student.StudentId == ID)
                {
                    return Student;

                }
            }

            throw new ArgumentException("Student Not found");
            
        }
        

        public void GetAllStudent(Student student)
        {
            foreach (var s in students)
            {
                Console.WriteLine($"Student Name: \n{student.Name}\nStudent ID: \n{student.StudentId}\nStudent SSN: \n{student.SSN}\nStudent Class: \n{student.Class}");
                
            }
        }

        public Student RemoveStudent(int index)
        {
            students.RemoveAt(index);
            return null;
        }

        public void EditStudent(int index, Student s)
        {
            students.RemoveAt(index);
            students.Add(s);
           
        }
    }
}
