using Xunit;

namespace Build.Tests.TestSet15
{
    public static class UnitTest
    {
        [Fact]
        public static void TestSet15_Method1()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            var sql = (SqlDataRepository)container.CreateInstance("Build.Tests.TestSet15.SqlDataRepository", (object[])null);
            Assert.NotNull(sql);
        }

        [Fact]
        public static void TestSet15_Method10()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var srv = (ServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.ServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            var sqlRepository = srv.Repository as SqlDataRepository;
            Assert.Equal(2018, sqlRepository.PersonId);
        }

        [Fact]
        public static void TestSet15_Method11()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            var sql = (SqlDataRepository)container.CreateInstance("Build.Tests.TestSet15.SqlDataRepository(System.Int32)", new object[] { 2018 });
            Assert.Equal(2018, sql.PersonId);
        }

        [Fact]
        public static void TestSet15_Method12()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<ServiceDataRepository>();
            var sql = (ServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.ServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2018, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method13()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method14()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<WebServiceDataRepository>();
            container.RegisterType<SqlDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method15()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method16()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method17()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<WebServiceDataRepository>();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method18()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method19()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method2()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            var sql = (SqlDataRepository)container.CreateInstance("Build.Tests.TestSet15.SqlDataRepository(System.Int32)", 2018);
            Assert.NotNull(sql);
        }

        [Fact]
        public static void TestSet15_Method20()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeInstantiation = false });
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method21()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            //Instantiation reqires SqlDataRepository to be resolved
            Assert.Throws<TypeInstantiationException>(() => container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null));
        }

        [Fact]
        public static void TestSet15_Method22()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false, UseDefaultTypeInstantiation = false });
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            //Instantiation reqires SqlDataRepository to be resolved
            Assert.Throws<TypeInstantiationException>(() => container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null));
        }

        [Fact]
        public static void TestSet15_Method23()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions());
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method24()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeAttributeOverwrite = false });
            container.RegisterType<WebServiceDataRepository>();
            Assert.Throws<TypeRegistrationException>(() => container.RegisterType<SqlDataRepository>());
        }

        [Fact]
        public static void TestSet15_Method25()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeAttributeOverwrite = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method26()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeAttributeOverwrite = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method27()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeAttributeOverwrite = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method28()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method29()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            container.Lock();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method3()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = (ServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.ServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)", (object[])null);
            Assert.NotNull(sql.Repository);
        }

        [Fact]
        public static void TestSet15_Method30()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>(typeof(SqlDataRepository));
            container.Lock();
            var sql = (WebServiceDataRepository)container.GetInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method31()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>("Build.Tests.TestSet15.SqlDataRepository");
            container.Lock();
            var sql = (WebServiceDataRepository)container.GetInstance("Build.Tests.TestSet15.WebServiceDataRepository(Build.Tests.TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void TestSet15_Method4()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var srv = (ServiceDataRepository)container.CreateInstance("Build.Tests.TestSet15.ServiceDataRepository(Build.Tests.TestSet15.IPersonRepository)", (object[])null);
            Assert.NotNull(srv);
        }

        [Fact]
        public static void TestSet15_Method5()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var p = (IPersonRepository)null;
            //type information is missing so it will match System.Object. Since there is no ServiceDataRepository(System.Object) constructor, exception will be thrown
            Assert.Throws<TypeInstantiationException>(() => container.CreateInstance<ServiceDataRepository>(p));
        }

        [Fact]
        public static void TestSet15_Method6()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = container.CreateInstance<SqlDataRepository>();
            var srv = container.CreateInstance<ServiceDataRepository>(new object[] { sql });
            Assert.NotNull(srv.Repository);
        }

        [Fact]
        public static void TestSet15_Method7()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = container.CreateInstance<SqlDataRepository>(new object[] { 0 });
            var srv = container.CreateInstance<ServiceDataRepository>(new object[] { sql });
            var sqlRepository = srv.Repository as SqlDataRepository;
            Assert.NotNull(sqlRepository);
        }

        [Fact]
        public static void TestSet15_Method8()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = container.CreateInstance<SqlDataRepository>(new object[] { (int)Database.WebService });
            var srv = container.CreateInstance<ServiceDataRepository>(new object[] { sql });
            var sqlRepository = srv.Repository as SqlDataRepository;
            Assert.Equal(1, sqlRepository.PersonId);
        }

        [Fact]
        public static void TestSet15_Method9()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            Assert.Throws<TypeInstantiationException>(() => container.CreateInstance<SqlDataRepository>(new object[] { Database.SQL }));
        }
    }
}