using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_iniciar_Click(object sender, EventArgs e)
        {
            lbl_meu.Text = " MEU ";
            lbl_brasil.Text = " BRASIL ";
            lbl_brasileiro.Text = " BRASILEIRO ";

            await Task.Delay(1000);
            lbl_meu.ForeColor = Color.White;
            lbl_meu.BackColor = Color.Blue;

            await Task.Delay(1000);
            lbl_brasil.ForeColor = Color.Green;
            lbl_brasil.BackColor = Color.Yellow;

            await Task.Delay(1000);
            lbl_brasileiro.ForeColor = Color.Yellow;
            lbl_brasileiro.BackColor = Color.Green;

        }
    }
}
