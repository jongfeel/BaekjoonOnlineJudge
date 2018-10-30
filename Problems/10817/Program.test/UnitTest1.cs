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
            yield return new object[] { 20, 30, 10, 20};
            yield return new object[] { 30, 30, 10, 30};
            yield return new object[] { 40, 40, 40, 40};
            yield return new object[] { 20, 10, 10, 10};
            yield return new object[] { 1, 2, 3, 2};
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
        public void TestMethod(int number1, int number2, int number3, int expected)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine($"{number1} {number2} {number3} {expected}");
            Assert.AreEqual(Program.GetSecondOrder(number1, number2, number3), expected);
        }
    }
}
