
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox2;

	private global::Gtk.VBox vbox3;

	private global::Gtk.Entry entry1;

	private global::Gtk.Entry entry2;

	private global::Gtk.Label labelResultado;

	private global::Gtk.VBox vbox4;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Button buttonSuma;

	private global::Gtk.Button buttonResta;

	private global::Gtk.HBox hbox4;

	private global::Gtk.Button buttonMultiplica;

	private global::Gtk.Button buttonDividir;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.vbox3.Add(this.entry1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.entry1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.vbox3.Add(this.entry2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.entry2]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.labelResultado = new global::Gtk.Label();
		this.labelResultado.Name = "labelResultado";
		this.labelResultado.LabelProp = global::Mono.Unix.Catalog.GetString("Resultado");
		this.vbox3.Add(this.labelResultado);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.labelResultado]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.hbox2.Add(this.vbox3);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox3]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.buttonSuma = new global::Gtk.Button();
		this.buttonSuma.CanFocus = true;
		this.buttonSuma.Name = "buttonSuma";
		this.buttonSuma.UseUnderline = true;
		this.buttonSuma.Label = global::Mono.Unix.Catalog.GetString("+");
		this.hbox3.Add(this.buttonSuma);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonSuma]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.buttonResta = new global::Gtk.Button();
		this.buttonResta.CanFocus = true;
		this.buttonResta.Name = "buttonResta";
		this.buttonResta.UseUnderline = true;
		this.buttonResta.Label = global::Mono.Unix.Catalog.GetString("--");
		this.hbox3.Add(this.buttonResta);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonResta]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		this.vbox4.Add(this.hbox3);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox3]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.buttonMultiplica = new global::Gtk.Button();
		this.buttonMultiplica.CanFocus = true;
		this.buttonMultiplica.Name = "buttonMultiplica";
		this.buttonMultiplica.UseUnderline = true;
		this.buttonMultiplica.Label = global::Mono.Unix.Catalog.GetString("x");
		this.hbox4.Add(this.buttonMultiplica);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonMultiplica]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.buttonDividir = new global::Gtk.Button();
		this.buttonDividir.CanFocus = true;
		this.buttonDividir.Name = "buttonDividir";
		this.buttonDividir.UseUnderline = true;
		this.buttonDividir.Label = global::Mono.Unix.Catalog.GetString("/");
		this.hbox4.Add(this.buttonDividir);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonDividir]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox4.Add(this.hbox4);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox4]));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		this.hbox2.Add(this.vbox4);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox4]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		this.Add(this.hbox2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 217;
		this.DefaultHeight = 88;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
