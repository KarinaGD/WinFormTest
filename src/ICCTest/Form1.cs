using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Testing github
namespace ICCTest
{
    public partial class Form1 : Form
    {
        //Conflict
        public Form1()
        {
            InitializeComponent();
        }

        private void txtFizz_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBuzz_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Multiples mult = new Multiples();
            txtFizz.Text = mult.multiplesThree();
            txtBuzz.Text = mult.multiplesFive();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
