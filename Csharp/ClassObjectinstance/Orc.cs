using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectinstance
{
    internal class Orc
    {
        public string Name;
        public int Old;
        public double Height;
        public double Wegiht;
        public char Gender;

        public void SayMyName()
        {
            Console.WriteLine($"이름 : {Name}");
        }

        public void SayMyinfo()
        { 
            Console.WriteLine($"나이 : {Old}");
            Console.WriteLine($"키 : {Height}");
            Console.WriteLine($"몸무게 : {Wegiht}");
            Console.WriteLine($"성별 : {Gender}");
        }
    }
}
