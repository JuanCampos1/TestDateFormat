using NUnit.Framework;
using TestDateFormat;

namespace TestDateFormat.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FormatChange()
    {
        string date = "23/04/2022";
        string expected = "2022-04-23";
        Assert.AreEqual(expected, Program.ChangeFormat(date));
    }

    [Test]
    public void FormatChange2()
    {
        string date = "23/04/2022";
        string expected = "04-23-2022";
        Assert.AreEqual(expected, Program.ChangeFormat2(date));
    }
}