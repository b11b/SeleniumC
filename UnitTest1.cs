namespace UdemyTestLearn
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Set up method ex");
        }

        [Test]
        public void Test1()
        {
            TestContext.Progress.WriteLine("This is test1"); 
        }

        [Test]

        public void Test2()
        {
            TestContext.Progress.WriteLine("This is test2");
        }

        [TearDown]
        public void CloseBrowser()
        {
            TestContext.Progress.WriteLine("This is TearDown method");
        }
    }
}