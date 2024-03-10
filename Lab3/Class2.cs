using System;
using System.Windows.Forms;

// Похідний клас AndArray
public class AndArray : Array
{
    // Перевизначений метод додавання для перетинання безлічей
    public override double Add(double a, double b)
    {
        return a * b; // Перетинання безлічей
    }

    // Перевизначений метод для заелементної обробки (добування квадратного кореня)
    public override void ProcessArray(double[] array, Control control)
    {
        ListView listView = control as ListView;

        if (listView != null)
        {
            foreach (double element in array)
            {
                double squareRoot = Math.Sqrt(element);
                ListViewItem item = new ListViewItem("Square root of " + element);
                item.SubItems.Add(squareRoot.ToString());
                listView.Items.Add(item);
            }
        }
    }
}