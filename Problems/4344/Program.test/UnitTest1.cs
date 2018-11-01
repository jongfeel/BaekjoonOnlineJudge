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
            yield return new object[] { new int[] { 50, 50, 70, 80, 100 }, "40.000"};
            yield return new object[] { new int[] { 100, 95, 90, 80, 70, 60, 50 }, "57.143"};
            yield return new object[] { new int[] { 70, 90, 80, }, "33.333"};
            yield return new object[] { new int[] { 70, 90, 81, }, "66.667"};
            yield return new object[] { new int[] { 100, 99, 98, 97, 96, 95, 94, 93, 91 }, "55.556"};
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
            Assert.AreEqual(Program.GetAverageRatio(a.ToList()).ToString("F3"), expected);
        }
    }
}
