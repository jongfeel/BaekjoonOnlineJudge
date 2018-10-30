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
                int n = new Random().Next(1, 10001);
                int x = new Random().Next(1, 10001);

                int[] a = new int[n];
                bool condition = false; // At least number less than x in sequence a.
                for (int j = 0; j < n; j++)
                {
                    a[j] = new Random().Next(1, 10001);
                    if (a[j] < x)
                    {
                        condition = true;
                    }
                }

                if (!condition)
                {
                    a[a.Length-1] = x - 1;
                }

                yield return new object[] { a, x, a.Where(number => number < x).ToList()};
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
        public void TestMethod(int[] a, int x, List<int> expected)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.WriteLine($"{a} {x} {expected}");
            Assert.IsTrue(expected.SequenceEqual(Program.GetLessthan(a, x)));
        }
    }
}
