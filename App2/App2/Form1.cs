using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread T = new Thread(new ThreadStart(StartForm));
            T.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            T.Abort();
        }

        public void StartForm()
        {
            Application.Run(new frmSplash());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
