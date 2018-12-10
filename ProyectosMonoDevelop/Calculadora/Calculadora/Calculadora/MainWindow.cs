using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        buttonSuma.Clicked += delegate
        {
            //int num1 = Int32.Parse(entry1.Text);
            //int num2 = Int32.Parse(entry2.Text);
            //int resultado = num1 + num2;
            //labelResultado.Text = resultado.ToString();    
        };
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
