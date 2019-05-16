using System;
using Gtk;
namespace CWindow
{
    public class WindowHelper
    {
        public static bool Confirm(Window parentWindow, string message)
        {

            MessageDialog messageDialog = new MessageDialog(
                parentWindow,
                DialogFlags.Modal,
                MessageType.Question,
                ButtonsType.YesNo,
                "¿Seguro que quieres eliminar este contacto?");

            messageDialog.Title = parentWindow.Title;
            ResponseType response = (ResponseType)messageDialog.Run();

            messageDialog.Destroy();

            return response == ResponseType.Yes;
        }

    }
}