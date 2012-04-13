using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Das ist ein Test, haha");
            Console.WriteLine("Na klar!");
            Console.WriteLine("Noch ein Test!");
            Console.WriteLine("Unbhkb hkd noch ein Test!");
            int h = 5 + 1;
            Console.WriteLine(h);

            erwin er = new erwin();
            er.A = 5;
            er.B = 10;
            Console.WriteLine(er.bere().ToString());

            werner wer = new werner();
            wer.A = 5;
            wer.B = 10;
            Console.WriteLine(wer.bere().ToString());

            Console.WriteLine(wer.bere().ToString());

            Console.ReadLine();
        }

        struct erwin
        {
            private int a;
            public int A
            {
              get { return a; }
              set { a = value; }
            }

            private int b;
            public int B
            {
              get { return b; }
              set { b = value; }
            }

            public int bere()
            {
                return this.A + this.B;
            }
        }

        struct werner
        {
            private int a;
            public int A
            {
                get { return a; }
                set { a = value; }
            }

            private int b;
            public int B
            {
                get { return b; }
                set { b = value; }
            }

            public int bere()
            {
                return this.A * this.B;
            }
        }
    }
}
