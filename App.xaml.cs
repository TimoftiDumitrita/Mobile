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
        static ReviewDatabase reviewDatabase;
        public static ReviewDatabase ReviewDatabase
        {
            get
            {
                if (reviewDatabase == null)
                {
                    reviewDatabase = new ReviewDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Review.db3"));
                }
                return reviewDatabase;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }

}
