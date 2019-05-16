using System;
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
        removeAction.Sensitive = false;

        bool editando = false;

        newAction.Activated += (sender, e) =>
        {
            vbox3.Visible = true;
            treeView.Sensitive = false;
            editando = false;
        };

        editAction.Activated += (sender, e) =>
        {
            vbox3.Visible = true;
            treeView.Sensitive = false;
            treeView.Selection.GetSelected(out TreeIter treeIter);
            string nombre = (string)treeView.Model.GetValue(treeIter, 0);
            string telefono = (string)treeView.Model.GetValue(treeIter, 1);
            entry1.Text = nombre;
            entry2.Text = telefono;
            //Console.WriteLine("Nombre={0} Teléfono={1}", nombre, telefono);

            editando = true;
        };

        removeAction.Activated += (sender, e) =>
        {
            if (WindowHelper.Confirm(this, "¿Seguro que quieres eliminar este contacto?")){

            }
                treeView.Selection.GetSelected(out TreeIter treeIter);
            listStore.Remove(ref treeIter);
        };

        buttonAceptar.Clicked += (sender, e) =>
        {
            if (editando){
                treeView.Selection.GetSelected(out TreeIter treeIter);
                listStore.SetValue(treeIter, 0, entry1.Text);
                listStore.SetValue(treeIter, 1, entry2.Text);
                editando = false;
            }
            else{
                listStore.AppendValues(entry1.Text, entry2.Text);
            }

            entry1.Text = "";
            entry2.Text = "";
            vbox3.Visible = false;
            treeView.Sensitive = true;
        };

        buttonCancelar.Clicked += (sender, e) =>
        {
            entry1.Text = "";
            entry2.Text = "";
            vbox3.Visible = false;
            treeView.Sensitive = true;
            editAction.Sensitive = false;
            editando = false;
        };

        treeView.Selection.Changed += (sender, e) =>
        {
            editAction.Sensitive = treeView.Selection.CountSelectedRows() > 0;
            removeAction.Sensitive = treeView.Selection.CountSelectedRows() > 0;
        };
             


    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
