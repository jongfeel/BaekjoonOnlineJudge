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
            for (int i = 0; i < 10; i++)
            {
                int length = new Random().Next(1, 101);
                StringBuilder numbers = new StringBuilder(length);
                int sum = 0;
                for (int j = 0; j < length; j++)
                {
                    int number = new Random().Next(0, 10);
                    sum += number;
                    numbers.Append(number);
                }
                yield return new object[] { numbers.ToString(), sum};
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
        public void TestMethod_SumOfNumbers(string numbers, int expected)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine($"{numbers} {expected}");
            Assert.AreEqual(Program.SumOfNumbers(numbers), expected);
        }
    }
}
