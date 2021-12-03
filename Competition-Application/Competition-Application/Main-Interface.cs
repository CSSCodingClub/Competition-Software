using Gtk;
using Pango;
using System;

namespace CompetitionApplication
{
    public class Main_Interface : Window
    {



        public Main_Interface() : base("Fixed")
        {
            SetDefaultSize(600, 500);
            SetPosition(WindowPosition.Center);
            ModifyBg(StateType.Normal, new Gdk.Color(127, 0, 255));
            DeleteEvent += delegate { Application.Quit(); };


        }





    }
}
