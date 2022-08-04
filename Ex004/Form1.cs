using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex004
{
    public partial class Form1 : Form
    {
        float num = 0f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_inteiro_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            
            lbl_valor.Text = $"Você digitou o valor {num:N3}";
            lbl_inteiro.Text = $"A parte inteira é {(int)num}";
            lbl_arredondado.Text = $"Arredondando, temos {Convert.ToInt16(num)}";
        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {
           num = Convert.ToSingle(txt_num.Text);
        }
    }
}
