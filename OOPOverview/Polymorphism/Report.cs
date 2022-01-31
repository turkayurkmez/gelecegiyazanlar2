using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class Report
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual void GetData()
        {
            Console.WriteLine("Get data from ms sql");
        }

        public void Send()
        {

        }


    }

    public class ReportFromExcel : Report
    {
        public override  void GetData()
        {
            Console.WriteLine("Get data from excel");
        }
    }

    public class ReportFactory
    {
        public void CreateReportData(Report report)
        {
            report.GetData();
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string LanstName { get; set; }

        public override string ToString()
        {
            return $"{Name} {LanstName}";
        }
    }
}
