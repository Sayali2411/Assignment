// public access modifier
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class PublicModifier
    {
         class Student
        {

             public int rollNo;
            public string name;

           public Student(int r, string n)
            {
                rollNo = r;
                name = n;
            }

            public int getRollNo()
            {
                return rollNo;
            }
            public string getName()
            {
                return name;
            }
        }

        class Program
        {

            static void Main(string[] args)
            {
                
                Student S = new Student(1, "Sayali");

              
                Console.WriteLine("Roll number: {0}", S.rollNo);
                Console.WriteLine("Name: {0}", S.name);

                Console.WriteLine();

                
                Console.WriteLine("Roll number: {0}", S.getRollNo());
                Console.WriteLine("Name: {0}", S.getName());
            }
        }
    }
}

