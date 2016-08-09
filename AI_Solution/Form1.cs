using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AI_Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ColorsContext = new cl_Data.cl_ColorContext("hi");
            var lcl_Color = new cl_Data.cl_Color() { Color = "Yellow" };
            ColorsContext.db_Colors.Add(lcl_Color);
            ColorsContext.SaveChanges();


            Close();
        }
    }
}
