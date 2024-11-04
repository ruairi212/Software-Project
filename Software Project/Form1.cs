using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Project
{
    public partial class Form1 : Form
    {
        private Rectangle button_original_rectangle;
        private Rectangle original_form_size;
        Request_Event re= new Request_Event();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            original_form_size = new Rectangle(this.Location.X,this.Location.Y, this.Width,this.Height);
            button_original_rectangle = new Rectangle(button1.Location.X,button1.Location.Y,button1.Width,button1.Height);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            re.Show();
        }
        private void resize_math(Rectangle r, Control c) 
        {
            float x_ratio = (float)(this.Width) / (float)(original_form_size.Width);
            float y_ratio = (float)(this.Height)/ (float)(original_form_size.Height);

            int new_x = (int)(r.Width * x_ratio);
            int new_y = (int)(r.Height * y_ratio);

            int new_width = (int)(r.Width * x_ratio);
            int new_height = (int)(r.Height * y_ratio);

            c.Location = new Point(new_x, new_y);
            c.Size = new Size(new_width, new_height);  
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_math(button_original_rectangle, button1);
        }
    }
}
