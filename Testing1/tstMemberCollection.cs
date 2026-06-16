using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing1
{
    [TestClass]
    public class tstMemberCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsMemberCollection AllMembers = new clsMemberCollection();

            //test to see that it exists
            Assert.IsNotNull(AllMembers);
        }

        [TestMethod]
        public void MemberListOK()
        {
            //create an instance of the class
            clsMemberCollection AllMembers = new clsMemberCollection();

            //create some test data
            System.Collections.Generic.List<clsMember> TestList =
                new System.Collections.Generic.List<clsMember>();

            //create the test item
            clsMember TestItem = new clsMember();

            //set its properties
            TestItem.MemberID = 1;
            TestItem.FirstName = "James";
            TestItem.LastName = "Walker";
            TestItem.PhoneNumber = "07123456789";
            TestItem.Email = "james.walker@gmail.com";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.MembershipPlanID = 2;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllMembers.MemberList = TestList;

            //test to see that the two values are the same
            Assert.AreEqual(AllMembers.MemberList, TestList);
        }

        [TestMethod]
        public void ThisMemberPropertyOK()
        {
            //create an instance of the class
            clsMemberCollection AllMembers = new clsMemberCollection();

            //create some test data
            clsMember TestMember = new clsMember();

            //assign data to the properties
            TestMember.MemberID = 1;
            TestMember.FirstName = "James";
            TestMember.LastName = "Walker";
            TestMember.PhoneNumber = "07123456789";
            TestMember.Email = "james.walker@gmail.com";
            TestMember.DateJoined = DateTime.Now.Date;
            TestMember.MembershipPlanID = 2;

            //assign the data to the property
            AllMembers.ThisMember = TestMember;

            //test to see that the values are the same
            Assert.AreEqual(AllMembers.ThisMember, TestMember);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsMemberCollection AllMembers = new clsMemberCollection();

            //create some test data
            System.Collections.Generic.List<clsMember> TestList =
                new System.Collections.Generic.List<clsMember>();

            //create the test item
            clsMember TestItem = new clsMember();

            //set its properties
            TestItem.MemberID = 1;
            TestItem.FirstName = "James";
            TestItem.LastName = "Walker";
            TestItem.PhoneNumber = "07123456789";
            TestItem.Email = "james.walker@gmail.com";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.MembershipPlanID = 2;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            AllMembers.MemberList = TestList;

            //test to see that the values are the same
            Assert.AreEqual(AllMembers.Count, TestList.Count);
        }

        

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class
            clsMemberCollection AllMembers = new clsMemberCollection();

            //test to see that the collection contains more than 1 record
            Assert.IsTrue(AllMembers.Count > 1);
        }
    }
}