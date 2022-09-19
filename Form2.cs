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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button2.BackColor=colorDialog1.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }

        private void Form2_MouseEnter(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);
            string msg = "Mouse Position:" + mousePoint.X + "," + mousePoint.Y;
            MessageBox.Show(msg);
        }

        private void UpdateEventLabels(string msg,int x,int y,MouseEventArgs e)
        {
            string message = string.Format("{0} X:{1},Y:{2}", msg, x, y);
            string eventMsg = DateTime.Now.ToShortTimeString();
            eventMsg += "" + message;
            listBox1.Items.Insert(0,eventMsg);
            listBox1.TopIndex = 0;
            string mouseInfo;
            if (e!=null)
            {
                mouseInfo = string.Format("Clicks:{0},Delta:{1}," + "Buttons:{2}", e.Clicks, e.Delta, e.Button.ToString());
            }
            else
            {
                mouseInfo = string.Format("Clicks:{0}", msg);
            }
            label1.Text = mouseInfo;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateEventLabels("(ListBox)MouseDown", e.X, e.Y, e);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Point mousePoint=PointToClient(MousePosition) ;
            UpdateEventLabels("(ListBox)DoubleClick", mousePoint.X, mousePoint.Y,null);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left==e.Button)
            {
                Graphics g = CreateGraphics();
                Point pt1 = new Point(e.X, e.Y);
                Rectangle r = new Rectangle(e.X - 1, e.Y - 1, 2, 2);
                Brush br = Brushes.Black;
                if (radioButton1.Checked == true)
                {
                    br = Brushes.Black;
                }
                else if (radioButton2.Checked == true)
                {
                    br = Brushes.Red;
                }
                g.FillRectangle(br, r);
            }
        }
    }
}
