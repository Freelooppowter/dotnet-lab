namespace DotnetLab.Tests;

using DotnetLab.Core.Samples;

public class RecordBasicsTests
{
    [Fact]
    public void With_Should_Not_Mutate_Original()
    {
        // Arrange
        var original=new Patient("P0001","FreeLoop",new DateOnly(1995,1,1));

        // Act
        var copy=original with {Name="Daniel"};

        // Assert
        Assert.Equal("FreeLoop",original.Name); // 原对象没变
        Assert.Equal("Daniel",copy.Name);       // 副本变了
        Assert.NotSame(original,copy);          // 是两个独立实例
        Assert.NotEqual(original,copy);         // 内容不同->按值不等
        // Assert.Equal("Daniel",original.Name);// 故意的错误
    }

    [Fact]
    public void Record_With_Same_Values_Should_Be_Equal()
    {
        // Given
        Patient p1=new Patient("P0001","张三",new DateOnly(1999,1,1));
        Patient p2=new Patient("P0001","张三",new DateOnly(1999,1,1));
    
        // When
    
        // Then
        Assert.True(p1==p2);
        Assert.Equal(p1,p2);
        Assert.NotSame(p1,p2);
        Assert.Equal(p1.GetHashCode(),p2.GetHashCode());
    }

    [Fact]
    public void PlainClass_Should_Compare_By_Reference()
    {
        // Given
        PlainClass plainClass1=new PlainClass("P0001","张三");
        PlainClass plainClass2=new PlainClass("P0001","张三");
    
        // When
    
        // Then
        Assert.False(plainClass1==plainClass2);
        Assert.False(plainClass1.Equals(plainClass2));
        Assert.NotSame(plainClass1,plainClass2);
    }
}