using System;

namespace MyLibrary
{
   public static class WriteAsBytes
    {
        public static void WriteBytes(params double[] values)
        {
            foreach (double val in values)
            {
                Console.WriteLine("Bytes of {0} in double:", val);
                byte[] bytes = BitConverter.GetBytes(val);
                WriteByteArray(bytes);
            }
        }
        public static void WriteBytes(int value)
        {
            Console.WriteLine("Bytes of {0} in int:", value);
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }
        public static void WriteByteArray(byte[] bytes)
        {
            foreach (byte b in bytes)
            {
                Console.WriteLine("0x{0:X}", b);
            }
            Console.WriteLine();
        }
    }
}
