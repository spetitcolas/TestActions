Imports ClassLibrary1

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Assert.AreEqual(15, Utils.Triple(5))
        Assert.AreNotEqual(14, Utils.Triple(5))
    End Sub

End Class