using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //SRP: Her nesne kendi işini yapmalı (bir işten sorumlu olmalı) 
            //Eğer bir sınıfta değişiklik yapmak için çok sebebiniz varsa prensibi İHLAL EDİYORSUNUZ!
            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            ProductBusiness productBusiness = new ProductBusiness();
            int affectedRow = productBusiness.AddProduct(name,price);
            string message = affectedRow > 0 ? "Başarılı" : "Başarısız";

            MessageBox.Show(message);

        }

      
    }
}
