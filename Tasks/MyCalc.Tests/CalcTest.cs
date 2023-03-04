using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace MyCalc.Tests
{
    public class CalcTest
    {
          [TestCase(32, 6, 2, 19)]
          [TestCase(100, 2, 1, 102)]
          [TestCase(547, 246, 1, 793)]
          [TestCase(-1, 2, -1, -1)]
          public void Sum_a_and_b_then_divede_by_C(int a, int b, int c, int expected)
          {
              int actual = Calc.calc(a, b, c);

              Assert.AreEqual(expected, actual);
          }

        [TestCase(32, 6, 2)]
        [TestCase(100, 2, 0)]
        [TestCase(547, 246, 55)]
        [TestCase(-1, 2, -1)]
        public void RemainderAfterDivicion(int a, int b, int expected)
        {
            int actual = Calc.calc1(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}