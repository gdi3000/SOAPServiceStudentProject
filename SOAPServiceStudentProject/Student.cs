namespace SOAPServiceStudentProject
{
    public class Student
    {
        public string StudentId
        {
            get { return StudentId; }
            set
            {
                if (value != null)
                {
                    StudentId = value;
                }
               
            }

            
        }

        public string Name
        {
            get { return Name; }
            set
            {
                if (value != null)
                {
                    StudentId = value;
                }
            }
        }

        public string SSN
        {
            get { return SSN; }
            set
            {
                if (value != null)
                {
                    SSN = value;
                }
            }
        }

        public string Class
        {
            get { return Class; }
            set
            {
                if (value != null)
                {
                    Class = value;
                }
            }
        }


        public Student(string studentId, string name, string ssn, string @class)
        {
            StudentId = studentId;
            Name = name;
            SSN = ssn;
            Class = @class;
        }
    }

}