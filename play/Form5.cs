using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace play
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            List<Player> players = DbConnection.GetBestPlayers(10);
            foreach (Player item in players)
            {
                dataGridView1.Rows.Add(item.Id, item.Name, item.Schore, item.BestTime);

            }
        }
    }
}
