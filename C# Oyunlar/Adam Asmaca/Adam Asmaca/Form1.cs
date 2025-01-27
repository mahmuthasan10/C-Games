using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int Move;
        int Mouse_X;
        int Mouse_Y;

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        int hataSayac = 0;
        String kelime = ("sehir");
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("Resimler/" + hataSayac + ".png");
            label3.Text = kelime;

            FileStream fs = new FileStream("Kelimeler/" + label3.Text + ".txt", FileMode.Open, FileAccess.Read);
        }
    }
}
