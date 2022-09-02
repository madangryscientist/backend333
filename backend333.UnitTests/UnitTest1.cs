namespace backend333.UnitTests;

public class BinarySearchTests
{
    [Fact]
    public void InList()
    {

        
        Assert.Equal(true,Algorithms.BinarySearch(10));
        
    }
    [Fact]
    public void NotInList()
    {
        Assert.Equal(false,Algorithms.BinarySearch(11));
    }
}