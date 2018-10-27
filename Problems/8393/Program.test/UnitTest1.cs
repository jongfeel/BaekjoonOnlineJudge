using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Problem;
using System.Diagnostics;
using System.Linq;

namespace test
{
    public class CustomDataSourceAttribute : Attribute, ITestDataSource
    {
        public IEnumerable<object[]> GetData(MethodInfo methodInfo)
        {
            for (int i = 0; i < 10; i++)
            {
                int random = new Random().Next(1, 10000);
                yield return new object[] { random, Enumerable.Range(1, random).Sum()};
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
        public void TestMethod_SumOfN(int n, int expected)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine($"{n} {expected}");
            Assert.AreEqual(Program.SumOfN(n), expected);
        }
    }
}
