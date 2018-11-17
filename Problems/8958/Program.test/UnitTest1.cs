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
            yield return new object[] { "OOXXOXXOOO", 10};
            yield return new object[] { "OOXXOOXXOO", 9};
            yield return new object[] { "OXOXOXOXOXOXOX", 7};
            yield return new object[] { "OOOOOOOOOO", 55};
            yield return new object[] { "OOOOXOOOOXOOOOX", 30};
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
        public void TestMethod(string value, int expected)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine($"{value} {expected}");
            int sum = Program.GetCorrectArray(value).Select(correct => Program.SumToN(correct.Length)).Sum();
            Assert.AreEqual(sum, expected);
        }
    }
}
