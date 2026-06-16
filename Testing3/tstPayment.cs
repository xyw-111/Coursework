using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing3
{
    [TestClass]
    public class tstPayment
    {
        //create an instance of the class we want to test
        clsPayment APayment = new clsPayment();

        //test data
        string MemberID = "1";
        string Amount = "450";
        string PaymentDate = DateTime.Now.Date.ToString();
        string PaymentMethod = "Card";

        [TestMethod]
        public void InstanceOK()
        {
            clsPayment APayment = new clsPayment();

            Assert.IsNotNull(APayment);
        }

        [TestMethod]
        public void PaymentIDPropertyOK()
        {
            Int32 TestData = 1;

            APayment.PaymentID = TestData;

            Assert.AreEqual(APayment.PaymentID, TestData);
        }

        [TestMethod]
        public void MemberIDPropertyOK()
        {
            Int32 TestData = 1;

            APayment.MemberID = TestData;

            Assert.AreEqual(APayment.MemberID, TestData);
        }

        [TestMethod]
        public void AmountPropertyOK()
        {
            decimal TestData = 450;

            APayment.Amount = TestData;

            Assert.AreEqual(APayment.Amount, TestData);
        }

        [TestMethod]
        public void PaymentDatePropertyOK()
        {
            DateTime TestData = DateTime.Now.Date;

            APayment.PaymentDate = TestData;

            Assert.AreEqual(APayment.PaymentDate, TestData);
        }

        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            string TestData = "Card";

            APayment.PaymentMethod = TestData;

            Assert.AreEqual(APayment.PaymentMethod, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            Boolean Found = false;

            Int32 PaymentID = 1;

            Found = APayment.Find(PaymentID);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //string variable to store the error message
            String Error = "";

            //invoke the method
            Error = APayment.Valid(MemberID, Amount, PaymentDate, PaymentMethod);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMinLessOne()
        {
            //string variable to store the error message
            String Error = "";

            //create test data
            string TestData = "";

            //invoke the method
            Error = APayment.Valid(MemberID, Amount, PaymentDate, TestData);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMin()
        {
            //string variable to store the error message
            String Error = "";

            //create test data
            string TestData = "A";

            //invoke the method
            Error = APayment.Valid(MemberID, Amount, PaymentDate, TestData);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMaxPlusOne()
        {
            //string variable to store the error message
            String Error = "";

            //create test data
            string TestData = "";

            //pad the string to make it too long
            TestData = TestData.PadRight(21, 'A');

            //invoke the method
            Error = APayment.Valid(MemberID, Amount, PaymentDate, TestData);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}