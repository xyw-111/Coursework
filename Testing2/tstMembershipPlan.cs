using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing2
{
    [TestClass]
    public class tstMembershipPlan
    {
        //create instance of class
        clsMembershipPlan APlan = new clsMembershipPlan();

        //test data
        string PlanName = "Premium";
        string Duration = "12";
        string Price = "450";

        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class
            clsMembershipPlan APlan = new clsMembershipPlan();

            //test instance exists
            Assert.IsNotNull(APlan);
        }

        [TestMethod]
        public void MembershipPlanIDPropertyOK()
        {
            Int32 TestData = 1;

            APlan.MembershipPlanID = TestData;

            Assert.AreEqual(APlan.MembershipPlanID, TestData);
        }

        [TestMethod]
        public void PlanNamePropertyOK()
        {
            string TestData = "Premium Plus";

            APlan.PlanName = TestData;

            Assert.AreEqual(APlan.PlanName, TestData);
        }

        [TestMethod]
        public void DurationPropertyOK()
        {
            Int32 TestData = 12;

            APlan.Duration = TestData;

            Assert.AreEqual(APlan.Duration, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            decimal TestData = 450;

            APlan.Price = TestData;

            Assert.AreEqual(APlan.Price, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            Boolean Found = false;

            Int32 MembershipPlanID = 1;

            Found = APlan.Find(MembershipPlanID);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            String Error = "";

            Error = APlan.Valid(PlanName, Duration, Price);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PlanNameMinLessOne()
        {
            String Error = "";

            string TestData = "";

            Error = APlan.Valid(TestData, Duration, Price);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PlanNameMin()
        {
            String Error = "";

            string TestData = "A";

            Error = APlan.Valid(TestData, Duration, Price);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PlanNameMaxPlusOne()
        {
            String Error = "";

            string TestData = "";

            TestData = TestData.PadRight(21, 'A');

            Error = APlan.Valid(TestData, Duration, Price);

            Assert.AreNotEqual(Error, "");
        }
    }
}