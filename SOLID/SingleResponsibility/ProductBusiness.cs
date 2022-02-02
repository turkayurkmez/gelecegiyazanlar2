using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
   public class ProductBusiness
    {
        public int AddProduct(string name, decimal price)
        {
            string connectionString = @"Data Source=(localdb)\Mssqllocaldb;Initial Catalog=innovaEAdb;Integrated Security=True";

            string commandText="INSERT into Products (Name, Price, CreatedOn,UpdateOn) values (@name,@price,GetDate(),GetDate())";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@name", name);
            parameters.Add("@price", price);

            DbHelper dbHelper = new DbHelper(connectionString);
            int result = dbHelper.Execute(commandText, parameters);            

            return result;

        }
    }
}
