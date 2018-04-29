using Xunit;

namespace Build.Tests.TestSet8
{
    public class UnitTest
    {
        IContainer container;

        public UnitTest()
        {
            container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
        }
        [Fact]
        public void TestSet8_Method1()
        {
            //TestSet8
            var srv1 = container.CreateInstance<ServiceDataRepository>();
            Assert.NotNull(srv1);
        }
        [Fact]
        public void TestSet8_Method2()
        {
            //TestSet8
            var srv2 = container.CreateInstance<ServiceDataRepository>();
            Assert.NotNull(srv2);
        }
        [Fact]
        public void TestSet8_Method3()
        {
            //TestSet8
            var srv1 = container.CreateInstance<ServiceDataRepository>();
            Assert.NotNull(srv1.Repository);
        }
        [Fact]
        public void TestSet8_Method4()
        {
            //TestSet8
            var srv2 = container.CreateInstance<ServiceDataRepository>();
            Assert.NotNull(srv2.Repository);
        }
        [Fact]
        public void TestSet8_Method5()
        {
            //TestSet8
            var srv1 = container.CreateInstance<ServiceDataRepository>();
            var srv2 = container.CreateInstance<ServiceDataRepository>();
            Assert.NotEqual(srv1, srv2);
        }
        [Fact]
        public void TestSet8_Method6()
        {
            //TestSet8
            var srv1 = container.CreateInstance<ServiceDataRepository>();
            var srv2 = container.CreateInstance<ServiceDataRepository>();
            Assert.NotEqual(srv1.Repository, srv2.Repository);
        }
    }
}