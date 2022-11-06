using System;

namespace GtkPass.App
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Gtk.Application.Init();

            var app = new Gtk.Application("org.GtkPass.App.GtkPass.App", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new MainWindow();
            app.AddWindow(win);

            win.Show();
            Gtk.Application.Run();
        }
    }
}