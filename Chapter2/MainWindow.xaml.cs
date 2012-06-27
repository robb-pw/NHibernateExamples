﻿namespace Chapter2
{
    using System.Windows;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate;
    using NHibernate.Cfg;
    using NHibernate.Tool.hbm2ddl;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string connString = "server=.\\SQLExpress; database=NH3BeginnersGuide; Integrated Security=SSPI;";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreateDatabase_Click(object sender, RoutedEventArgs e)
        {
            Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connString))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProductMap>())
                .ExposeConfiguration(CreateSchema)
                .BuildConfiguration();
        }

        private static void CreateSchema(Configuration cfg)
        {
            var schemaExport = new SchemaExport(cfg);
            schemaExport.Drop(false, true);
            schemaExport.Create(false, true);
        }

        private ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connString))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProductMap>())
                .BuildSessionFactory();
        }

        private void btnCreateSessionFactory_Click(object sender, RoutedEventArgs e)
        {
            var factory = CreateSessionFactory();
        }
    }
}
