
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vBox;

	private global::Gtk.Button botonReiniciar;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vBox = new global::Gtk.VBox();
		this.vBox.Name = "vBox";
		this.vBox.Spacing = 6;
		// Container child vBox.Gtk.Box+BoxChild
		this.botonReiniciar = new global::Gtk.Button();
		this.botonReiniciar.CanFocus = true;
		this.botonReiniciar.Name = "botonReiniciar";
		this.botonReiniciar.UseUnderline = true;
		this.botonReiniciar.Label = global::Mono.Unix.Catalog.GetString("Reiniciar");
		this.vBox.Add(this.botonReiniciar);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vBox[this.botonReiniciar]));
		w1.Position = 1;
		w1.Expand = false;
		w1.Fill = false;
		this.Add(this.vBox);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 293;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}