using System;

namespace Phase1Section3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static public void doApp()
        {
            bool xbool = true;
            byte xbyte = 250;
            sbyte xsbyte = -100;
            char xchar = 'a';
            decimal xdecimal = 87.9M;
            double xdouble = 651.09;
            float xfloat = 465.1f;
            int xint = -8909;
            uint xuint = 91881;
            long xlong = -1313131312;
            ulong xulong = 01919181;
            object xobject = new object();
            short xshort = -19;
            ushort xushort = 19;
            string xstring = "name";

            if (xbool == true && xbyte < 255)
                Console.WriteLine("This expression evaluates to true");

            // Using the remaining variables to resolve the warning
            Console.WriteLine(xsbyte);
            Console.WriteLine(xchar);
            Console.WriteLine(xdecimal);
            Console.WriteLine(xdouble);
            Console.WriteLine(xfloat);
            Console.WriteLine(xint);
            Console.WriteLine(xuint);
            Console.WriteLine(xlong);
            Console.WriteLine(xulong);
            Console.WriteLine(xobject);
            Console.WriteLine(xshort);
            Console.WriteLine(xushort);
            Console.WriteLine(xstring);
        }
    }
}