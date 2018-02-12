using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAPServiceStudentProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.

    

    [ServiceContract]
    public interface IService1
    {
        
        [OperationContract]

        void AddStudent(Student student);

        Student FindStudent(String ID);

        void GetAllStudent(Student student);

        Student RemoveStudent(int index);

        void EditStudent(int index, Student s);

    }

}
