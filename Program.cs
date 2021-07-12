using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Euros o Libras?");
           string t = Console.ReadLine();

           static void test()
           {
               Console.WriteLine("Funciona....");
           }

           test();

           if (t == "Euros")
           {
               Console.WriteLine("Cuantas libras tienes?");
               string libras = Console.ReadLine();
               float lib = float.Parse(libras);
               Console.WriteLine(String.Format("Tienes {0} Euros", lib * 1.17));
               


           }
           if (t == "Libras")
           {
                Console.WriteLine("Cuantos euros tienes?");
               string euros = Console.ReadLine();
               float eur = float.Parse(euros);
               Console.WriteLine(String.Format("Tienes {0} Libras", eur * 0.83)); 
           }
           

        }
    }
}
