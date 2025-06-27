namespace AlwaysFailNUnitTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Fail();
        Console.WriteLine("test");
    }
}
