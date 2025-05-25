using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
 
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        StringReverse stringReverse = new StringReverse();

        // Act
        string actual = StringReverse.Reverse("");

        // Assert
        Assert.AreEqual("", actual, "Reversion did not work properly");
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        StringReverse stringReverse = new StringReverse();

        // Act
        string actual = StringReverse.Reverse("a");

        // Assert
        Assert.AreEqual("a", actual, "Reversion did not work properly");
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        StringReverse stringReverse = new StringReverse();

        // Act
        string actual = StringReverse.Reverse("abc");

        // Assert
        Assert.AreEqual("cba", actual, "Reversion did not work properly");
    }
}
