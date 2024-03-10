using System;
using System.Windows.Forms;

// Похідний клас OrArray
public class OrArray : Array
{
    // Перевизначений метод додавання для об'єднання
    public override double Add(double a, double b)
    {
        return a + b; // Об'єднання
    }

    // Перевизначений метод для заелементної обробки (обчислення логарифма)
    public override void ProcessArray(double[] array, Control control)
    {
        ListView listView = control as ListView;

        if (listView != null)
        {
            foreach (double element in array)
            {
                double logarithm = Math.Log(element);
                ListViewItem item = new ListViewItem("Logarithm of " + element);
                item.SubItems.Add(logarithm.ToString());
                listView.Items.Add(item);
            }
        }
    }
}