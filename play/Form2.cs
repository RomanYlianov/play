using System;
using System.Windows.Forms;

namespace play
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }
    }
}
