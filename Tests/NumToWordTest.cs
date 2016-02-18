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

    // turns 19 to nineteen

    // turns 20 to twenty

    // turns 21 to twenty one

    // turns 55 to fifty five

    // turns 100 to one hundred
    // turns 101 to one hundred and one
    // turns 110 to one hundred and ten
    // turns 158 to one hundred and fifty eight
    // turns 1000 into one thousand
    // turns 1639 to one thousand six hundred thirty nine
    // turns 10,000 to ten thousand
    // turns 100000 to one hundred thousand
    // turns 1,000,000 to one million
    // turns 1,000,000,000 to one billion
    // turns 1,000,000,000,000 to one trillion
    // turns 5,937,209,532,109 to five trillion nine hundred thirty seven billion two hundred and nine million five hundred thirty two one hundred and nine

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
