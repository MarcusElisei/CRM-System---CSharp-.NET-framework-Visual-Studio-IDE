using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DHubCRM
{
    public partial class Bottom : Form
    {
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();

        int mov;
        int movX;
        int movY;
        customerDbConn mysqlConn;
        public Bottom()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            mysqlConn = new customerDbConn();
            mysqlConn.connect();
            InitializeComponent();

            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `sales`").Tables[0];
                dataGridView2.DataSource = mysqlConn.qry("SELECT * FROM `orderdetails`").Tables[0];
                dataGridView3.DataSource = mysqlConn.qry("SELECT * FROM `tblCustomer`").Tables[0];
            }
            mysqlConn.connClose();
        }
     

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemssold2_OnValueChanged(object sender, EventArgs e)
        {

        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }
        private void Bottom_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
            dataGridView1.AllowUserToAddRows = false;
            DataGridViewColumn column0 = dataGridView3.Columns[0];
            column0.Width = 70;
            DataGridViewColumn column1 = dataGridView3.Columns[1];
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column2 = dataGridView3.Columns[2];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column3 = dataGridView3.Columns[3];
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column4 = dataGridView3.Columns[4];
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column5 = dataGridView3.Columns[5];
            column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column6 = dataGridView3.Columns[6];
            column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column7 = dataGridView3.Columns[7];
            column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column8 = dataGridView3.Columns[8];
            column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;


            //Items Sold//
            int numberitems;
            int sold = 0;
            string itemsSold = "";
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                itemsSold += row.Cells["quantityOrdered"].Value;
                numberitems = Convert.ToInt32(itemsSold);
                sold += numberitems;
                itemsSold = "";

            }

            itemssold2.Text = sold.ToString();
            //Items Sold//

            //Total sales//
            float totalsaless;
            float sales = 0;
            string totalSales = " ";
            int soldd = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                itemsSold += row.Cells["quantityOrdered"].Value;
                numberitems = Convert.ToInt32(itemsSold);
                soldd += numberitems;
                itemsSold = " ";
                totalSales += row.Cells["priceEach"].Value;
                totalsaless = (float)Convert.ToDouble(totalSales);
                totalSales = " ";
                sales += (totalsaless * soldd);
                soldd = 0;

            }

            totalsales2.Text = "£" + sales.ToString();
            //Total sales



            //Top customers spending//

            var Sales = new Dictionary<string, string> { };
            var productsold = new Dictionary<int, int> { };
            var CustomerDetails = new Dictionary<string, string> { };
            var Totalsales = new Dictionary<int, string> { };

            string CustomerNumber = " ";
            string orderNumber = " ";
            string customerNumber;
            string ordernumber = "";


            string productCode = "";
            string price = " ";
            int productcode = 0;
            string quantity = "";
            int quantityItem = 0;
            float priceEach;


            string name = "";
            string Fullname = "";
            string code = "";
            string CusCode = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                CustomerNumber += row.Cells["customerNumber"].Value;
                customerNumber = CustomerNumber.ToString();
                CustomerNumber = "";
                orderNumber += row.Cells["orderNumber"].Value;
                var orderNumberr = orderNumber.Trim();
                ordernumber = orderNumberr.ToString();
                Console.WriteLine(ordernumber);
                orderNumber = "";
                Sales.Add(customerNumber, ordernumber);

            }

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                productCode += row.Cells["orderNumber"].Value;
                productcode = Convert.ToInt32(productCode);
                productCode = "";
                quantity += row.Cells["quantityOrdered"].Value;
                quantityItem = Convert.ToInt32(quantity);
                quantity = " ";
                price += row.Cells["priceEach"].Value;
                priceEach = (float)Convert.ToDouble(price);
                int pricee = (int)Math.Round(priceEach * quantityItem, 0);

                price = " ";
                productsold.Add(quantityItem, productcode);
                Totalsales.Add(pricee, pricee.ToString());

            }

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                name += row.Cells["customerName"].Value;
                Fullname = name.ToString();
                name = "";
                code += row.Cells["customerNumber"].Value;
                CusCode = code.ToString();
                code = " ";
                CustomerDetails.Add(CusCode, Fullname);

            }


            var salesList = Sales.Keys.ToList();
            var orderDetails = productsold.Keys.ToList();
            var customers = CustomerDetails.Keys.ToList();
            var totalsales = Totalsales.Keys.ToList();

            salesList.Sort();
           

            orderDetails.Sort();
          
            customers.Sort();
            customers.Reverse();

            totalsales.Sort();
         


            int i = 0;
            int temp = 0;

            foreach (var value in orderDetails)
            {
                if (i < 1 && productsold.Count > 1)
                {
                    int num = Convert.ToInt32(value);

                    string orderNum = productsold[value].ToString();

                    foreach (var m in salesList)
                    {

                        string cusID = m.Trim();
                        int CusID = Convert.ToInt32(m);
                        if (Sales[m].ToString() == orderNum)
                        {
                            var q = 0;
                            foreach (var n in totalsales)
                            {

                                if (q < 1)
                                {

                                    float current = (n / sales) * 100;
                                    int currentSales = Convert.ToInt32(current);
                                    top0.Value = currentSales;
                                    temp += n;
                                    foreach (var x in customers)
                                    {
                                        var tempp = x.Trim();
                                        if (tempp == cusID)
                                        {
                                            top1.Text = CustomerDetails[x];
                                            break;
                                        }
                                    }
                                    q++;
                                }

                            }
                        }
                    }
                    int values = Convert.ToInt32(value);
                    i++;

                }
            }

            int y = 0;
            foreach (var value in orderDetails)
            {
                if (y < 2 && productsold.Count > 1)
                {
                    int num = Convert.ToInt32(value);

                    string orderNum = productsold[value].ToString();

                    foreach (var m in salesList)
                    {

                        string cusID = m.Trim();
                        int CusID = Convert.ToInt32(m);
                        if (Sales[m].ToString() == orderNum)
                        {
                            var q = 0;
                            foreach (var n in totalsales)
                            {

                                if (q < 2)
                                {

                                    float current = (n / sales) * 100;
                                    int currentSales = Convert.ToInt32(current);
                                    bunifuCircleProgressbar1.Value = currentSales;
                                    temp += n;
                                    foreach (var x in customers)
                                    {
                                        var tempp = x.Trim();
                                        if (tempp == cusID)
                                        {
                                            bunifuMaterialTextbox1.Text = CustomerDetails[x];
                                            break;
                                        }
                                    }
                                    q++;
                                }

                            }
                        }
                    }
                    int values = Convert.ToInt32(value);
                    y++;

                }
            }
            int h = 0;
            foreach (var value in orderDetails)
            {
                if (h < 3 && productsold.Count > 1)
                {
                    int num = Convert.ToInt32(value);

                    string orderNum = productsold[value].ToString();

                    foreach (var m in salesList)
                    {

                        string cusID = m.Trim();
                        int CusID = Convert.ToInt32(m);
                        if (Sales[m].ToString() == orderNum)
                        {
                            var q = 0;
                            foreach (var n in totalsales)
                            {

                                if (q < 3)
                                {

                                    float current = (n / sales) * 100;
                                    int currentSales = Convert.ToInt32(current);
                                    bunifuCircleProgressbar2.Value = currentSales;
                                    temp += n;
                                    foreach (var x in customers)
                                    {
                                        var tempp = x.Trim();
                                        if (tempp == cusID)
                                        {
                                            bunifuMaterialTextbox2.Text = CustomerDetails[x];
                                            break;
                                        }
                                    }
                                    q++;
                                }

                            }
                        }
                    }
                    int values = Convert.ToInt32(value);
                    h++;

                }
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accounting sales = new Accounting();
            sales.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Top topsales = new Top();
            topsales.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profit profit = new Profit();
            profit.Show();
                     
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void Bottom_FormClosing(object sender, FormClosingEventArgs e)
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



