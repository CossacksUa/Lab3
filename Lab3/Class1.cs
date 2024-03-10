using System;
using System.Windows.Forms;

// Абстрактний базовий клас Array
public abstract class Array
{
    // Віртуальний метод додавання
    public abstract double Add(double a, double b);

    // Віртуальний метод для заелементної обробки масиву foreach()
    public abstract void ProcessArray(double[] array, Control control);
}
