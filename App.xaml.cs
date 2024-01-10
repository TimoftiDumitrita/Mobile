using Mobile.Data;

namespace Mobile
{
    public partial class App : Application
    {
        static RezervareDatabase database;
        public static RezervareDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new RezervareDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Rezervare.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }

}
