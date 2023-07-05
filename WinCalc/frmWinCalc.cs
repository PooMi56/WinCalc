using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc
{
    public partial class frmWinCalc : Form
    {
        private string number1 = "", number2 = "", answer = "";

        private void AddToDisplay(string numberSymbol)
        {
            if (this.txtDisPlay.Text == "0")
            {
                //this.txtDisPlay.Text = numberSymbol;

                if (numberSymbol == ".")
                {
                    this.txtDisPlay.Text += numberSymbol;
                }
            
                this.txtDisPlay.Text = numberSymbol;
            }
            else
            {
                this.txtDisPlay.Text += numberSymbol;
            }
        }
        public frmWinCalc()
        {
            InitializeComponent();
        }

        private void frmWinCalc_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnClear_Click(sender, e);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("0");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("3");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("2");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("1");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("6");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("5");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("4");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("9");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("8");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("7");
        }

        private void Bntdot_Click(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void bntmultiply_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void mnuExitItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void mnuAboutItem_Click(object sender, EventArgs e)
        {
            frmAbout objAbout = new frmAbout();

            objAbout.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.number1 = this.number2 = this.answer = "0";
            this.txtDisPlay.Text = "0";
            //this.symbol = '0';
            //this.dotStatus = false;
        }
    }
}
