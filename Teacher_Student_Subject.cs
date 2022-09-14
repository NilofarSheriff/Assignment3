using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
   
       
        public class Teacher
        {
            public string Name { get; set; }
            public string Class { get; set; }

            public string Subject { get; set; }

            
        }
        public class Student 
        {
            public string Name { get; set; }
            public string Class { get; set; }
           
            public Student()
            {

            }
        }
        public class Subject 
        {
            public string Name { get; set; }
            public string Class { get; set; }
            public string SubjectId { get; set; }
           

        }
    
}
