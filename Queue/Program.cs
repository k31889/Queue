using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Q s = new Q(5);
            s.Add("Hello");
            s.Print();
        }
    }
}
