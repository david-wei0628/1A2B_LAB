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
            InputNumberA.Enabled = false;
            InputNumberB.Enabled = false;
            InputNumberC.Enabled = false;
            Resbt.Enabled = false;
            Lockbt.Enabled = false;
        }

        int[] com = new int[10];
        int[] player1 = new int[3];
        int ACount;
        int BCount;

        void OutputAnswer()
        {
            int[] x = new int[3];
            if (IsAllTextBoxHasValue())
            {
                x[0] = Int32.Parse(InputNumberA.Text);
                x[1] = Int32.Parse(InputNumberB.Text);
                x[2] = Int32.Parse(InputNumberC.Text);
                for (int i = 0; i < 3; i++)
                {
                    if (player1[i] == x[0] && i != 0)
                        BCount++;
                    else if (player1[i] == x[0] && i == 0)
                        ACount++;
                    if (player1[i] == x[1] && i != 1)
                        BCount++;
                    else if (player1[i] == x[1] && i == 1)
                        ACount++;
                    if (player1[i] == x[2] && i != 2)
                        BCount++;
                    else if (player1[i] == x[2] && i == 2)
                        ACount++;
                }
            }
            if (ACount == 3)
                OutputCourse.ForeColor = Color.Red;
            else if (ACount > 0)
                OutputCourse.ForeColor = Color.DarkOrange;
            else if (BCount > 0)
                OutputCourse.ForeColor = Color.Blue;
            else
                OutputCourse.ForeColor = Color.Black;
        }
        /// <summary>
        /// 元件狀態統一變化
        /// </summary>
        void SetButtonEnableStatus()
        {
            Startbt.Enabled = !Startbt.Enabled;
            Resbt.Enabled = !Resbt.Enabled;
            Lockbt.Enabled = !Lockbt.Enabled;
        }

        void SetTextBoxEnableStatus()
        {
            InputNumberA.Enabled = !InputNumberA.Enabled;
            InputNumberB.Enabled = !InputNumberB.Enabled;
            InputNumberC.Enabled = !InputNumberC.Enabled;
        }

        void InitTextBoxContext()
        {
            InputNumberA.Text = "";
            InputNumberB.Text = "";
            InputNumberC.Text = "";
        }

        void InitLableDisplayColor()
        {
            OutputCourse.ForeColor = Color.Black;
        }

        private void Startbt_Click(object sender, EventArgs e)
        {
            ComNumber.Text = "";
            int x;
            var rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    x = rnd.Next(1, 9);
                    if (com[x] == 0)
                    {
                        com[x] = 1;
                        break;
                    }
                }
                player1[i] = x;
                ComNumber.Text = ComNumber.Text + player1[i].ToString();
            }
            SetButtonEnableStatus();
            SetTextBoxEnableStatus();
            InitTextBoxContext();
            InitLableDisplayColor();
        }

        private void Resetbt_Click(object sender, EventArgs e)
        {
            if (!Startbt.Enabled)
            {
                SetButtonEnableStatus();
                SetTextBoxEnableStatus();
                InitTextBoxContext();
                InitLableDisplayColor();
            }
            for (int i = 0; i <= 9; i++)
                com[i] = 0;
            for (int i = 0; i < 3; i++)
                player1[i] = 0;
            ComNumber.Text = "1A2B";
            InputNumberCourse.Text = "";
            OutputCourse.Text = "";
        }

        private void Lockbt_Click(object sender, EventArgs e)
        {

            OutputAnswer();
            Label_update();
            InitTextBoxContext();
        }

        /// <summary>
        /// label 刷新
        /// </summary>
        void Label_update()
        {
            if (IsAllTextBoxHasValue())
            {
                InputNumberCourse.Text = InputNumberCourse.Text + InputNumberA.Text + InputNumberB.Text + InputNumberC.Text + "\r\n";
                OutputCourse.Text = OutputCourse.Text + ACount + "A" + BCount + "B" + "\r\n";
                groupBox1.Text = ACount + "A" + BCount + "B";
                ACount = 0;
                BCount = 0;
            }
        }

        bool IsAllTextBoxHasValue()
        {
            if (InputNumberA.Text != "" && InputNumberB.Text != "" && InputNumberC.Text != "")
                return true;
            else
                return false;
        }

    }
}
