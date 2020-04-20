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
    public partial class Alert : Form
    {
       
        public Alert()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private static Alert _iBox;
        
        public static DialogResult Show(string message)
        {
            
            if (_iBox == null)
            {
                _iBox = new Alert();
            }
            _iBox.lblmessage.Text = message;
            _iBox.ShowInTaskbar = false;
            _iBox.FormBorderStyle = FormBorderStyle.None;
            return _iBox.ShowDialog();
            
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Hide();
        }

        private void lblmessage_Click(object sender, EventArgs e)
        {
           
        }

        private void Alert_Load(object sender, EventArgs e)
        {
          
        }
    }

}

