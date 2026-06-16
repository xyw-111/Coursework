using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing3
{
    [TestClass]
    public class tstPaymentCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            Assert.IsNotNull(AllPayments);
        }

        [TestMethod]
        public void PaymentListOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            System.Collections.Generic.List<clsPayment> TestList = new System.Collections.Generic.List<clsPayment>();

            clsPayment TestItem = new clsPayment();

            TestItem.PaymentID = 1;
            TestItem.MemberID = 1;
            TestItem.Amount = 450;
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentMethod = "Card";

            TestList.Add(TestItem);

            AllPayments.PaymentList = TestList;

            Assert.AreEqual(AllPayments.PaymentList, TestList);
        }

        [TestMethod]
        public void ThisPaymentPropertyOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            clsPayment TestPayment = new clsPayment();

            TestPayment.PaymentID = 1;
            TestPayment.MemberID = 1;
            TestPayment.Amount = 450;
            TestPayment.PaymentDate = DateTime.Now.Date;
            TestPayment.PaymentMethod = "Card";

            AllPayments.ThisPayment = TestPayment;

            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            System.Collections.Generic.List<clsPayment> TestList = new System.Collections.Generic.List<clsPayment>();

            clsPayment TestItem = new clsPayment();

            TestItem.PaymentID = 1;
            TestItem.MemberID = 1;
            TestItem.Amount = 450;
            TestItem.PaymentDate = DateTime.Now.Date;
            TestItem.PaymentMethod = "Card";

            TestList.Add(TestItem);

            AllPayments.PaymentList = TestList;

            Assert.AreEqual(AllPayments.Count, TestList.Count);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            Int32 SomeCount = 2;

            AllPayments.Count = SomeCount;

            Assert.AreEqual(AllPayments.Count, SomeCount);
        }
    }
}