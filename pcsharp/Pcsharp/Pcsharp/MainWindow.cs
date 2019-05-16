﻿using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        treeView.AppendColumn("Nombre", new CellRendererText(), "text", 0);
        treeView.AppendColumn("Teléfono", new CellRendererText(), "text", 1);
        ListStore listStore = new ListStore(typeof(String), typeof(String));
        treeView.Model = listStore;
        listStore.AppendValues("Rosa", "777666555");
        listStore.AppendValues("Mario", "111222333");
        listStore.AppendValues("Aaaaaaaaaaaaaaaaaaaa", "1112244442333");

        editAction.Sensitive = false;

        newAction.Activated += (sender, e) =>
        {
            hbox1.Visible = true;
            treeView.Sensitive = false;
        };

        editAction.Activated += (sender, e) =>
        {
            hbox1.Visible = true;
            treeView.Sensitive = false;
            treeView.Selection.GetSelected(out TreeIter treeIter);
            string nombre = (string)treeView.Model.GetValue(treeIter, 0);
            string telefono = (string)treeView.Model.GetValue(treeIter, 1);
            entry1.Text = nombre;
            entry2.Text = telefono;
            Console.WriteLine("Nombre={0} Teléfono={1}", nombre, telefono);
        };

        treeView.Selection.Changed += (sender, e) => 
            editAction.Sensitive = treeView.Selection.CountSelectedRows() > 0; 


    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
