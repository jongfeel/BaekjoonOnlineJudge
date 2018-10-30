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
            yield return new object[] { new Random().Next(90, 101), "A"};
            yield return new object[] { new Random().Next(80, 90), "B"};
            yield return new object[] { new Random().Next(70, 80), "C"};
            yield return new object[] { new Random().Next(60, 70), "D"};
            yield return new object[] { new Random().Next(0, 60), "F"};
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
        public void TestMethod(int numbers, string expected)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine($"{numbers} {expected}");
            Assert.AreEqual(Program.GetGrade(numbers), expected);
        }
    }
}
