using Xunit;
using NumToWordNS.Objects;
namespace NumToWordNS
{
  public class NumToWordTest
  {

    // turns 1 to one
    [Fact]
    public void Test_For_1()
    {
     NumToWord translation = new NumToWord(1);
     Assert.Equal("one", translation.ChangeToWord());
    }
    // turns 10 to ten
    [Fact]
    public void Test_For_10()
    {
     NumToWord translation = new NumToWord(10);
     Assert.Equal("ten", translation.ChangeToWord());
    }
    // turns 19 to nineteen
    [Fact]
    public void Test_For_19()
    {
     NumToWord translation = new NumToWord(19);
     Assert.Equal("nineteen", translation.ChangeToWord());
    }
    // turns 20 to twenty
    [Fact]
    public void Test_For_20()
    {
     NumToWord translation = new NumToWord(20);
     Assert.Equal("twenty", translation.ChangeToWord());
    }
    // turns 21 to twenty one
    [Fact]
    public void Test_For_21()
    {
     NumToWord translation = new NumToWord(21);
     Assert.Equal("twenty one", translation.ChangeToWord());
    }
    // turns 55 to fifty five
    [Fact]
    public void Test_For_55()
    {
     NumToWord translation = new NumToWord(55);
     Assert.Equal("fifty five", translation.ChangeToWord());
    }
    // turns 100 to one hundred
    [Fact]
    public void Test_For_100()
    {
     NumToWord translation = new NumToWord(100);
     Assert.Equal("one hundred", translation.ChangeToWord());
    }
    // turns 101 to one hundred and one
    [Fact]
    public void Test_For_101()
    {
     NumToWord translation = new NumToWord(101);
     Assert.Equal("one hundred one", translation.ChangeToWord());
    }
    // turns 110 to one hundred and ten
    [Fact]
    public void Test_For_110()
    {
     NumToWord translation = new NumToWord(110);
     Assert.Equal("one hundred ten", translation.ChangeToWord());
    }
    // turns 158 to one hundred and fifty eight
    [Fact]
    public void Test_For_158()
    {
     NumToWord translation = new NumToWord(158);
     Assert.Equal("one hundred fifty eight", translation.ChangeToWord());
    }
    // turns 1000 into one thousand
    [Fact]
    public void Test_For_1000()
    {
     NumToWord translation = new NumToWord(1000);
     Assert.Equal("one thousand", translation.ChangeToWord());
    }
    // turns 1639 to one thousand six hundred thirty nine
    [Fact]
    public void Test_For_1639()
    {
     NumToWord translation = new NumToWord(1639);
     Assert.Equal("one thousand six hundred thirty nine", translation.ChangeToWord());
    }
    // turns 10,000 to ten thousand
    [Fact]
    public void Test_For_10000()
    {
     NumToWord translation = new NumToWord(10000);
     Assert.Equal("ten thousand", translation.ChangeToWord());
    }
    // turns 100,000 to one hundred thousand
    [Fact]
    public void Test_For_100000()
    {
     NumToWord translation = new NumToWord(100000);
     Assert.Equal("one hundred thousand", translation.ChangeToWord());
    }
    // turns 1,000,000 to one million
    [Fact]
    public void Test_For_1000000()
    {
     NumToWord translation = new NumToWord(1000000);
     Assert.Equal("one million", translation.ChangeToWord());
    }
    // turns 1,000,000,000 to one billion
    [Fact]
    public void Test_For_1000000000()
    {
     NumToWord translation = new NumToWord(1000000000);
     Assert.Equal("one billion", translation.ChangeToWord());
    }
    // turns 1,000,000,000,000 to one trillion
    [Fact]
    public void Test_For_1000000000000()
    {
     NumToWord translation = new NumToWord(1000000000000);
     Assert.Equal("one trillion", translation.ChangeToWord());
    }
    // turns 5,937,209,532,109 to five trillion nine hundred thirty seven billion two hundred and nine million five hundred thirty two one hundred and nine
    [Fact]
    public void Test_For_5937209532109()
    {
     NumToWord translation = new NumToWord(5937209532109);
     Assert.Equal("five trillion nine hundred thirty seven billion two hundred nine million five hundred thirty two thousand one hundred nine", translation.ChangeToWord());
    }
    // turns 999,999,999,999,999 into nine hundred ninety nine trillion nine hundred ninety nine billion nine hundred ninety nine million nine hundred ninety nine thousand nine hundred ninety nine
    [Fact]
    public void Test_For_999999999999999()
    {
     NumToWord translation = new NumToWord(999999999999999);
     Assert.Equal("nine hundred ninety nine trillion nine hundred ninety nine billion nine hundred ninety nine million nine hundred ninety nine thousand nine hundred ninety nine", translation.ChangeToWord());
    }

    // WORKS FOR ONE QUADRILLION
    [Fact]
    public void Test_for_quadrillion()
    {
      Assert.Equal("one quadrillion", new NumToWord(1000000000000000).ChangeToWord());
    }
    // WORKS FOR ONE QUADRILLION
    [Fact]
    public void Test_for_100quadrillion()
    {
      Assert.Equal("one hundred quadrillion", new NumToWord(100000000000000000).ChangeToWord());
    }

    /* EXAMPLE
    // Have a queen object that knows what coordinants its at
    [Fact]
    public void QueenAttack_ForCoordinants_SeeCoordinants()
    {
      QueenAttack queen = new QueenAttack(8, 2);
      Assert.Equal(8, queen.GetX());
      Assert.Equal(2, queen.GetY());
    }
    /**/
  }
}
