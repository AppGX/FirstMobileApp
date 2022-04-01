using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using FirstApp.Data;
using System.IO;

namespace FirstApp
{
    public partial class App : Application
    {
        static NotesDB notesDB;

        public static NotesDB NotesDB
        {
            get
            {
                if (notesDB == null)
                {
                    notesDB = new NotesDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "NotesDatabase.db3"));
                }
                return notesDB;
            }
        }

        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            // MainPage = new Page7();
            // MainPage = new Page8();
            // MainPage = new Page9();
            // MainPage = new Page10();
            // MainPage = new Page11();
            // MainPage = new Page12();
            // MainPage = new Page12(); // add SQLite
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
