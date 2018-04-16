using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TypeSelector : UserControl
    {
        public string t
        {
            get;set;
            
        }
        public TypeSelector()
        {
            InitializeComponent();
            t = "Osobowy";
            button1.BackColor = SystemColors.ControlDarkDark;
            button2.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = "Osobowy";
            button1.BackColor = SystemColors.ControlDarkDark;
            button2.BackColor = SystemColors.Control;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t = "Motocykl";
            button2.BackColor = SystemColors.ControlDarkDark;
            button1.BackColor = SystemColors.Control;
        }

        public void setT(string t)
        {
            if (t == "Osobowy")
            {
                this.t = "Osobowy";
                button1.BackColor = SystemColors.ControlDarkDark;
                button2.BackColor = SystemColors.Control;
            }
            else
            {
                this.t = "Motocykl";
                button2.BackColor = SystemColors.ControlDarkDark;
                button1.BackColor = SystemColors.Control;
            }
        }
    }
}
