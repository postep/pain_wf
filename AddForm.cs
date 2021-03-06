﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddForm : Form
    {
        public Car car { get; set; }
        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm(Car car)
        {
            InitializeComponent();
            textBoxMake.Text = car.Make;
            textBoxModel.Text = car.Model;
            typeSelector1.setT(car.Type);
            numericUpDownYear.Value = car.Year;
            textBoxPlate.Text = car.Plate;
            numericUpDownSpeed.Value = car.Speed;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            car = new Car(textBoxMake.Text, textBoxModel.Text, typeSelector1.t, (int)numericUpDownYear.Value, textBoxPlate.Text, (int)numericUpDownSpeed.Value);
            if (car.isValid())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Wypełnij dane poprawnie");
            }
        }
    }
}
