using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace manutVeiculo
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form6 = new Form6();
            form6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var form2 = new Form2();
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.ShowDialog();
        }

        private void btnConsultaTroca_Click(object sender, EventArgs e)
        {
            var form7 = new Form7();
            form7.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form9 = new Form9();
            form9.ShowDialog();
        }
    }
    
}
