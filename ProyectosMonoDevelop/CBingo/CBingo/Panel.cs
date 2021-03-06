﻿using System;
using Gtk;
using System.Collections.Generic;
namespace CBingo
{
    public class Panel
    {

        private static uint rows = 9;
        private static uint columns = 10;

        private IList<Button> buttons = new List<Button>();

        public Panel(VBox vBox)
        {
            Table table = new Table(rows, columns, true);
            int index = 0;
            for (uint row = 0; row < rows; row++)
                for (uint column = 0; column < columns; column++){
                    index++;
                    Button button = new Button();
                    button.Label = index.ToString();
                    buttons.Add(button);
                    table.Attach(button, column, column + 1, row, row + 1);
                }
            vBox.Add(table);
            table.ShowAll();
        }

        public void Marcar(int numero)
        {
            buttons[numero - 1].ModifyBg(StateType.Normal, new Gdk.Color(0, 255, 0));
        }
    }
}
    