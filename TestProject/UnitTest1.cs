using ConsoleApp;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var class1 = new Class1();
            class1.Method1();
            Assert.True(true);
        }
    }
}