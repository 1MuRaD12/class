using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           
            student student = new student("Murad","Aslanov","228A4",99);

            student.field();
           
        }
    }
    class student
    {
        public string name;
        public string surname;
        public string group;
        public byte point;

        public student(string name,string surname,string group, byte point)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.point = point;
        }
        
        
        public void field ()
        {
            Console.WriteLine($"name:{name}, surname:{surname}, group:{group}, point:{point}");
        }
        public void Point (int num)
        {
            Boolean Graduated = false;
            num = 0;
            if (num < 34)
            {
                Console.WriteLine("can not enter the exam");
            }
            else if (num > 34 && num <= 50)
            {
                Console.WriteLine("can take the exam");
            }
           

        }
        public void graduated(int number)
        {
            Boolean Graduated = true;
            int num = 0;
            if (num > 50 && num <= 100)
            {
                Console.WriteLine("graduated");
            }
            else if (num <= 50)
            {
                Console.WriteLine("not graduated");
            }
        }
       
    }
}
