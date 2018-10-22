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
                int a = r.Next(1, 9999);
                int b = r.Next(1, 9999);
                int expected = a % b;
                yield return new object[] { a, b, expected};
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
        public void TestMethod(int a, int b, int expected)
        {
            // if (Trace.Listeners.Count == 0)
            // {
                Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            // }
            Trace.WriteLine($"{a} {b} {expected}");
            Assert.AreEqual(Program.Modulo(a, b), expected);
        }
    }
}
