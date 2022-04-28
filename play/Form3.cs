using System;
using System.Windows.Forms;

namespace play
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string PlayerName { get; set; }

        public int BestTime { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Player item = new Player(PlayerName);
            item.BestTime = BestTime;
            DbConnection.saveRecord(item);
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text += PlayerName;
            label2.Text = String.Format("минут {0} секунд {1}", BestTime / 60, BestTime % 60);
        }
    }
}
