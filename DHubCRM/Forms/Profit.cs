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


    public partial class Profit : Form
    {
        Timer t1 = new Timer();
        static Dictionary<string, string> products = new Dictionary<string, string> { };
        string product = "";
        int mov;
        int movX;
        int movY;
        customerDbConn mysqlConn;
        public Profit()
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
                dataGridView4.DataSource = mysqlConn.qry("SELECT * FROM `products`").Tables[0];
                itemsSold.Text = "0";
            }
            mysqlConn.connClose();


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
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }
        
        private void Profit_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
            dataGridView4.AllowUserToAddRows = false;
            DataGridViewColumn column0 = dataGridView4.Columns[0];
            column0.Width = 70;
            DataGridViewColumn column1 = dataGridView4.Columns[1];
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column2 = dataGridView4.Columns[2];
            column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column3 = dataGridView4.Columns[3];
            column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column4 = dataGridView4.Columns[4];
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewColumn column5 = dataGridView4.Columns[5];
            column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView4.AllowUserToAddRows = false;
            

            //Items Sold//
            int numberitems;
            int sold = 0;
            string itemsSold = " ";
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                itemsSold += row.Cells["quantityOrdered"].Value;
                numberitems = Convert.ToInt32(itemsSold);
                sold += numberitems;
                itemsSold = " ";

            }


            this.bunifuMaterialTextbox2.Text = sold.ToString();
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

            bunifuMaterialTextbox5.Text = "£" + sales.ToString();
            bunifuMaterialTextbox4.Text = "£" + sales.ToString();
            //Total sales

            //Net profit//

            string netsales2 = "";
            float netsales = 0;
            float net = 0;
            int numberItems2 = 0;
            int solddd = 0;
            string totalsales = "";
            string productCode = "";

            string saleprice2 = "";
            float saleprice = 0;
            string productCodesale = "";

            foreach (DataGridViewRow ro in dataGridView2.Rows)
            {
                netsales2 += ro.Cells["quantityOrdered"].Value;
                numberItems2 = Convert.ToInt32(netsales2);
                solddd += numberItems2;
                netsales2 = "";
                totalsales += ro.Cells["priceEach"].Value;
                netsales = (float)Convert.ToDouble(totalsales);
                totalsales = "";
                productCode += ro.Cells["productCode"].Value;

                foreach (DataGridViewRow r in dataGridView4.Rows)
                {
                    saleprice2 += r.Cells["buyPrice"].Value;
                    saleprice = (float)Convert.ToDouble(saleprice2);
                    productCodesale += r.Cells["productCode"].Value;
                
                    if (productCodesale == productCode)
                    {
                        net+= (netsales - saleprice) * numberItems2;
                    }
                    saleprice2 = "";
                    productCodesale = "";
                }
                productCode = "";


            }
            bunifuMaterialTextbox6.Text = "£" + net.ToString();

            string netsales3 = "";
            float netsalesss= 0;
            float nett= 0;
            int numberItems4 = 0;
            int soldddd = 0;
            string totalsalesss= "";
            string orderNumberrr= "";

            string orderDate= "";
      
            string orderNumber2= "";

            foreach (DataGridViewRow ro in dataGridView2.Rows)
            {
                netsales3 += ro.Cells["quantityOrdered"].Value;
                numberItems4 = Convert.ToInt32(netsales3);
                soldddd += numberItems4;
                netsales3 = "";
                totalsalesss+= ro.Cells["priceEach"].Value;
                netsalesss= (float)Convert.ToDouble(totalsalesss);
                totalsalesss= "";
                orderNumberrr+= ro.Cells["orderNumber"].Value;

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    orderDate += r.Cells["orderDate"].Value;
            
                    orderNumber2+= r.Cells["orderNumber"].Value;
                    

                    if (orderNumber2== orderNumberrr)
                    {
                        var date = Math.Ceiling(DateTime.Today.Month / 3m);
                        Console.WriteLine(date);
                        

                        var date2 = orderDate.Substring(3, 2);
                  
                        int date5 = Convert.ToInt32(date2);
                        Console.WriteLine(date5);
                        var date4 = Convert.ToInt32((date5 + 2)/ 3);
                        var date6 = (int)date4;
                        Console.WriteLine(date6);
                      

                        if (date == date6)
                        {
                            nett += netsalesss;
                            Console.WriteLine(nett);
                        }
                        else
                        {
                            nett = 0;
                        }



                    }
                    orderDate= "";
                    orderNumber2= "";
                }
                orderNumberrr= "";


            }
            bunifuMaterialTextbox3.Text = "£" + nett.ToString();

            //Products dictionary//
            string itemName = "";
            string itemCode = "";
         

            foreach (DataGridViewRow row in dataGridView4.Rows)
            {

                itemName += row.Cells["productName"].Value;
                itemCode += row.Cells["productCode"].Value;
                products.Add(itemName, itemCode);

            
                itemName = "";
                itemCode = "";
            }
           
            //Products dictionary//

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {

                ///Fills the text box with information from the dataGridView1 table based on a specific column///
                buyPrice.Text = "£" + dataGridView4.SelectedRows[0].Cells[5].Value.ToString();
                bunifuMaterialTextbox1.Text = "£" + dataGridView4.SelectedRows[0].Cells[4].Value.ToString();
                ItemName.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
                product = ItemName.Text;


                var myList = products.Keys.ToList();
                int i = 0;
                Int32 z = myList.Count;
              
                string orderProductCode = "";
                string quantitySold = "";
                
                while (i < z)
                {
                    itemsSold.Text = "0";
                    foreach (DataGridViewRow ro in dataGridView2.Rows)
                    {

                        orderProductCode += ro.Cells["productCode"].Value;
                        quantitySold += ro.Cells["quantityOrdered"].Value;
                        

                        foreach (var value in myList)
                        {   
                        
                           if (orderProductCode == products[value] && value == product)
                            {
                         
                                var sold = quantitySold;
                                itemsSold.Text = sold;
                                break;
                                
                            }                                 
                        }

                        orderProductCode = "";
                        quantitySold = "";

                    }

                 
                    i++;
             

                }

            }
            products.Clear();


        }

        //Current Quarter sales//


        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
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
            Top top = new Top();
            top.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bottom bottom = new Bottom();
            bottom.Show();
        }

        private void Profit_FormClosing(object sender, FormClosingEventArgs e)
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

