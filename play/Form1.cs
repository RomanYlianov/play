using play.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace play
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private int time1 = 0;

        private int time2 = 0;

        private bool IsFirstPlayer = true;

        List<string> players = new List<string>();

       //List<int> positions = new List<int>();

        int[,] States = new int[3, 3];


        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            players = form.PlayerNames;
            SetVisible(true);
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetVisible(true);
            if (IsFirstPlayer)
            {
                timer1.Stop();
            }
            else
            {
                timer2.Stop();
            }
            Clear();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time1++;
            string text = "мин " + time1 / 60 + " сек " + time1 % 60;
            time1Player.Text = "Время игры " + text;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time2++;
            string text = "мин " + time2 / 60 + " сек " + time2 % 60;
            time2player.Text = "Время игры " + text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            step(1);
            CheckWinner();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            step(3);
            CheckWinner();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            step(4);
            CheckWinner();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            step(2);
            CheckWinner();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            step(5);
            CheckWinner();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            step(6);
            CheckWinner();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            step(7);
            CheckWinner();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            step(8);
            CheckWinner();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            step(9);
            CheckWinner();
        }
        private void step(int n)
        {
            // PrintArray();
            IsFirstPlayer = !IsFirstPlayer;
           
            
            
                if (IsFirstPlayer)
                {
                    playerinfo.Text = players[0];
                }
                else
                {
                    playerinfo.Text = players[1];
                }

            if (IsFirstPlayer)
            {
                timer1.Start();
                timer2.Stop();
                //positions.Remove(n - 1);
                switch (n)
                {
                    case 1:
                        pictureBox1.Image = ResizeBitmap(new Bitmap(Resources.zero), 60, 60);
                        SetValue(0, 1);
                        break;
                    case 2:
                        pictureBox2.Image = ResizeBitmap(new Bitmap(Resources.zero), 60, 60);
                        SetValue(1, 1);
                        break;
                    case 3:
                        pictureBox3.Image = ResizeBitmap(new Bitmap(Resources.zero), 60, 60);
                        SetValue(2, 1);
                        break;
                    case 4:
                        pictureBox4.Image = ResizeBitmap(new Bitmap(Resources.zero), 60, 60);
                        SetValue(3, 1);
                        break;
                    case 5:
                        pictureBox5.Image = ResizeBitmap(new Bitmap(Resources.zero), 60, 60);
                        SetValue(4, 1);
                        break;
                    case 6:
                        pictureBox6.Image = ResizeBitmap(new Bitmap(Resources.zero), 60, 60);
                        SetValue(5, 1);
                        break;
                    case 7:
                        pictureBox7.Image = ResizeBitmap(new Bitmap(Resources.zero), 60, 60);
                        SetValue(6, 1);
                        break;
                    case 8:
                        pictureBox8.Image = ResizeBitmap(new Bitmap(Resources.zero), 60, 60);
                        SetValue(7, 1);
                        break;
                    case 9:
                        pictureBox9.Image = ResizeBitmap(new Bitmap(Resources.zero), 60, 60);
                        SetValue(8, 1);
                        break;

                }
            }
            else
            {
                //positions.Remove(n - 1);
                timer1.Stop();
                timer2.Start();
                switch (n)
                {
                    case 1:
                        pictureBox1.Image = ResizeBitmap(new Bitmap(Resources.cross), 60, 60);
                        SetValue(0, 2);
                        break;
                    case 2:
                        pictureBox2.Image = ResizeBitmap(new Bitmap(Resources.cross), 60, 60);
                        SetValue(1, 2);
                        break;
                    case 3:
                        pictureBox3.Image = ResizeBitmap(new Bitmap(Resources.cross), 60, 60);
                        SetValue(2, 2);
                        break;
                    case 4:
                        pictureBox4.Image = ResizeBitmap(new Bitmap(Resources.cross), 60, 60);
                        SetValue(3, 2);
                        break;
                    case 5:
                        pictureBox5.Image = ResizeBitmap(new Bitmap(Resources.cross), 60, 60);
                        SetValue(4, 2);
                        break;
                    case 6:
                        pictureBox6.Image = ResizeBitmap(new Bitmap(Resources.cross), 60, 60);
                        SetValue(5, 2);
                        break;
                    case 7:
                        pictureBox7.Image = ResizeBitmap(new Bitmap(Resources.cross), 60, 60);
                        SetValue(6, 2);
                        break;
                    case 8:
                        pictureBox8.Image = ResizeBitmap(new Bitmap(Resources.cross), 60, 60);
                        SetValue(7, 2);
                        break;
                    case 9:
                        pictureBox9.Image = ResizeBitmap(new Bitmap(Resources.cross), 60, 60);
                        SetValue(8, 2);
                        break;

                }

            }
            


        }


        
        void SetValue(int n, int m)
        {
            int i = n / 3;
            int j = n % 3;
            States[i, j] = m;
        }

        //empty = 0, zero = 1, cross =2
        private void CheckWinner()
        {
            // PrintArray();
            Form3 form = new Form3();
            bool flag1 = (States[0, 0] == 2 && States[0, 1] == 2 && States[0, 2] == 2)
                || (States[1, 0] == 2 && States[1, 1] == 2 && States[1, 2] == 2)
                || (States[2, 0] == 2 && States[2, 1] == 2 && States[2, 2] == 2)
                || (States[0, 0] == 2 && States[1, 0] == 2 && States[2, 0] == 2)
                || (States[0, 1] == 2 && States[1, 1] == 2 && States[2, 1] == 2)
                || (States[0, 2] == 2 && States[1, 2] == 2 && States[2, 2] == 2)
                || (States[0, 0] == 2 && States[1, 1] == 2 && States[2, 2] == 2)
                || (States[0, 2] == 2 && States[1, 1] == 2 && States[2, 0] == 2);
            bool flag2 = (States[0, 0] == 1 && States[0, 1] == 1 && States[0, 2] == 1)
              || (States[1, 0] == 1 && States[1, 1] == 1 && States[1, 2] == 1)
              || (States[2, 0] == 1 && States[2, 1] == 1 && States[2, 2] == 1)
              || (States[0, 0] == 1 && States[1, 0] == 1 && States[2, 0] == 1)
              || (States[0, 1] == 1 && States[1, 1] == 1 && States[2, 1] == 1)
              || (States[0, 2] == 1 && States[1, 2] == 1 && States[2, 2] == 1)
              || (States[0, 0] == 1 && States[1, 1] == 1 && States[2, 2] == 1)
              || (States[0, 2] == 1 && States[1, 1] == 1 && States[2, 0] == 1);
            bool flag3 = States[0, 0] > 0 && States[0, 1] > 0 && States[0, 2] > 0
                && States[1, 0] > 0 && States[1, 1] > 0 && States[1, 2] > 0
                && States[2, 0] > 0 && States[2, 1] > 0 && States[2, 2] > 0;
            if (flag1)

            {
                SetVisible(false);
                if (players.Count == 2)
                {
                    form.PlayerName = players[1];
                    form.BestTime = time2;
                }
                
                form.Show();
                Clear();
            }
            else if (flag2)
            {
                SetVisible(false);
                form.PlayerName = players[0];
                form.BestTime = time2;
                form.Show();
                Clear();
            }
            else if (!flag1 && !flag2 && flag3)
            {
                SetVisible(false);
                form.PlayerName = "Ничья";
                form.BestTime = 0;
                form.Show();
                
            }

        }



        private void Clear()
        {
            pictureBox1.Image = ResizeBitmap(new Bitmap(Resources.empty), 60, 60);
            pictureBox1.Refresh();
            pictureBox2.Image = ResizeBitmap(new Bitmap(Resources.empty), 60, 60);
            pictureBox2.Refresh();
            pictureBox3.Image = ResizeBitmap(new Bitmap(Resources.empty), 60, 60);
            pictureBox3.Refresh();
            pictureBox4.Image = ResizeBitmap(new Bitmap(Resources.empty), 60, 60);
            pictureBox4.Refresh();
            pictureBox5.Image = ResizeBitmap(new Bitmap(Resources.empty), 60, 60);
            pictureBox5.Refresh();
            pictureBox6.Image = ResizeBitmap(new Bitmap(Resources.empty), 60, 60);
            pictureBox6.Refresh();
            pictureBox7.Image = ResizeBitmap(new Bitmap(Resources.empty), 60, 60);
            pictureBox7.Refresh();
            pictureBox8.Image = ResizeBitmap(new Bitmap(Resources.empty), 60, 60);
            pictureBox8.Refresh();
            pictureBox9.Image = ResizeBitmap(new Bitmap(Resources.empty), 60, 60);
            pictureBox9.Refresh();
            States = new int[3, 3];
            playerinfo.Text = "";
            time1Player.Text = "";
            time2player.Text = "";
            timer1.Stop();
            timer2.Stop();
        }

        void PrintArray()
        {
            string output = ""
;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    output += States[i, j].ToString();
                }
                output += "\n";

            }

            MessageBox.Show(output);
        }


        void SetVisible(bool fl)
        {
           
            pictureBox1.Enabled = fl;
            pictureBox2.Enabled = fl;
            pictureBox3.Enabled = fl;
            pictureBox4.Enabled = fl;
            pictureBox5.Enabled = fl;
            pictureBox6.Enabled = fl;
            pictureBox7.Enabled = fl; 
            pictureBox8.Enabled = fl;
            pictureBox9.Enabled = fl;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetVisible(false);
            //positions = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    States[i, j] = 0;
                }
            }

            try
            {

                Bitmap map = new Bitmap(Resources.empty);
                map = ResizeBitmap(map, 60, 60);
                pictureBox1.Image = new Bitmap(map);
                pictureBox1.Refresh();
                pictureBox1.Visible = true;
                pictureBox2.Image = new Bitmap(map);
                pictureBox3.Image = new Bitmap(map);
                pictureBox4.Image = new Bitmap(map);
                pictureBox5.Image = new Bitmap(map);
                pictureBox6.Image = new Bitmap(map);
                pictureBox7.Image = new Bitmap(map);
                pictureBox8.Image = new Bitmap(map);
                pictureBox9.Image = new Bitmap(map);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occurred");
            }

        }

        private Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }
    }
}
