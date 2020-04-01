using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            myClass myclass = new myClass("John", "Nørregade");
            myClass nytObjekt = new myClass("Gleb" , "Et sted i Danmark");
            myClass etTilObjekt = new myClass("Simon", "København");

        }
    }
}
