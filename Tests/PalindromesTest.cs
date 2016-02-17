using Xunit;
using PalindromesNS.Objects;
namespace PalindromesNS
{
  public class PalindromesTest
  {
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

    [Fact]
    public void Palindrome_ForRacecar_true()
    {
      Assert.Equal(true, Palindromes.Do("racecar"));
      Assert.Equal(false, Palindromes.Do("Gibbity"));
    }
  }
}
