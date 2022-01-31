using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Report salesReport = new Report();
            ReportFromExcel hrReport = new ReportFromExcel();

            ReportFactory reportFactory = new ReportFactory();
            reportFactory.CreateReportData(hrReport);

            List<Student> students = new List<Student>() {
                new  Student{ Name="Taylan Can", LanstName ="Hardal"},
                new  Student{ Name="Eray", LanstName ="Nurtekin"},
                new  Student{ Name="Ramazan", LanstName ="Köse"}
              };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            object obj = new Student { Name = "Orhan", LanstName = "Gencebay" };
            Console.WriteLine(obj.ToString());
        }
    }
}
