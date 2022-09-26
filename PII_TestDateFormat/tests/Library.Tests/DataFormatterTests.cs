namespace Library.Tests;
using TestDateFormat;
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    //caso en que la fecha es correcta
    [Test]
    public void TestDateFormat()
    {
        //arrange
        var date = new DateTime(2021, 1, 1);
        var formatter = new DateFormatter();
        //act
        var result = formatter.Format(date);
        //assert
        Assert.AreEqual("2021-01-01", result);
    }
    //caso en que la fecha no es correcta
    [Test]
    public void TestDateFormatIncorrect()
    {
        //arrange
        var date = new DateTime(2021, 1, 1);
        var formatter = new DateFormatter();
        //act
        var result = formatter.Format(date);
        //assert
        Assert.AreNotEqual("2021-01-02", result);
    }
    //caso en el que la fecha esta en blanco
    [Test]
    public void TestDateFormatBlank()
    {
        //arrange
        var date = new DateTime(2021, 1, 1);
        var formatter = new DateFormatter();
        //act
        var result = formatter.Format(date);
        //assert
        Assert.IsNotNull(result);
    }

}