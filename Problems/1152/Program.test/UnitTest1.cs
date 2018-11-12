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
            yield return new object[] { "The Curious Case of Benjamin Button", 6};
            yield return new object[] { " Mazatneunde Wae Teullyeoyo", 3};
            yield return new object[] { "Teullinika Teullyeotzi ", 2};
            yield return new object[] { "1    2 3   4  5  ", 5};
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
        public void TestMethod(string s, int expected)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine($"{s} {expected}");
            Assert.AreEqual(Program.GetWordCount(s), expected);
        }
    }
}
