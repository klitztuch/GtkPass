using System;
using Gtk;

namespace GtkPass.App.PasswordStore;

public class InfoView : Box
{
    private readonly Label _passwordInfoLabel;

    public InfoView() : base(Orientation.Vertical, 4)
    {
        _passwordInfoLabel = new Label()
        {
            Selectable = true
        };
        PackStart(_passwordInfoLabel, true, true, 4);
    }
}