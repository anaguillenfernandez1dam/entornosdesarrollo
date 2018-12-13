using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        bool turno2 = false;
        Table table = new Table(3, 3, true);

        for (int row = 0; row < 3; row++)
            for (int column = 0; column < 3; column++){
                Button button = new Button();
                table.Attach(button, (uint)column, (uint)column + 1, (uint)row, (uint)row + 1);
                button.Clicked += delegate {
                    if (turno2 == false)
                        button.Label = "X";
                    else
                        button.Label = "O";

                    turno2 = !turno2;
                };
            }

        vBox.Add(table);
        table.ShowAll();


        botonReiniciar.Clicked += delegate
        {
            //Preguntar sobre como modificar elementos hijos de una tabla
        };
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }


    //protected void OnButtonClicked(object sender, EventArgs e)
    //{
    //    ((Button)sender).Label = "X";
    //}
}
