using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing1
{
    [TestClass]
    public class tstMember
    {
        //create an instance of the class we want to test
        clsMember AMember = new clsMember();

        //example test data
        string FirstName = "James";
        string LastName = "Walker";
        string PhoneNumber = "07123456789";
        string Email = "james.walker@gmail.com";
        string DateJoined = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsMember AMember = new clsMember();

            //test to see that it exists
            Assert.IsNotNull(AMember);
        }

        [TestMethod]
        public void MemberIDPropertyOK()
        {
            //create some test data
            Int32 TestData = 101;

            //assign the data to the property
            AMember.MemberID = TestData;

            //test to see that the values are the same
            Assert.AreEqual(AMember.MemberID, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create some test data
            string TestData = "Aarav";

            //assign the data to the property
            AMember.FirstName = TestData;

            //test to see that the values are the same
            Assert.AreEqual(AMember.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create some test data
            string TestData = "Patel";

            //assign the data to the property
            AMember.LastName = TestData;

            //test to see that the values are the same
            Assert.AreEqual(AMember.LastName, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create some test data
            string TestData = "+91 9876543210";

            //assign the data to the property
            AMember.PhoneNumber = TestData;

            //test to see that the values are the same
            Assert.AreEqual(AMember.PhoneNumber, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create some test data
            string TestData = "aarav.patel@example.com";

            //assign the data to the property
            AMember.Email = TestData;

            //test to see that the values are the same
            Assert.AreEqual(AMember.Email, TestData);
        }

        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            //create some test data
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            AMember.DateJoined = TestData;

            //test to see that the values are the same
            Assert.AreEqual(AMember.DateJoined, TestData);
        }

        [TestMethod]
        public void MembershipPlanIDPropertyOK()
        {
            //create some test data
            Int32 TestData = 3;

            //assign the data to the property
            AMember.MembershipPlanID = TestData;

            //test to see that the values are the same
            Assert.AreEqual(AMember.MembershipPlanID, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();

            //boolean variable to store the result of the validation
            Boolean Found = false;

            //create some test data to use with the method
            Int32 MemberID = 1;

            //invoke the method
            Found = AMember.Find(MemberID);

            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsMember AMember = new clsMember();

            //boolean variable to store the result of the search
            Boolean Found = false;

            //boolean variable to record if the data is okay
            Boolean OK = true;

            //create some test data to use with the method
            Int32 MemberID = 1;

            //invoke the method
            Found = AMember.Find(MemberID);

            //check the property
            if (AMember.FirstName != "Aarav")
            {
                OK = false;
            }

            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            clsMember AMember = new clsMember();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MemberID = 1;

            Found = AMember.Find(MemberID);

            if (AMember.LastName != "Patel")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            clsMember AMember = new clsMember();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MemberID = 1;

            Found = AMember.Find(MemberID);

            if (AMember.PhoneNumber != "+91-9876543210")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsMember AMember = new clsMember();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MemberID = 1;

            Found = AMember.Find(MemberID);

            if (AMember.Email != "aarav.patel@example.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMembershipPlanIDFound()
        {
            clsMember AMember = new clsMember();
            Boolean Found = false;
            Boolean OK = true;
            Int32 MemberID = 1;

            Found = AMember.Find(MemberID);

            if (AMember.MembershipPlanID != 2)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create a string variable to store the error message
            String Error = "";

            //invoke the method
            Error = AMember.Valid(FirstName, LastName, PhoneNumber, Email, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create a string variable to store any error message
            String Error = "";

            //create test data
            string FirstName = "";

            //invoke the method
            Error = AMember.Valid(FirstName, LastName, PhoneNumber, Email, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create a string variable to store any error message
            String Error = "";

            //create test data
            string FirstName = "A";

            //invoke the method
            Error = AMember.Valid(FirstName, LastName, PhoneNumber, Email, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create a string variable to store any error message
            String Error = "";

            //create test data
            string FirstName = new string('A', 49);

            //invoke the method
            Error = AMember.Valid(FirstName, LastName, PhoneNumber, Email, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create a string variable to store any error message
            String Error = "";

            //create test data
            string FirstName = new string('A', 50);

            //invoke the method
            Error = AMember.Valid(FirstName, LastName, PhoneNumber, Email, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create a string variable to store any error message
            String Error = "";

            //create test data
            string FirstName = new string('A', 25);

            //invoke the method
            Error = AMember.Valid(FirstName, LastName, PhoneNumber, Email, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create a string variable to store any error message
            String Error = "";

            //create test data
            string FirstName = new string('A', 51);

            //invoke the method
            Error = AMember.Valid(FirstName, LastName, PhoneNumber, Email, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedExtremeMin()
        {
            //create a string variable to store the error message
            String Error = "";

            //create test data
            DateTime TestDate = DateTime.Now.Date.AddYears(-100);
            string DateJoined = TestDate.ToString();

            //invoke the method
            Error = AMember.Valid(FirstName, LastName, PhoneNumber, Email, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMinLessOne()
        {
            //create a string variable to store the error message
            String Error = "";

            //create test data
            DateTime TestDate = DateTime.Now.Date.AddDays(-1);
            string DateJoined = TestDate.ToString();

            //invoke the method
            Error = AMember.Valid(FirstName, LastName, PhoneNumber, Email, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMin()
        {
            //create a string variable to store the error message
            String Error = "";

            //create test data
            DateTime TestDate = DateTime.Now.Date;
            string DateJoined = TestDate.ToString();

            //invoke the method
            Error = AMember.Valid(FirstName, LastName, PhoneNumber, Email, DateJoined);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMinPlusOne()
        {
            //create a string variable to store the error message
            String Error = "";

            //create test data
            DateTime TestDate = DateTime.Now.Date.AddDays(1);
            string DateJoined = TestDate.ToString();

            //invoke the method
            Error = AMember.Valid(FirstName, LastName, PhoneNumber, Email, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedInvalidData()
        {
            //create a string variable to store the error message
            String Error = "";

            //set an invalid date
            string DateJoined = "this is not a date";

            //invoke the method
            Error = AMember.Valid(FirstName, LastName, PhoneNumber, Email, DateJoined);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}