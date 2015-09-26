using Xunit;

namespace Example2._64
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class CategoryAttribute : TraitAttribute
    {
        public CategoryAttribute(string value)
            : base("Category", value)
        { }
    }

    public class UnitTestAttribute : CategoryAttribute
    {
        public UnitTestAttribute()
            : base("Unit Test")
        { }
    }

    class UnitTests
    {
        [Fact]
        [Trait("Category", "Unit Test")]
        public void MyUnitTest()
        { }

        [Fact]
        [UnitTest]
        public void MySecondUnitTest()
        { }
    }
}
