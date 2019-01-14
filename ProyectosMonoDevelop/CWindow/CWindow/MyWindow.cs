using System;
using Gtk;
namespace CWindow
{
    public partial class MyWindow : Gtk.Window
    {
        public MyWindow() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
