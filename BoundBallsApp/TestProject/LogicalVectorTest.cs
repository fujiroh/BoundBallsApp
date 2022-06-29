using BoundBallsApp;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestProject;

[TestFixture]
public class LogicalVectorTest
{
    private static object[] _addTestCase = 
    {
        new object[] {new LogicalVector(0, 0), new LogicalVector(0, 1), new LogicalVector(0, 1)},
        new object[] {new LogicalVector(0, 0), new LogicalVector(1, 0), new LogicalVector(1, 0)},
        new object[] {new LogicalVector(1, 1), new LogicalVector(1, 1), new LogicalVector(2, 2)},
        new object[] {new LogicalVector(1.25f, 1.25f), new LogicalVector(1.05f, 1.05f), new LogicalVector(2.3f, 2.3f)},
        new object[] {new LogicalVector(100, 100), new LogicalVector(200, 150), new LogicalVector(300, 250)},
        new object[] {new LogicalVector(0.25f, 0.3f), new LogicalVector(0.05f, 0.03f), new LogicalVector(0.3f, 0.33f)},
        new object[] {new LogicalVector(0, 0), new LogicalVector(0, 1), new LogicalVector(0, 1)},
        new object[] {new LogicalVector(1, 1), new LogicalVector(0, -1), new LogicalVector(1, 0)},
        new object[] {new LogicalVector(1, 1), new LogicalVector(-1, 0), new LogicalVector(0, 1)},
    };

    [TestCaseSource(nameof(_addTestCase))]
    public void Add_Test(LogicalVector v1,LogicalVector v2, LogicalVector expected)
    {
        Assert.AreEqual(v1.Add(v2),expected);
    }
}