using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            make_lable();

        }
        public void make_lable()
        {
            int top, left, height, width;
            top = this.Height / 10;
            left = this.Width / 10;
            height = this.Height / 10;
            width = this.Width / 10;
            make_buttom(top,left,height,width);
            Label t = new Label();
            t.Top = top;
            t.Left = 4 * left;
            t.Name = "txtdisplay";
            t.Text = "its a timer";
            this.Controls.Add(t);
        }
        public void make_buttom(int top, int left, int height, int width)
        {
            for(int i =0;i<=2;i++)
            {
                Button b = new Button();
                b.Top = 4*top;
                b.Left = (3+i)*left;
                b.Height = height;
                b.Width = width;
                this.Controls.Add(b);
            }
        }

    }
}
