using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHubCRM
{
    public partial class Ticket : Form
    {

        Timer t1 = new Timer();
        List<int> total = new List<int>();
        int mov;
        int movX;
        int movY;
        customerDbConn mysqlConn;
        public Ticket()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            mysqlConn = new customerDbConn();
            mysqlConn.connect();
            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `poll_main`").Tables[0];
                dataGridView2.DataSource = mysqlConn.qry("SELECT * FROM `poll_options`").Tables[0];
                dataGridView3.DataSource = mysqlConn.qry("SELECT * FROM `poll_votes`").Tables[0];
            }
            mysqlConn.connClose();
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int totalvotes = 0;
        string polls = "";
        int totals = 0;
        int totalsd = 0;
        int totald = 0;
        private void Ticket_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView1.AllowUserToAddRows = false;
            DataGridViewColumn column0 = dataGridView3.Columns[0];
            column0.Width = 100;
            DataGridViewColumn column1 = dataGridView3.Columns[1];
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column2 = dataGridView3.Columns[2];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                polls += row.Cells["option_id"].Value;
                if (polls == " " || polls == "")
                {
                    break;
                }

                int polsss = Convert.ToInt32(polls);
                total.Add(polsss);
                polls = "";
                
            }
            foreach (int a in total)
            {
              
                if (a == 1)
                {
                    totals += 1;
                }
                else if (a == 2)
                {
                    totalsd += 1;
                }
                else if (a == 3)
                {
                    totald += 1;
                }
            }
            totalvotes += totals + totalsd + totald;
            if (totalvotes == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                decimal i = 2 / 5;
                Console.WriteLine(i);
                bunifuCircleProgressbar1.Value = (totals * 100) / totalvotes;
                bunifuCircleProgressbar3.Value = (totalsd * 100) / totalvotes;
                bunifuCircleProgressbar2.Value = (totald * 100) / totalvotes;
                totals = 0;
                totalsd = 0;
                totald = 0;
                total.Clear();
                totalvotes = 0;
            }
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void Ticket_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;    //cancel the event so the form won't be closed

            t1.Tick += new EventHandler(fadeOut);  //this calls the fade out function
            t1.Start();

            if (Opacity == 0)  //if the form is completly transparent
                e.Cancel = false;   //resume the event - the program can be closed
        }
        void fadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                t1.Stop();    //if it is, we stop the timer
                Close();   //and we try to close the form
            }
            else
                Opacity -= 0.05;
        }
    }
}
