namespace Tests

module Tests = 
    open System
    open NUnit.Framework
    open ClassLibrary1
    
    [<Test>]
    let ``Intersect``() =
        let a = new MyRectangle(new MyPoint(5.0, 5.0), new MyPoint(25.0, 25.0))
        let b = new MyRectangle(new MyPoint(15.0, 15.0), new MyPoint(20.0, 20.0))
        Assert.IsTrue(Geom.check(a, b));

    [<Test>]
    let ``Intersect in point``() =
        let a = new MyRectangle(new MyPoint(5.0, 5.0), new MyPoint(25.0, 25.0))
        let b = new MyRectangle(new MyPoint(25.0, 25.0), new MyPoint(40.0, 40.0))
        Assert.IsTrue(Geom.check(a, b));

    [<Test>]
    let ``Don`t intersect``() =    
        let a = new MyRectangle(new MyPoint(5.0, 5.0), new MyPoint(20.0, 20.0))
        let b = new MyRectangle(new MyPoint(25.0, 25.0), new MyPoint(40.0, 40.0))
        Assert.IsFalse(Geom.check(a, b));

    let ``equal`` () =
        let a = new MyRectangle(new MyPoint(5.0, 5.0), new MyPoint(20.0, 20.0))
        let b = new MyRectangle(new MyPoint(5.0, 5.0), new MyPoint(20.0, 20.0))
        Assert.IsTrue(Geom.check(a, b));



        

 