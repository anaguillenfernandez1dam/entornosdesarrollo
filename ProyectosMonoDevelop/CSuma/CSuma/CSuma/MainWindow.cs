using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        buttonSuma.Clicked += delegate
        {
            decimal num1 = decimal.Parse(entry1.Text);
            decimal num2 = decimal.Parse(entry2.Text);
            decimal resultado = num1 + num2;
            labelResultado.Text = resultado.ToString();
        };

        buttonResta.Clicked += delegate
        {
            decimal num1 = decimal.Parse(entry1.Text);
            decimal num2 = decimal.Parse(entry2.Text);
            decimal resultado = num1 - num2;
            labelResultado.Text = resultado.ToString();
        };

        buttonMultiplica.Clicked += delegate
        {
            decimal num1 = decimal.Parse(entry1.Text);
            decimal num2 = decimal.Parse(entry2.Text);
            decimal resultado = num1 * num2;
            labelResultado.Text = resultado.ToString();
        };

        buttonDivide.Clicked += delegate
        {
            decimal num1 = decimal.Parse(entry1.Text);
            decimal num2 = decimal.Parse(entry2.Text);
            decimal resultado = num1 / num2;
            labelResultado.Text = resultado.ToString();
        };
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
