using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<Car> Cars = new List<Car>();
        DataTable dt;
        DataView dv;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formLoad(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            dt = new DataTable();
            dt.Columns.Add("Make");
            dt.Columns.Add("Model");
            dt.Columns.Add("Type");
            dt.Columns.Add("Year");
            dt.Columns.Add("Plate");
            dt.Columns.Add("Speed");

            List<Car> cars = generateCarList();
            foreach (var car in cars)
            {
                dt.Rows.Add(car.Make, car.Model, car.Type, car.Year.ToString(), car.Plate, car.Speed.ToString());
            }

            dv = new DataView(dt);
            setFilter();

           
        }

        private List<Car> generateCarList()
        {
            var list = new List<Car>();
            list.Add(new Car("Ford", "Focus", "Osobowy", 2010, "WI 12345", 180));
            list.Add(new Car("Opel", "Astra", "Osobowy", 2005, "AB 23456", 200));
            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new AddForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                var car = f.car;
                dt.Rows.Add( car.Make, car.Model, car.Type, car.Year.ToString(), car.Plate, car.Speed.ToString());
                setFilter();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                int index = listView1.SelectedItems[i].Index;
                listView1.Items.Remove(listView1.SelectedItems[i]);
                dt.Rows.RemoveAt(index);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void setFilter()
        {
            bool filterActive = checkBoxActivateFilter.Checked;
            bool filterReverse = checkBoxReverseFilter.Checked;

            listView1.Items.Clear();
           
            if (filterActive)
            {
                if (filterReverse)
                {
                    string filter = string.Format("Speed <= " + numericUpDownMin.Value.ToString() + " OR Speed >=" + numericUpDownMax.Value.ToString());
                    dv.RowFilter = filter;
                }
                else
                {
                    string filter = string.Format("Speed >= "+numericUpDownMin.Value.ToString()+" AND Speed <="+numericUpDownMax.Value.ToString());
                    dv.RowFilter = filter;
                }
            }
            else
            {
                dv.RowFilter = "";
            }

            foreach (DataRow row in dv.ToTable().Rows)
            {
                var rowString = new string[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString() };
                var lvi = new ListViewItem(rowString);
                listView1.Items.Add(lvi);
            }

        }

        private void checkBoxActivateFilter_CheckedChanged(object sender, EventArgs e)
        {
            setFilter();
        }

        private void checkBoxReverseFilter_CheckedChanged(object sender, EventArgs e)
        {
            setFilter();
        }

        private void numericUpDownMin_ValueChanged(object sender, EventArgs e)
        {
            setFilter();
        }

        private void numericUpDownMax_ValueChanged(object sender, EventArgs e)
        {
            setFilter();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                int index = listView1.SelectedItems[0].Index;
                DataRow row = dt.Rows[index];
                Car car = new Car(row[0].ToString(), row[1].ToString(), row[2].ToString(), (int)row[3], row[4].ToString(), (int)row[5]);
                dt.Rows.RemoveAt(index);
            }
            /*for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
            {
                int index = listView1.SelectedItems[i].Index;
                listView1.Items.Remove(listView1.SelectedItems[i]);
                dt.Rows.RemoveAt(index);
            }*/
            var f = new AddForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                var car = f.car;
                dt.Rows.Add(car.Make, car.Model, car.Type, car.Year.ToString(), car.Plate, car.Speed.ToString());
                setFilter();
            }
        }
    }
}
