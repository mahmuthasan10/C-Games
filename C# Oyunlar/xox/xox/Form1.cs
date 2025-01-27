using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void XOXtiklama(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            if (label1.Text == "X")
            {
                bt.Text = "X";
                bt.BackColor = Color.Red;
                bt.Enabled = false;
                label1.Text = "O";
                

            }
            else
            {
                bt.Text = "O";
                bt.BackColor = Color.Blue;
                bt.Enabled = false;
                label1.Text = "X";
                
            }

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                oyunBitis();
               
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                oyunBitis();

            }

            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                oyunBitis();

            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                oyunBitis();

            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                oyunBitis();

            }

            if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                oyunBitis();

            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                oyunBitis();

            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("KAZANAN : X");
                oyunBitis();

            }

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                oyunBitis();

            }

            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                oyunBitis();

            }

            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                oyunBitis();

            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                oyunBitis();

            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                oyunBitis();

            }

            if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                oyunBitis();

            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                oyunBitis();

            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("KAZANAN : O");
                oyunBitis();

            }

            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" &&
                button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("BERABERE");
                oyunBitis();
            }

        }

private void oyunBitis()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;




        }

    }
}
