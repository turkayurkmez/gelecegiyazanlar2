using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreading
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            CheckForIllegalCrossThreadCalls =false;
            InitializeComponent();
        }

        private async void buttonLoop_Click(object sender, EventArgs e)
        {
           await  startLoop();
            MessageBox.Show("naptın");
        }

        private async Task startLoop()
        {
            int output = 0;
            await  Task.Run(() =>
             {
                 for (int i = 0; i < 10000; i++)
                 {
                     labelResult.Text = i.ToString();
                     output = i;
                 }
             });

            MessageBox.Show(output.ToString());
            
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona tıklandı");
        }
    }
}
