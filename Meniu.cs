using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace asistent_virtual
{
    public partial class Meniu : UserControl
    {
        public Meniu()
        {
            InitializeComponent();
        }
        
        public dynamic alegere { get; set; }
        public dynamic alegere2 { get; set; }

        
        

        public void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            alegere.label1.Text = label1.Text;
            alegere2.label1.Text = label1.Text;
        }

        private void muzicabtn_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            
            alegere2.Visible = true;
        }

        private void vremebtn_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            alegere.Visible = true;
            
        }

        
    }
}
