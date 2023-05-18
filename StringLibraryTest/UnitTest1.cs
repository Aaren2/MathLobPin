using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void side15height5S375()
        {
            double side = 15;
            double height = 5;
            double S = 37.5;
               
            double res = MyMath.Geometry.STriangle(side, height);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void side3125height5S375()
        {
            double side = 15;
            double height = 5;
            double S = 37.5;

            double res = MyMath.Geometry.STriangle(side, height);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void side1312height5S375()
        {
            double side = 15;
            double height = 5;
            double S = 37.5;

            double res = MyMath.Geometry.STriangle(side, height);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void side1123height5S375()
        {
            double side = 15;
            double height = 5;
            double S = 37.5;

            double res = MyMath.Geometry.STriangle(side, height);

            Assert.AreEqual(res, S);
        }

        //
        [TestMethod]
        public void side20S400()
        {
            double side = 20;
            double S = 400;

            double res = MyMath.Geometry.SSquare(side);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void side2312S400()
        {
            double side = 20;
            double S = 400;

            double res = MyMath.Geometry.SSquare(side);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void side2321S400()
        {
            double side = 20;
            double S = 400;

            double res = MyMath.Geometry.SSquare(side);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void side231S400()
        {
            double side = 20;
            double S = 400;

            double res = MyMath.Geometry.SSquare(side);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void side2323S400()
        {
            double side = 20;
            double S = 400;

            double res = MyMath.Geometry.SSquare(side);

            Assert.AreEqual(res, S);
        }


        //

        [TestMethod]
        public void side114side224S336()
        {
            double side1 = 14;
            double side2 = 24;
            double S = 336;

            double res = MyMath.Geometry.SRectangle(side1, side2);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void side1324side224S336()
        {
            double side1 = 14;
            double side2 = 24;
            double S = 336;

            double res = MyMath.Geometry.SRectangle(side1, side2);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void side1234side224S336()
        {
            double side1 = 14;
            double side2 = 24;
            double S = 336;

            double res = MyMath.Geometry.SRectangle(side1, side2);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void side13123side224S336()
        {
            double side1 = 14;
            double side2 = 24;
            double S = 336;

            double res = MyMath.Geometry.SRectangle(side1, side2);

            Assert.AreEqual(res, S);
        }
        //
        [TestMethod]
        public void diagonal117diagonal221S1785()
        {
            double diagonal1 = 17;
            double diagonal2 = 21;
            double S = 178.5;

            double res = MyMath.Geometry.SRhombus(diagonal1, diagonal2);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void diagonal11321diagonal221S1785()
        {
            double diagonal1 = 17;
            double diagonal2 = 21;
            double S = 178.5;

            double res = MyMath.Geometry.SRhombus(diagonal1, diagonal2);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void diagonal13diagonal221S1785()
        {
            double diagonal1 = 17;
            double diagonal2 = 21;
            double S = 178.5;

            double res = MyMath.Geometry.SRhombus(diagonal1, diagonal2);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void diagonal113diagonal221S1785()
        {
            double diagonal1 = 17;
            double diagonal2 = 21;
            double S = 178.5;

            double res = MyMath.Geometry.SRhombus(diagonal1, diagonal2);

            Assert.AreEqual(res, S);
        }

        //
        [TestMethod]
        public void radius33S20724()
        {
     
            double radius = 33;
            double S = 207.24;

            double res = MyMath.Geometry.SCircle(radius);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void radius123S20724()
        {

            double radius = 33;
            double S = 207.24;

            double res = MyMath.Geometry.SCircle(radius);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void radius312S20724()
        {

            double radius = 33;
            double S = 207.24;

            double res = MyMath.Geometry.SCircle(radius);

            Assert.AreEqual(res, S);
        }

        [TestMethod]
        public void radius31S20724()
        {

            double radius = 33;
            double S = 207.24;

            double res = MyMath.Geometry.SCircle(radius);

            Assert.AreEqual(res, S);
        }

    }

      // 


    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void cathetus10hypotenuse5Sin2()
        {

            double cathetus = 10;
            double hypotenuse = 5;
            double Sin = 2;

            double res = MyMath.Trigonometry.MySin(cathetus,hypotenuse);

            Assert.AreEqual(res, Sin);
        }
        //
        [TestMethod]
        public void cathetus5hypotenuse10Cos05()
        {

            double cathetus = 5;
            double hypotenuse = 10;
            double Cos = 0.5;

            double res = MyMath.Trigonometry.MyCos(cathetus, hypotenuse);

            Assert.AreEqual(res, Cos);
        }
        //
        [TestMethod]
        public void cathetus121cathetus217CTang124()
        {

            double cathetus1 = 21;
            double cathetus2 = 17;
            double Tang = 1.24;

            double res = MyMath.Trigonometry.MyTang(cathetus1, cathetus2);

            Assert.AreEqual(res, Tang);
        }
        //
        [TestMethod]
        public void cathetus137cathetus27CoTang529()
        {

            double cathetus1 = 37;
            double cathetus2 = 7;
            double CoTang = 5.29;

            double res = MyMath.Trigonometry.MyCoTang(cathetus1, cathetus2);

            Assert.AreEqual(res, CoTang);
        }



    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void doubles12345sum15()
        {

            double[] doubles = { 1, 2, 3, 4, 5 };
            double sum = 15;

            double res = MyMath.Algebra.MySum(doubles);

            Assert.AreEqual(res, sum);
        }

        [TestMethod]
        public void doubles101520773sum125()
        {

            double[] doubles = { 10, 15, 20, 77, 3 };
            double sum = 125;

            double res = MyMath.Algebra.MySum(doubles);

            Assert.AreEqual(res, sum);
        }

        [TestMethod]
        public void doubles12803475173sum374()
        {

            double[] doubles = { 12, 80, 34, 75, 173 };
            double sum = 374;

            double res = MyMath.Algebra.MySum(doubles);

            Assert.AreEqual(res, sum);
        }

        [TestMethod]
        public void doubles1597795658sum980()
        {

            double[] doubles = { 15, 97, 795, 65, 8};
            double sum = 980;

            double res = MyMath.Algebra.MySum(doubles);

            Assert.AreEqual(res, sum);
        }
        //
        [TestMethod]
        public void doubles12345max5()
        {

            double[] doubles = { 1, 2, 3, 4, 5 };
            double max = 5;

            double res = MyMath.Algebra.MyMax(doubles);

            Assert.AreEqual(res, max);
        }

        [TestMethod]
        public void doubles993055207max99()
        {

            double[] doubles = { 99, 30, 55, 20, 7 };
            double max = 99;

            double res = MyMath.Algebra.MyMax(doubles);

            Assert.AreEqual(res, max);
        }

        [TestMethod]
        public void doubles1234567890max90()
        {

            double[] doubles = { 12, 34, 56, 78, 90 };
            double max = 90;

            double res = MyMath.Algebra.MyMax(doubles);

            Assert.AreEqual(res, max);
        }

        [TestMethod]
        public void doubles12759max9()
        {

            double[] doubles = { 1, 2, 7, 5, 9 };
            double max = 9;

            double res = MyMath.Algebra.MyMax(doubles);

            Assert.AreEqual(res, max);
        }

        //
        [TestMethod]
        public void doubles12345min1()
        {

            double[] doubles = { 1, 2, 3, 4, 5 };
            double min = 1;

            double res = MyMath.Algebra.MyMin(doubles);

            Assert.AreEqual(res, min);
        }

        [TestMethod]
        public void doubles12369min1()
        {

            double[] doubles = { 1, 2, 3, 6, 9 };
            double min = 1;

            double res = MyMath.Algebra.MyMin(doubles);

            Assert.AreEqual(res, min);
        }

        [TestMethod]
        public void doubles1122334455min11()
        {

            double[] doubles = { 11, 22, 33, 44, 55 };
            double min = 11;

            double res = MyMath.Algebra.MyMin(doubles);

            Assert.AreEqual(res, min);
        }

        [TestMethod]
        public void doubles2789655730min27()
        {

            double[] doubles = { 27, 89, 65, 57, 30 };
            double min = 27;

            double res = MyMath.Algebra.MyMin(doubles);

            Assert.AreEqual(res, min);
        }
        //

        [TestMethod]
        public void doubles6789avg75()
        {

            double[] doubles = { 6, 7, 8, 9};
            double avg = 7.5;

            double res = MyMath.Algebra.MyAvg(doubles);

            Assert.AreEqual(res, avg);
        }

        [TestMethod]
        public void doubles1222324252avg32()
        {

            double[] doubles = { 12, 22, 32, 42, 52 };
            double avg = 32;

            double res = MyMath.Algebra.MyAvg(doubles);

            Assert.AreEqual(res, avg);
        }

        [TestMethod]
        public void doubles19202179avg152()
        {

            double[] doubles = { 19, 20, 21, 7, 9 };
            double avg = 15.2;

            double res = MyMath.Algebra.MyAvg(doubles);

            Assert.AreEqual(res, avg);
        }

        [TestMethod]
        public void doubles54667171avg398()
        {

            double[] doubles = { 54, 66, 71, 7, 1 };
            double avg = 39.8;

            double res = MyMath.Algebra.MyAvg(doubles);

            Assert.AreEqual(res, avg);
        }
    }

