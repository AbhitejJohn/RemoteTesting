using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace XunitTestProject
{
    public class TestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {1, 5},
            new object[] {1, 2}
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    public class XunitDynamicTheoryTest
    {
        [Theory]
        [InlineData(1, 2)]
        public void TestMethodPass(int a, int b)
        {
            Assert.Equal(1, a);
            Assert.Equal(2, b);
        }

        [Theory]
        [ClassData(typeof(TestDataGenerator))]
        public void TestMethodFail(int a, int b)
        {
            Assert.Equal(1, a);
            Assert.True(b > 1);
        }

    }
}
