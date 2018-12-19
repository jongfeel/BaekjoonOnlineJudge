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
            yield return new object[] { new string[] { "911", "97625999", "91125426" }, "NO"};
            yield return new object[] { new string[] { "113", "12340", "123440", "12345", "98346" }, "YES"};
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
        public void TestMethod(string[] values, string expected)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine($"{values} {expected}");
            Assert.AreEqual(Program.GetValidate(values), expected);
        }
    }
}
