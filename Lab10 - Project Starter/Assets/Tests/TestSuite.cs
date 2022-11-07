using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        /*// A Test behaves as an ordinary method
        [Test]
        public void TestSuiteSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestSuiteWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }*/

        private float result = 0.0f;

        [Test]
        public void TestAddition()
        {
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
        [Test]
        public void TestSubtraction()
        {
            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }
        [UnityTest]
        public IEnumerator TestUnitySubtraction()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }
        [Test]
        public void TestMultiplication()
        {
            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }
        [UnityTest]
        public IEnumerator TestUnityMultiplication()
        {
            yield return null;

            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }
        [Test]
        public void TestDivision()
        {
            result = Calculator.CalculatePair(6, 2, "/");
            Assert.AreEqual(result, 3);
        }
        [UnityTest]
        public IEnumerator TestUnityDivision()
        {
            yield return null;

            result = Calculator.CalculatePair(6, 2, "/");
            Assert.AreEqual(result, 3);
        }
        [Test]
        public void TestSquareRoot()
        {
            result = Calculator.CalculatePair(0, 81, "√");
            Assert.AreEqual(result, 9);
        }
        [UnityTest]
        public IEnumerator TestUnitySquareRoot()
        {
            yield return null;

            result = Calculator.CalculatePair(0, 81, "√");
            Assert.AreEqual(result, 9);
        }
        [Test]
        public void TestPower()
        {
            result = Calculator.CalculatePair(3, 3, "^");
            Assert.AreEqual(result, 27);
        }
        [UnityTest]
        public IEnumerator TestUnityPower()
        {
            yield return null;

            result = Calculator.CalculatePair(3, 3, "^");
            Assert.AreEqual(result, 27);
        }
    }
}
