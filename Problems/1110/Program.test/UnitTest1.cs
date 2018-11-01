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
            yield return new object[] { 26, 68};
            yield return new object[] { 68, 84};
            yield return new object[] { 84, 42};
            yield return new object[] { 42, 26};
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
        public void TestMethod(int n, int expected)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine($"{n} {expected}");
            Assert.AreEqual(Program.GetCycleNumber(n), expected);
        }
    }
}
