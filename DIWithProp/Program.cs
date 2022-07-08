using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIWithProp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentBussinessLayer objec = new StudentBussinessLayer();
            objec.StudData = new StudentDataAccessLayer();
            var result = objec.StudData.GetStudents();
            Console.ReadLine();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Standard { get; set; }
    }

    public interface IStudentDataAccessLayer
    {
        List<Student> GetStudents();
    }

    public class StudentDataAccessLayer:IStudentDataAccessLayer
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Id=1,Name="Neha",Standard="A"});
            students.Add(new Student() { Id=2,Name="Sneha",Standard="A"});
            students.Add(new Student() { Id=3,Name="Nehal",Standard="B"});
            students.Add(new Student() { Id=4,Name="Neharica",Standard="A"});
            return students;
        }
    }

    public class StudentBussinessLayer
    {
        private IStudentDataAccessLayer obj1;
        public IStudentDataAccessLayer StudData
        {
        
            set 
            {
                obj1 = value; 
            }
            get 
            {
                if (obj1!=null)
                {
                    return obj1;

                }
                else
                {
                    throw new Exception("Object not passed to the property");
                }
            } 
        }
    }





}
