using CompetitionApplication;
using Gtk;
using Pango;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

class program
{

    public static void Main()
    {

        Application.Init();
        new login();
        Application.Run();

    }

}
