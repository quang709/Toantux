using System;

namespace toantu
{
    class Program
    {
        float Area(float a, float b)
        {
            float result = a * b;
            return result;
        }
        static void Main(String[] args)
        {

            float width;
            float height;
            float ketqua;
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            Program n = new Program();
            ketqua = n.Area(width, height);
            Console.WriteLine("Ket qua: {0}", ketqua);
            Console.ReadLine();

        }
    }
}
