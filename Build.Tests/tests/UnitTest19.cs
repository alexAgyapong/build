using Build.Tests.TestSet19;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Build.Tests.UnitTests19
{
    using TestSet19;

    public static class UnitTests
    {
        [Fact]
        public static void TestSet19_Method1()
        {
            //TestSet19
            var container = new Container();
            Assert.Throws<TypeInstantiationException>(() => container.CreateInstance<Class1>());
        }

        [Fact]
        public static void TestSet19_Method10()
        {
            //TestSet19
            var container = new Container();
            var a = new A();
            Func<A> func1 = () => a;
            Func<A> func2 = () => a;
            container.RegisterType<B>(func1);
            container.RegisterType<Lazy<A>>(func2);
            container.RegisterType<C3>();
            var class1 = container.GetInstance<C3>();
            Assert.NotNull(class1.B);
        }

        [Fact]
        public static void TestSet19_Method11()
        {
            //TestSet19
            var container = new Container();
            var a = new A();
            Func<A> func1 = () => a;
            Func<A> func2 = () => a;
            container.RegisterType<B>(func1);
            container.RegisterType<Lazy<A>>(func2);
            container.RegisterType<C3>();
            Assert.Throws<TargetInvocationException>(() => container.CreateInstance<C3>());
        }

        [Fact]
        public static void TestSet19_Method12()
        {
            //TestSet19
            var container = new Container();
            var a = new A();
            Func<A> func1 = () => a;
            Func<A> func2 = () => a;
            container.RegisterType<B>(func1);
            container.RegisterType<Lazy<A>>(func2);
            container.RegisterType<C3>();
            var class1 = container.CreateInstance<C3>(container.GetInstance<Lazy<A>>(), container.GetInstance<B>());
            Assert.NotNull(class1.A);
        }

        [Fact]
        public static void TestSet19_Method13()
        {
            //TestSet19
            var container = new Container();
            var a = new A();
            Func<A> func1 = () => a;
            Func<A> func2 = () => a;
            container.RegisterType<B>(func1);
            container.RegisterType<Lazy<A>>(func2);
            container.RegisterType<C3>();
            var class1 = container.CreateInstance<C3>(container.GetInstance<Lazy<A>>(), container.GetInstance<B>());
            Assert.NotNull(class1.B);
        }

        [Fact]
        public static void TestSet19_Method2()
        {
            //TestSet19
            var container = new Container();
            container.RegisterType<Class1>();
            var class1 = container.CreateInstance<Class1>();
            Assert.NotNull(class1);
        }

        [Fact]
        public static void TestSet19_Method3()
        {
            //TestSet19
            var container = new Container();
            container.RegisterType<Class1>();
            container.RegisterType<Class2>();
            var class1 = container.CreateInstance<Class2>();
            Assert.NotNull(class1);
        }

        [Fact]
        public static void TestSet19_Method4()
        {
            //TestSet19
            var container = new Container();
            container.RegisterType<Class2>((Func<Class1>)(() => new Class1()));
            var class1 = container.CreateInstance<Class2>();
            Assert.NotNull(class1);
        }

        [Fact]
        public static void TestSet19_Method5()
        {
            //TestSet19
            var container = new Container();
            container.RegisterType<Class2>((Func<Class1>)(() => new Class1()));
            var class1 = container.GetInstance<Class2>();
            Assert.NotNull(class1);
        }

        [Fact]
        public static void TestSet19_Method6()
        {
            //TestSet19
            var container = new Container();
            Func<A> a = () => new A();
            var b = new B(a);
            container.RegisterType<B>(a);
            container.RegisterType<C2>(a, b);
            var class1 = container.GetInstance<C2>();
            Assert.NotNull(class1);
        }

        [Fact]
        public static void TestSet19_Method7()
        {
            //TestSet19
            var container = new Container();
            Func<A> a = () => new A();
            container.RegisterType<B>(a);
            container.RegisterType<C2>();
            var class1 = container.GetInstance<C2>();
            Assert.NotNull(class1);
        }

        [Fact]
        public static void TestSet19_Method8()
        {
            //TestSet19
            var container = new Container();
            Func<A> a = () => new A();
            container.RegisterType<B>(a);
            container.RegisterType<C2>();
            var class1 = container.GetInstance<C2>();
            Assert.Null(class1.A);
        }

        [Fact]
        public static void TestSet19_Method9()
        {
            //TestSet19
            var container = new Container();
            var a = new A();
            Func<A> func1 = () => a;
            Func<A> func2 = () => a;
            container.RegisterType<B>(func1);
            container.RegisterType<Lazy<A>>(func2);
            container.RegisterType<C3>();
            var class1 = container.GetInstance<C3>();
            Assert.NotNull(class1.A);
        }
    }
}