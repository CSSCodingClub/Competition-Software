using Gtk;
using Pango;
using System;


using RestSharp;
using System.Net;
using System.IO;

class SharpApp : Window
{

    private Gdk.Pixbuf testimage;
    private Entry entry_user = new Gtk.Entry() { WidthChars = 20 };
    private Entry entry_pass = new Gtk.Entry() { WidthChars = 20 };

    public SharpApp() : base("Fixed")
    {
        SetDefaultSize(600, 500);
        SetPosition(WindowPosition.Center);
        ModifyBg(StateType.Normal, new Gdk.Color(127, 131, 137));
        DeleteEvent += delegate { Application.Quit(); };


        Fixed fix = new Fixed();

        //setting entry field to password visibility 
        entry_pass.Visibility = false;

        //main label
        Gdk.Color col = new Gdk.Color(12, 36, 242);
        String value = "CSS Coding Competition";
        var label = new Gtk.Label();
        label.ModifyFg(StateType.Normal, col);
        label.ModifyFont(new Pango.FontDescription() { Weight = Weight.Bold, AbsoluteSize = 30 * (int)Pango.Scale.PangoScale });
        label.SetPadding(4, 4);
        label.Text = value;

        //username label
        Gdk.Color col2 = new Gdk.Color(12, 36, 242);
        var loginL = new Gtk.Label();
        String value2 = "Username";
        loginL.ModifyFg(StateType.Normal, col2);
        loginL.ModifyFont(new Pango.FontDescription() {  AbsoluteSize = 11 * (int)Pango.Scale.PangoScale });
        loginL.SetPadding(4, 4);
        loginL.Text = value2;

        //pssword label
        var loginP = new Gtk.Label();
        String value3 = "Password";
        loginP.ModifyFg(StateType.Normal, col2);
        loginP.ModifyFont(new Pango.FontDescription() { AbsoluteSize = 11 * (int)Pango.Scale.PangoScale });
        loginP.SetPadding(4, 4);
        loginP.Text = value3;

        //login button
        Button login_button = new Button("Login");
        login_button.SetSizeRequest(70, 30);
        login_button.Clicked += callback;

        //login button
        Button create_user_botton = new Button("Create account");
        create_user_botton.SetSizeRequest(100, 30);
    

        //adding everything to window
        fix.Put(login_button, 330, 330);
        fix.Put(create_user_botton, 200, 330);
        fix.Put(label,130,90);
        fix.Put(loginL, 170, 253);
        fix.Put(loginP, 170, 283);
        fix.Put(entry_user, 230, 250);
        fix.Put(entry_pass, 230, 280);
        Add(fix);
        ShowAll();
        
    }


    private void callback(object obj, EventArgs args)
    {
        String user = entry_user.Text;
        string pass = entry_pass.Text;
        Console.WriteLine("Username: " + user);
        Console.WriteLine("Password: " + pass);

        Validate(user,pass);
    }


    private void Validate(string user, string pass)
    {

     //API call

    }


    public static void Main()
    {
        Application.Init();
        new SharpApp();
        Application.Run();
    }
}