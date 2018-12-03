using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        buttonAceptar.Clicked += delegate
        {
            string nombre = entrarNombre.Text;
            labelNombre.Text = "Hola " + nombre;
        };
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
   
}
