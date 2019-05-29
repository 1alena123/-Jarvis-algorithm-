using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;
//using Form1;
using paint;
using System.Drawing;
using System.Text;
using System.IO;
using System.Linq;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

namespace UnitTestProject1
{

    //Form1 b = new Form1();
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            System.Drawing.Point g = new System.Drawing.Point();
        g.X=200; g.Y=200;
        System.Drawing.Point g1 = new System.Drawing.Point();
        g1.X = 300; g1.Y = 100;
        System.Drawing.Point g2 = new System.Drawing.Point();
        g2.X = 200;  g2.Y = 50;
        System.Drawing.Point g3 = new System.Drawing.Point();
        g3.X = 100; g3.Y = 100;
        System.Drawing.Point g4 = new System.Drawing.Point();
        g4.X = 200;  g4.Y = 100;
        System.Drawing.Point g5 = new System.Drawing.Point();
        g5.X = 300; g5.Y = 200;
        System.Drawing.Point g6 = new System.Drawing.Point();
        g6.X = 250; g6.Y = 100;

        List<System.Drawing.Point> test = new List<System.Drawing.Point>();
        test.Add(g); test.Add(g1); test.Add(g2); test.Add(g3);
        test.Add(g4); test.Add(g5); test.Add(g6);

         List<System.Drawing.Point> test1 =new  List<System.Drawing.Point>();
        test1.Add(g); test1.Add(g1); test1.Add(g2); test1.Add(g3);
         test1.Add(g5); 

         List<System.Drawing.Point> res= Program.ConvexHull(test);
        Equals(res,test1);
        }
    }
}
