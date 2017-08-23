using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace binary_read_and_write
{
    class Class1
    {
        public void Write()
        {
            int[] a = new int[] { 1, 5, 6, 8, 4, 7, 36, 98 };
            using (BinaryWriter binwriter = new BinaryWriter(File.Open("file.bin", FileMode.Create)))
            {
                foreach (int i in a)
                {
                    binwriter.Write(i);
                }
            }
        }
        public void read()
        {
            using (BinaryReader b = new BinaryReader(File.Open("file.bin", FileMode.Open)))
            {
                int pos = 0;
                int length = (int)b.BaseStream.Length;
                while (pos < length)
                {
                    int v = b.ReadInt32();
                    Console.WriteLine(v);
                    pos += sizeof(int);
                }
            }
            Console.ReadLine();
        }
    }
    class myclass
    {
        static void Main()
        {
            Class1 rw = new Class1();
            rw.Write();
            rw.read();

        }
    }
}
