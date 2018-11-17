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
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, "ascending"};
            yield return new object[] { new int[] { 8, 7, 6, 5, 4, 3, 2, 1 }, "descending"};
            yield return new object[] { new int[] { 8, 1, 7, 2, 6, 3, 5, 4 }, "mixed"};
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
        public void TestMethod(int[] values, string expected)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine($"{values} {expected}");
            Assert.AreEqual(Program.GetCodeResult(values), expected);
        }
    }
}
