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
            make_timer();

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

            t.Top = 2*top;
            t.Left = 4 * left;
            t.Name = "txtdisplay";
            t.Text = "its a timer";
            this.Controls.Add(t);
        }
        public void make_buttom(int top, int left, int height, int width)
        {
            string[] names_button = {"reset","continue","pause"};
            for(int i =1;i<=3;i++)
            {
                Button b = new Button();
                b.Text = names_button[i-1];
                b.Top = 4*top;
                b.Height = height;
                b.Width = 2*width;
                b.Left = ((2*i)*left);
                this.Controls.Add(b);
            }
        }
        public void make_timer()
        {

        }

    }
}
