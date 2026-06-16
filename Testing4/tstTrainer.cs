using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class tstTrainer
    {
        //create an instance of the class we want to test
        clsTrainer ATrainer = new clsTrainer();

        //test data
        string FullName = "Daniel Foster";
        string Specialty = "Strength Coaching";
        string PhoneNumber = "07700900456";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsTrainer ATrainer = new clsTrainer();

            //test to see that it exists
            Assert.IsNotNull(ATrainer);
        }

        [TestMethod]
        public void TrainerIDPropertyOK()
        {
            //create some test data
            Int32 TestData = 1;

            //assign the data to the property
            ATrainer.TrainerID = TestData;

            //test to see the values are the same
            Assert.AreEqual(ATrainer.TrainerID, TestData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            //create some test data
            string TestData = "Daniel Foster";

            //assign the data to the property
            ATrainer.FullName = TestData;

            //test to see the values are the same
            Assert.AreEqual(ATrainer.FullName, TestData);
        }

        [TestMethod]
        public void SpecialtyPropertyOK()
        {
            //create some test data
            string TestData = "Strength Coaching";

            //assign the data to the property
            ATrainer.Specialty = TestData;

            //test to see the values are the same
            Assert.AreEqual(ATrainer.Specialty, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create some test data
            string TestData = "07700900456";

            //assign the data to the property
            ATrainer.PhoneNumber = TestData;

            //test to see the values are the same
            Assert.AreEqual(ATrainer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsTrainer ATrainer = new clsTrainer();

            //boolean variable to store the result
            Boolean Found = false;

            //create some test data
            Int32 TrainerID = 1;

            //invoke the method
            Found = ATrainer.Find(TrainerID);

            //test to see that the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //string variable to store any error message
            String Error = "";

            //invoke the method
            Error = ATrainer.Valid(FullName, Specialty, PhoneNumber);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinLessOne()
        {
            //string variable to store any error message
            String Error = "";

            //create test data
            string TestData = "";

            //invoke the method
            Error = ATrainer.Valid(TestData, Specialty, PhoneNumber);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMin()
        {
            //string variable to store any error message
            String Error = "";

            //create test data
            string TestData = "A";

            //invoke the method
            Error = ATrainer.Valid(TestData, Specialty, PhoneNumber);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            //string variable to store any error message
            String Error = "";

            //create test data
            string TestData = "";

            //pad the string to make it too long
            TestData = TestData.PadRight(51, 'A');

            //invoke the method
            Error = ATrainer.Valid(TestData, Specialty, PhoneNumber);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}