using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1A2B_LAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        int[] com = new int[10];
        int[] player1 = new int[3];
        int Ax;
        int Bx;

        void AB_lab()
        {
            int[] x = new int[3];
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                x[0] = Int32.Parse(textBox1.Text);
                x[1] = Int32.Parse(textBox2.Text);
                x[2] = Int32.Parse(textBox3.Text);
                for (int i = 0; i < 3; i++)
                {
                    if (player1[i] == x[0] && i != 0) { Bx++; }
                    else if (player1[i] == x[0] && i == 0) { Ax++; }
                    if (player1[i] == x[1] && i != 1) { Bx++; }
                    else if (player1[i] == x[1] && i == 1) { Ax++; }
                    if (player1[i] == x[2] && i != 2) { Bx++; }
                    else if (player1[i] == x[2] && i == 2) { Ax++; }
                }
            }
            if(Ax == 3) { label4.ForeColor = System.Drawing.Color.Red; }
            else if(Ax >0) { label4.ForeColor = System.Drawing.Color.DarkOrange; }
            else if(Bx > 0) { label4.ForeColor = System.Drawing.Color.Blue; }
            else { label4.ForeColor = System.Drawing.Color.Black; }
        }
        /// <summary>
        /// 元件狀態統一變化
        /// </summary>
        void element_Enab()
        {
            button1.Enabled = !button1.Enabled;
            button2.Enabled = !button2.Enabled;
            button3.Enabled = !button3.Enabled;
            textBox1.Enabled = !textBox1.Enabled;
            textBox2.Enabled = !textBox2.Enabled;
            textBox3.Enabled = !textBox3.Enabled;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.ForeColor = System.Drawing.Color.Black;
        }

        private void startbt_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int x;
            Random rnd = new Random();
            for (int i = 0; i<3 ; i++)
            {
                while(true)
                {
                    x = rnd.Next(1, 9);
                    if(com[x] == 0)
                    { 
                        com[x] = 1;
                        break;
                    }
                }
                player1[i] = x;
                label1.Text = label1.Text + player1[i].ToString();
            }
            element_Enab();
        }

        private void resbt_Click(object sender, EventArgs e)
        {
            if (!button1.Enabled)
            { element_Enab(); }
            for(int i=0;i<=9;i++)
            { com[i] = 0; }
            for(int i=0;i<3;i++)
            { player1[i] = 0; }
            label1.Text = "1A2B";
            label3.Text = "";
            label4.Text = "";
        }

        private void Lockbt_Click(object sender, EventArgs e)
        {
            
            AB_lab();
            lab_update();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        /// <summary>
        /// label 刷新
        /// </summary>
        void lab_update()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" )
            {
                label3.Text = label3.Text + textBox1.Text + textBox2.Text + textBox3.Text + "\r\n";
                label4.Text = label4.Text + Ax + "A" + Bx + "B" + "\r\n";
                groupBox1.Text = Ax + "A" + Bx + "B";
                Ax = 0;
                Bx = 0;
            }
        }
    }
}
