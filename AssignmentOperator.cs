using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class AssignmentOperator
    {
        public static void Main(string[] args)
            {
                int x = 20;
                x += 10;
                Console.WriteLine("Add Assignment: " + x);
                x *= 4;
                Console.WriteLine("Multiply Assignment: " + x);
                x %= 7;
                Console.WriteLine("Modulo Assignment: " + x);
                x &= 10;
                Console.WriteLine("Bitwise And Assignment: " + x);
                x ^= 12;
                Console.WriteLine("Bitwise XOR Assignment: " + x);
                x >>= 3;
                Console.WriteLine("Right Shift Assignment: " + x);
                Console.WriteLine("Press Enter Key to Exit..");
                Console.ReadLine();
            }
        }
    }


