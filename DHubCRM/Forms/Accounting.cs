using MySql.Data.MySqlClient;
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
    public partial class Accounting : Form
    {
        Timer t1 = new Timer();

        int mov;
        int movX;
        int movY;
        customerDbConn mysqlConn;
        public Accounting()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            mysqlConn = new customerDbConn();
            mysqlConn.connect();
            InitializeComponent();
            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `orderdetails`").Tables[0];
                dataGridView2.DataSource = mysqlConn.qry("SELECT * FROM `products`").Tables[0];

            }
            mysqlConn.connClose();
        }

        float priceEach;
        int quantityItem;
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }
        private void Accounting_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();

            dataGridView1.AllowUserToAddRows = false;
            DataGridViewColumn column0 = dataGridView1.Columns[0];
            column0.Width = 70;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column2 = dataGridView1.Columns[2];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column3 = dataGridView1.Columns[3];
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column4 = dataGridView1.Columns[4];
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Items Sold//
            int numberitems;
            int sold = 0;
            string itemsSold = " ";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                itemsSold += row.Cells["quantityOrdered"].Value;
                numberitems = Convert.ToInt32(itemsSold);
                sold += numberitems;
                itemsSold = " ";

            }

            itemssold.Text = sold.ToString();
            //Items Sold//




            //Total sales//
            float totalsaless;
            float sales = 0;
            string totalSales = " ";
            int soldd = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                itemsSold += row.Cells["quantityOrdered"].Value;
                numberitems = Convert.ToInt32(itemsSold);
                soldd += numberitems;
                itemsSold = " ";
                totalSales += row.Cells["priceEach"].Value;
                totalsaless = (float) Convert.ToDouble(totalSales);
                totalSales = " ";
                sales += (totalsaless * soldd);
                soldd = 0;
            
            }

            totalsales.Text = "£" + sales.ToString();
            //Total sales


            //Top items sold//

            var productsold = new Dictionary<int, int> { };
            string productCode = " ";
            string quantity = " ";            
            int productcode;
            string price = " ";          

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                productCode += row.Cells["productCode"].Value;   
                productcode = Convert.ToInt32(productCode);
                productCode = "";
                quantity += row.Cells["quantityOrdered"].Value;
                quantityItem = Convert.ToInt32(quantity);
                quantity = " "; 
                price += row.Cells["priceEach"].Value;
                priceEach = (float)Convert.ToDouble(price);
                int pricee = (int)Math.Round(priceEach * quantityItem, 0);    
                price = " ";
                productsold.Add(pricee, productcode);
                int count1 = productsold.Count; 
            }
            
            var myList = productsold.Keys.ToList();
            myList.Sort();
            myList.Reverse();
            int i = 0;
            string name = " ";
            
            foreach (var value in myList)
            {
                if (i < 1 && myList.Count > 1)
                {
                    var chart1 = (value  / sales) * 100;
                    
                    top0.Value = (int)Math.Round(chart1, 0);
                    i++;
                    
                    foreach (DataGridViewRow ro in dataGridView2.Rows)
                    {
                        name += ro.Cells["productCode"].Value;
                        string text = name.Trim();
                        
                        
                        if (text == productsold[value].ToString())
                        {
                            string Name = "";
                            Name += ro.Cells["productName"].Value;
                            top1.Text = Name;
                          
                        }
                        name = " ";                          
                    }
                }              
            }
            int n = 0;
            myList.RemoveAt(0);
            foreach (var valuee in myList)
            {
                if (n < 1)
                {
                    var chart1 = (valuee / sales) * 100;
                   
                    bunifuCircleProgressbar7. Value = (int)Math.Round(chart1, 0);
                    n++;
                    foreach (DataGridViewRow ro in dataGridView2.Rows)
                    {
                        name += ro.Cells["productCode"].Value;
                        string text = name.Trim();


                        if (text == productsold[valuee].ToString())
                        {
                            string Name = "";
                            Name += ro.Cells["productName"].Value;
                            top2.Text = Name;

                        }
                        name = " ";
                    }
                }
             

            }
            int x = 0;
            myList.RemoveAt(0);
            foreach (var valuee in myList)
            {
                if (x < 1)
                {
                    var chart1 = (valuee / sales) * 100;

                    bunifuCircleProgressbar6.Value = (int)Math.Round(chart1, 0);
                    x++;
                    foreach (DataGridViewRow ro in dataGridView2.Rows)
                    {
                        name += ro.Cells["productCode"].Value;
                        string text = name.Trim();


                        if (text == productsold[valuee].ToString())
                        {
                            string Name = "";
                            Name += ro.Cells["productName"].Value;
                            top3.Text = Name;

                        }
                        name = " ";
                    }
                }


            }
            //Top items sold//
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void itemssold_OnValueChanged(object sender, EventArgs e)
        {
            


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Top topsales = new Top();
            topsales.Show();
         }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bottom bottomsales = new Bottom();
            bottomsales.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profit profit = new Profit();
            profit.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void Accounting_FormClosing(object sender, FormClosingEventArgs e)
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

