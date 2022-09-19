using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._7
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("비밀번호를 입력하세요.");
        }


        public int xPt, yPt;
        public static readonly int MOVE = 10;
        private void button3_KeyUp(object sender, KeyEventArgs e)
        {
            this.xPt = this.button3.Location.X;
            this.yPt = this.button3.Location.Y;
            switch(e.KeyCode)
            {
                case Keys.Left:
                    xPt -= MOVE;
                    break;
                case Keys.Right:
                    xPt += MOVE;
                    break;
                case Keys.Up:
                    yPt -= MOVE;
                    break;
                case Keys.Down:
                    yPt += MOVE;
                    break;
            }
            button3.Text = e.KeyCode.ToString();
            button3.Location = new Point(xPt, yPt);
        }
    }
}
