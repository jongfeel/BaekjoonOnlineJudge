using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Problem;
using System.Diagnostics;

namespace test
{
    public class CustomDataSourceAttribute : Attribute, ITestDataSource
    {
        public IEnumerable<object[]> GetData(MethodInfo methodInfo)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int a = r.Next(2, 10000);
                int b = r.Next(2, 10000);
                int c = r.Next(2, 10000);
                yield return new object[] { a, b, c};
            }
        }

        public string GetDisplayName(MethodInfo methodInfo, object[] data)
        {
            if (data != null)
                return string.Format(CultureInfo.CurrentCulture, "Custom - {0} ({1})", methodInfo.Name, string.Join(",", data));

            return null;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [CustomDataSource]
        public void TestMethod_Modulo1(int a, int b, int c)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine($"{a} {b} {c}");
            Assert.AreEqual(Program.Modulo1(a, b, c), Program.Modulo2(a, b, c));
        }

        [DataTestMethod]
        [CustomDataSource]
        public void TestMethod_Modulo2(int a, int b, int c)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine($"{a} {b} {c}");
            Assert.AreEqual(Program.Modulo3(a, b, c), Program.Modulo4(a, b, c));
        }
    }
}
