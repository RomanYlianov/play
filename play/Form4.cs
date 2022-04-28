using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace play
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        public List<string> PlayerNames = new List<string>();

       

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user1Name = player1.Text;
            string user2Name = player2.Text;
            if (user1Name!=null && user2Name != null)
            {
                PlayerNames.Add(user1Name);
                PlayerNames.Add(user2Name);
                Close();
            }
        }
    }
}
