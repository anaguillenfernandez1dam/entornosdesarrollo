
using Gtk;
using System;
using System.Collections.Generic;

using CBingo;

public partial class MainWindow : Gtk.Window
{
    private static readonly Gdk.Color COLOR_GREEN = new Gdk.Color(0, 255, 0);
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        Panel panel = new Panel(vbox);
        Bombo bombo = new Bombo();

        buttonSiguiente.Clicked += delegate
        {
            panel.Marcar(32);
            int numero = bombo.sacarBola();
        };
        ////Button[] buttons = new Button[90]
        //Random random = new Random();
        //List<int> numeros = new List<int>();
        //numeros = rellenarLista(numeros);
        //List<Button> buttons = new List<Button>();

        //for (int i = 1; i < 91; i++){
        //    Button button = new Button();
        //    button.Label = i.ToString();
        //    buttons.Add(button);
        //}

        //int cont = 0;
        //for (int row = 0; row < 9; row++)
        //    for (int column = 0; column < 10; column++)
        //    {
        //        Button button = buttons[cont];
        //        cont++;
        //        table.Attach(button, (uint)column, (uint)column + 1, (uint)row, (uint)row+1);
        //    }

        //table.ShowAll();

        //cont = 90;
        //buttonSiguiente.Clicked += delegate {

        //    int numAleatorio = random.Next(cont)-1;
        //    labelNumero.Text = numeros[numAleatorio].ToString();

        //    buttons[numeros[numAleatorio]].ModifyBg(StateType.Normal, COLOR_GREEN);
        //    numeros.Remove(numeros[numAleatorio]);
        //    cont--;

        //};
    }

    public List<int> rellenarLista(List<int> numeros){
        numeros = new List<int>();
        for (int i = 1; i < 91; i++)
        {
            numeros.Add(i);
        }

        return numeros;
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
