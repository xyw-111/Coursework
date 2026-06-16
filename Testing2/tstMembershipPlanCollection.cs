using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing2
{
    [TestClass]
    public class tstMembershipPlanCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsMembershipPlanCollection AllPlans = new clsMembershipPlanCollection();

            Assert.IsNotNull(AllPlans);
        }

        [TestMethod]
        public void MembershipPlanListOK()
        {
            clsMembershipPlanCollection AllPlans = new clsMembershipPlanCollection();

            System.Collections.Generic.List<clsMembershipPlan> TestList =
                new System.Collections.Generic.List<clsMembershipPlan>();

            clsMembershipPlan TestItem = new clsMembershipPlan();

            TestItem.MembershipPlanID = 1;
            TestItem.PlanName = "Premium";
            TestItem.Duration = 12;
            TestItem.Price = 450;

            TestList.Add(TestItem);

            AllPlans.MembershipPlanList = TestList;

            Assert.AreEqual(AllPlans.MembershipPlanList, TestList);
        }

        [TestMethod]
        public void ThisMembershipPlanPropertyOK()
        {
            clsMembershipPlanCollection AllPlans = new clsMembershipPlanCollection();

            clsMembershipPlan TestPlan = new clsMembershipPlan();

            TestPlan.MembershipPlanID = 1;
            TestPlan.PlanName = "Premium";
            TestPlan.Duration = 12;
            TestPlan.Price = 450;

            AllPlans.ThisMembershipPlan = TestPlan;

            Assert.AreEqual(AllPlans.ThisMembershipPlan, TestPlan);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsMembershipPlanCollection AllPlans = new clsMembershipPlanCollection();

            System.Collections.Generic.List<clsMembershipPlan> TestList =
                new System.Collections.Generic.List<clsMembershipPlan>();

            clsMembershipPlan TestItem = new clsMembershipPlan();

            TestItem.MembershipPlanID = 1;
            TestItem.PlanName = "Premium";
            TestItem.Duration = 12;
            TestItem.Price = 450;

            TestList.Add(TestItem);

            AllPlans.MembershipPlanList = TestList;

            Assert.AreEqual(AllPlans.Count, TestList.Count);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsMembershipPlanCollection AllPlans = new clsMembershipPlanCollection();

            Int32 SomeCount = 2;

            AllPlans.Count = SomeCount;

            Assert.AreEqual(AllPlans.Count, SomeCount);
        }
    }
}