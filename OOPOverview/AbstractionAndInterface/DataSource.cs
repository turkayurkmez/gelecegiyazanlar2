using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterface
{
   public abstract class DataSource
    {
        public abstract void Connect();        
            //Her DataSource nesnesinin Connect () metodu BAMBAŞKA ÇALIŞIYOR 

        public  void GetDataSourceInfo()
        {
            Console.WriteLine("veri kaynağının bilgileri....");
        }

        public bool State { get; set; }
        //public abstract void Save(object data);
        public abstract object Read();

    }

    public interface IRecordable
    {
        void Save(object data);
    }

    public class XmlDataSource : DataSource
    {
        public override void Connect()
        {
            throw new NotImplementedException();
        }

        public override object Read()
        {
            throw new NotImplementedException();
        }

     
    }

    public class ExcelDataSource : DataSource, IRecordable
    {
        public override void Connect()
        {
            throw new NotImplementedException();
        }

        public override object Read()
        {
            throw new NotImplementedException();
        }

        public  void Save(object data)
        {
            throw new NotImplementedException();
        }
    }

    public class ApiDataSource : DataSource, IRecordable
    {
        public override void Connect()
        {
            throw new NotImplementedException();
        }

        public override object Read()
        {
            throw new NotImplementedException();
        }

        public  void Save(object data)
        {
            throw new NotImplementedException();
        }
    }

    public class SQLDataSourse : DataSource, IRecordable
    {
        public override void Connect()
        {
            throw new NotImplementedException();
        }

        public override object Read()
        {
            throw new NotImplementedException();
        }

        public  void Save(object data)
        {
            throw new NotImplementedException();
        }
    }

    public class RecordData
    {
        public void RecordDataToSource(object data, IRecordable recordable)
        {
            recordable.Save(data);

        }
    }


}
