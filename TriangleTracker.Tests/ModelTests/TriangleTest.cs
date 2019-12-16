using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangles;

namespace TriangleTester.Tests
{
  [TestClass]
  public class TriangleTest
  {
    [TestMethod]
    public void IsTriangle_ValidTriangle_True()
    {
        Triangle triangle = new Triangle(4,5,6);
        Assert.AreEqual(true, triangle.IsTriangle());
    }
    [TestMethod]
    public void IsTriangle_InvalidTriangle_False()
    {
        Triangle triangle = new Triangle(4,1,6);
        Assert.AreEqual(false, triangle.IsTriangle());
    }
    [TestMethod]
    public void IsEquilateral_ValidTriangle_True()
    {
        Triangle triangle = new Triangle(3,3,3);
        Assert.AreEqual(true, triangle.IsEquilateral());
    }
    [TestMethod]
    public void IsEquilateral_InvalidTriangle_False()
    {
        Triangle triangle = new Triangle(3,4,3);
        Assert.AreEqual(false, triangle.IsEquilateral());
    }
    [TestMethod]
    public void TriangleConstructor_ValidTriangle()
    {
        Triangle triangle = new Triangle(3,3,3);
        triangle.side1 = 5;
        Assert.AreEqual(5, triangle.side1);
        Assert.AreEqual(3, triangle.side3);
    }
  }
}