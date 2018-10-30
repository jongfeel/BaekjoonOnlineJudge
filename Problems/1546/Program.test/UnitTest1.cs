using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Problem;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace test
{
    public class CustomDataSourceAttribute : Attribute, ITestDataSource
    {
        public IEnumerable<object[]> GetData(MethodInfo methodInfo)
        {
            yield return new object[] { new int[] { 40, 80, 60 }, "75.00"};
            yield return new object[] { new int[] { 10, 20, 30 }, "66.67"};
            yield return new object[] { new int[] { 1, 100, 100, 100 }, "75.25"};
            yield return new object[] { new int[] { 1, 2, 4, 8, 16 }, "38.75"};
            yield return new object[] { new int[] { 3, 10 }, "65.00"};
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
        public void TestMethod(int[] a, string expected)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine($"{a} {expected}");
            Assert.AreEqual(Program.GetAverageSejoonMethod(a).ToString("F2"), expected);
        }
    }
}
