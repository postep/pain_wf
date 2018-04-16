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
        public string type { get; set; }
        public TypeSelector()
        {
            InitializeComponent();
            setCar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setCar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setMotorcycle();
        }

        private void setCar()
        {
            type = "Osobowy";
            button1.BackColor = SystemColors.ControlDarkDark;
            button2.BackColor = SystemColors.Control;
        }

        private void setMotorcycle()
        {
            type = "Motocykl";
            button2.BackColor = SystemColors.ControlDarkDark;
            button1.BackColor = SystemColors.Control;
        }
    }
}
