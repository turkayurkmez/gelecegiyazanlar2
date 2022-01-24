using System;

namespace ClassVSObject
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int yas = 42;
            bool olurMu = true;
            if (yas==5)
            {

            }

            Person worker = new Person();
            worker.Name = "Murat";
            worker.Age = 38;
            worker.LastName = "Pirinççi";

            Person cooker = worker;
            cooker.Name = "Filiz";
            cooker.Age = 24;



            Console.WriteLine(worker.Name);
        }
    }
}
