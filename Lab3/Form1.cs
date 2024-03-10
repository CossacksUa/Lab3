using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;

            if (!double.TryParse(txtA.Text, out a) || !double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Введено некоректні дані");
                return;
            }

            // Очистимо ListView перед виведенням нових результатів
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Операція", 150);
            listView1.Columns.Add("Результат", 150);

            // Приклад використання класу AndArray
            AndArray andArray = new AndArray();

            double result1 = andArray.Add(a, b);
            AddItemToListView("Intersection", result1.ToString());

            double[] array1 = { 4.0, 9.0, 16.0 };
            andArray.ProcessArray(array1, listView1);

            // Приклад використання класу OrArray
            OrArray orArray = new OrArray();

            double result2 = orArray.Add(a, b);
            AddItemToListView("Union", result2.ToString());

            double[] array2 = { 1.0, 2.0, 3.0 };
            orArray.ProcessArray(array2, listView1);
        }

        // Допоміжний метод для додавання елементів у ListView
        private void AddItemToListView(string operation, string result)
        {
            ListViewItem item = new ListViewItem(operation);
            item.SubItems.Add(result);
            listView1.Items.Add(item);
        }

        private void butCl_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            listView1.Items.Clear();
            listView1.Columns.Clear();
        }
    }
}
