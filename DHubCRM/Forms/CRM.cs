using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Security.Cryptography;
using System.IO;

namespace DHubCRM
{
    public partial class CRM : Form
    {
        Timer t1 = new Timer();

        int mov;
        int movX;
        int movY;

        customerDbConn mysqlConn;
        public CRM()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            mysqlConn = new customerDbConn();
            mysqlConn.connect();
            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblCustomer`").Tables[0];

            }
            mysqlConn.connClose();
        }


        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        bool FNamefirstTime = true;
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (FNamefirstTime)
            {
                FNamefirstTime = false;
                FirstName.Text = "";
            }
        }
        bool LNamefirstTime = true;
        private void LastName_OnValueChanged(object sender, EventArgs e)
        {
            if (LNamefirstTime)
            {
                LNamefirstTime = false;
                LastName.Text = "";
            }
        }
        bool EmailfirstTime = true;
        private void Email_OnValueChanged(object sender, EventArgs e)
        {
            if (EmailfirstTime)
            {
                EmailfirstTime = false;
                Email.Text = "";
            }

        }


        private void Add_Click(object sender, EventArgs e)
        {
            string errorMsg;
            if (!ValidFirstName(FirstName.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.


                // Set the ErrorProvider error with the text to display. 
                Alert.Show(errorMsg);
            }
            if (!ValidLastName(LastName.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.


                // Set the ErrorProvider error with the text to display. 
                Alert.Show(errorMsg);
            }
            else if (!ValidEmailAddress(Email.Text, out errorMsg))
            {


                // Set the ErrorProvider error with the text to display. 
                Alert.Show(errorMsg);
            }
            else
            {
                if (mysqlConn.connOpen() == true)
                {

                    var Name = LastName.Text + " " + FirstName.Text;
                    mysqlConn.insertCustomer(Name, FirstName.Text, LastName.Text, TelNum.Text, address.Text, city.Text, Email.Text, country.Text);
                    dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblCustomer`").Tables[0];
                    Name = "";
                }
            }
        }


        private void Email_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!ValidEmailAddress(Email.Text, out errorMsg))
            {



                // Set the ErrorProvider error with the text to display. 
                Alert.Show(errorMsg);
            }

        }


        private void Email_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(Email, "");
        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            errorProvider1.Icon = new Icon(this.errorProvider1.Icon, 2, 2);
            // Confirm that the email address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "email address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "email address must be valid email address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }

        private void bunifuThinButton21_MouseClick(object sender, MouseEventArgs e)
        {

        }


        private void LastName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidLastName(LastName.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.


                // Set the ErrorProvider error with the text to display. 
                Alert.Show(errorMsg);
            }
        }

        private void LastName_Validated(object sender, EventArgs e)
        {

            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(LastName, "");
        }

        public bool ValidLastName(string LastName, out string errorMessage)
        {
            errorProvider1.Icon = new Icon(this.errorProvider1.Icon, 2, 2);
            // Confirm that the email address string is not empty.
            if (LastName.Length == 0)
            {
                errorMessage = "last name is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (Regex.Match(LastName, "^[a-zA-Z]*$").Success)
            {
                errorMessage = "";
                return true;
            }


            errorMessage = "last name must be valid last name format.\n" +
               "For example 'Smith' ";
            return false;
        }

        private void FirstName_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(FirstName, "");
        }

        private void FirstName_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidFirstName(FirstName.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.


                // Set the ErrorProvider error with the text to display. 
                Alert.Show(errorMsg);
            }
        }
        public bool ValidFirstName(string FirstName, out string errorMessage)
        {
            errorProvider1.Icon = new Icon(this.errorProvider1.Icon, 2, 2);
            // Confirm that the email address string is not empty.
            if (FirstName.Length == 0)
            {
                errorMessage = "first name is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            if (Regex.Match(FirstName, "^[a-zA-Z]*$").Success)
            {
                errorMessage = "";
                return true;
            }


            errorMessage = "first name must be valid first name format.\n" +
               "For example 'John' ";
            return false;
        }


       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                ///Fills the text box with information from the dataGridView1 table based on a specific column///
                ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                FirstName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                LastName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                TelNum.Text = "Encrypted";
                address.Text = "Encrypted";
                city.Text = "Encrypted";
                country.Text = "Encrypted";
                Email.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                customerEmail.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                ///AutoSize the columns so that the dataGridView1 table is fully occupied///
                DataGridViewColumn column0 = dataGridView1.Columns[0];
                column0.Width = 40;
                DataGridViewColumn column1 = dataGridView1.Columns[1];
                column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DataGridViewColumn column2 = dataGridView1.Columns[2];
                column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DataGridViewColumn column3 = dataGridView1.Columns[3];
                column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DataGridViewColumn column4 = dataGridView1.Columns[4];
                column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DataGridViewColumn column5 = dataGridView1.Columns[5];
                column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DataGridViewColumn column6 = dataGridView1.Columns[6];
                column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DataGridViewColumn column7 = dataGridView1.Columns[7];
                column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DataGridViewColumn column8 = dataGridView1.Columns[8];
                column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }

        private void CRMPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {


        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void LeadReport_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ID_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TelNum_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void address_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void city_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void LeadReport_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                var Name = LastName.Text + " " + FirstName.Text;
                mysqlConn.updateCustomer(ID.Text, name.Text, FirstName.Text, LastName.Text, TelNum.Text, address.Text, city.Text, Email.Text, country.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblCustomer`").Tables[0];
                Name = "";
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                mysqlConn.deleteCustomer(ID.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblCustomer`").Tables[0];
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            List<MailAddress> emails = new List<MailAddress>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                emails.Add(new MailAddress(row.Cells["email"].Value.ToString()));
            }
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("sucileamarcus@gmail.com");
                mail.Subject = emailSubject.Text;
                mail.Body = emailtext.Text;
                foreach (MailAddress m in emails)
                {
                    mail.To.Add(m);
                }
                if (openFileDialog1.FileName == String.Empty)
                {
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("sucileamarcus@gmail.com", "Heemiola123!");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("Email Sent!");
                }
                else
                {
                    System.Net.Mail.Attachment attachment;
                    attachment = new System.Net.Mail.Attachment(emailattach.Text);
                    mail.Attachments.Add(attachment);
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("sucileamarcus@gmail.com", "Heemiola123!");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("Email Sent!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                customerEmail.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                string email = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("sucileamarcus@gmail.com");
                mail.To.Add(email);
                mail.Subject = emailSubject.Text;
                mail.Body = emailtext.Text;
                if (openFileDialog1.FileName == String.Empty)
                {
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("sucileamarcus@gmail.com", "Heemiola123!");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("Email Sent!");
                }
                else
                {
                    System.Net.Mail.Attachment attachment;
                    attachment = new System.Net.Mail.Attachment(emailattach.Text);
                    mail.Attachments.Add(attachment);
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("sucileamarcus@gmail.com", "Heemiola123!");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("Email Sent!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            MailMessage mail = new MailMessage();
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(openFileDialog1.FileName);
            mail.Attachments.Add(attachment);
            emailattach.Text = Convert.ToString(openFileDialog1.FileName);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void CRM_Load(object sender, EventArgs e)
        {
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
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
        private void CRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;    //cancel the event so the form won't be closed

            t1.Tick += new EventHandler(fadeOut);  //this calls the fade out function
            t1.Start();

            if (Opacity == 0)  //if the form is completly transparent
                e.Cancel = false;   //resume the event - the program can be closed
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            try
            {
                customerEmail.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                string email = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("sucileamarcus@gmail.com");
                mail.To.Add(email);
                mail.Subject = emailSubject.Text;
                mail.Body = emailtext.Text + "\nwww.siloamworship.com";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("sucileamarcus@gmail.com", "Heemiola123!");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                MessageBox.Show("Email Sent!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    
}
            

            
    
               
    


