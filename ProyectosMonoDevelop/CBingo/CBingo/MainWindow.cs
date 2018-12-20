
using Gtk;
using System;
using System.Collections.Generic;

public partial class MainWindow : Gtk.Window
{
    private static readonly Gdk.Color COLOR_GREEN = new Gdk.Color(0, 255, 0);
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        //Button[] buttons = new Button[90]
        Random random = new Random();
        List<int> numeros = new List<int>();
        numeros = rellenarLista(numeros);
        List<Button> buttons = new List<Button>();

        for (int i = 1; i < 91; i++){
            Button button = new Button();
            button.Label = i.ToString();
            buttons.Add(button);
        }

        int cont = 90;
        for (int row = 0; row < 5; row++)
            for (int column = 0; column < 7; column++)
            {
                int numBoton = random.Next(cont);
                Button button = buttons[numBoton];
                numeros.Remove(numeros[numBoton]);
                cont--;

                table.Attach(button, (uint)column, (uint)column + 1, (uint)row, (uint)row+1);
                buttons.Remove(buttons[numBoton]);
            }

        table.ShowAll();

        cont = 90;
        buttonSiguiente.Clicked += delegate {

            int numAleatorio = numeros[random.Next(cont)];
            labelNumero.Text = numAleatorio.ToString();

            buttons[numAleatorio].ModifyBg(StateType.Normal, COLOR_GREEN);
            numeros.Remove(numeros[numAleatorio]);
            cont--;

        };
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
