
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox caja;

	private global::Gtk.HBox hbox1;

	private global::Gtk.Label labelNumero;

	private global::Gtk.Button buttonSiguiente;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.caja = new global::Gtk.VBox();
		this.caja.Name = "caja";
		this.caja.Spacing = 6;
		// Container child caja.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.labelNumero = new global::Gtk.Label();
		this.labelNumero.Name = "labelNumero";
		this.hbox1.Add(this.labelNumero);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.labelNumero]));
		w1.Position = 0;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.buttonSiguiente = new global::Gtk.Button();
		this.buttonSiguiente.CanFocus = true;
		this.buttonSiguiente.Name = "buttonSiguiente";
		this.buttonSiguiente.UseStock = true;
		this.buttonSiguiente.UseUnderline = true;
		this.buttonSiguiente.Label = "gtk-go-forward";
		this.hbox1.Add(this.buttonSiguiente);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSiguiente]));
		w2.PackType = ((global::Gtk.PackType)(1));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.caja.Add(this.hbox1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.caja[this.hbox1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		this.Add(this.caja);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
