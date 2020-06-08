using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RustRouletteHelper
{
    public partial class Form1 : Form
    {
        int since1 = 0;
        int since3 = 0;
        int since5 = 0;
        int since10 = 0;
        int since20 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch(txtIn.Text)
            {
                case "1":
                    since1 = 0;
                    lblSince1.ForeColor = Color.Goldenrod;
                    since3++;
                    since5++;
                    since10++;
                    since20++;
                    break;

                case "3":
                    since3 = 0;
                    lblSince3.ForeColor = Color.Red;
                    since1++;
                    since5++;
                    since10++;
                    since20++;
                    break;

                case "5":
                    since5 = 0;
                    lblSince5.ForeColor = Color.Red;
                    since1++;
                    since3++;
                    since10++;
                    since20++;
                    break;

                case "10":
                    since10 = 0;
                    lblSince10.ForeColor = Color.Red;
                    since1++;
                    since3++;
                    since5++;
                    since20++;
                    break;

                case "20":
                    since20 = 0;
                    lblSince20.ForeColor = Color.Red;
                    since1++;
                    since3++;
                    since5++;
                    since10++;
                    break;

                default:
                    MessageBox.Show("Enter a nubmer 1,3,5,10, or 20");
                    break;



            }
            updateBoard();
        }

        private void updateBoard()
        {
            lblSince1.Text = since1.ToString();
            lblSince3.Text = since3.ToString();
            lblSince5.Text = since5.ToString();
            lblSince10.Text = since10.ToString();
            lblSince20.Text = since20.ToString();

            if (since1 > 1)
                lblSince1.ForeColor = Color.Green;
            
            if (since3 > 1)
                lblSince3.ForeColor = Color.Goldenrod;
            if (since3 > 2)
                lblSince3.ForeColor = Color.Green;

            if (since5 > 2)
                lblSince5.ForeColor = Color.Goldenrod;
            if (since5 > 4)
                lblSince5.ForeColor = Color.Green;

            if (since10 > 6)
                lblSince10.ForeColor = Color.Goldenrod;
            if (since10 > 8)
                lblSince10.ForeColor = Color.Green;

            if (since20 > 14)
                lblSince20.ForeColor = Color.Goldenrod;
            if (since20 > 16)
                lblSince20.ForeColor = Color.Green;
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            since1 = 0;
            since3 = 0;
            since5 = 0;
            since10 = 0;
            since20 = 0;
            updateBoard();
            lblSince1.ForeColor = Color.Goldenrod;
            lblSince3.ForeColor = Color.Red;
            lblSince5.ForeColor = Color.Red;
            lblSince10.ForeColor = Color.Red;
            lblSince20.ForeColor = Color.Red;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.TopMost == false)
                this.TopMost = true;
            else
                this.TopMost = false;

        }
    }
}
