using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.InteropServices;


namespace DHubCRM
{
    public partial class MainForm : Form
    {
        Timer t1 = new Timer();
        int mov;
        int movX;
        int movY;

        public MainForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
           
        }
        
   
  

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
       

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            logo.Visible = false;

            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
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
            sidemenu.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sidemenu.Width == 50)
            {
                richTextBox1.Visible = false;
                sidemenu.Visible = false;
                logo2.Visible = false;
                sidemenu.Width = 260;
                PanelAnimator.ShowSync(sidemenu);
                LogoAnimator.ShowSync(logo);
            }
            else
            {
                richTextBox1.Visible = true;
                LogoAnimator.Hide(logo);
                Logo2Animator.ShowSync(logo2);
                sidemenu.Visible = false;
                sidemenu.Width = 50;
                
                PanelAnimator.ShowSync(sidemenu);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(37, 46, 59);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
            panel2.BackColor = Color.FromArgb(26, 32, 40);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CRM_Click(object sender, EventArgs e)
        {
            this.Hide(); // close the current form
            CRM CRM = new CRM();
            CRM.Show();
         
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
          
        }

        private void Accounting_Click(object sender, EventArgs e)
        {
            this.Hide(); // close the current form
            Accounting accounting = new Accounting();
            accounting.Show();
        }

        private void Support_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket ticket = new Ticket();
            ticket.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
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

     
        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
