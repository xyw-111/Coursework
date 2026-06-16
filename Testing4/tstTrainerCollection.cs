using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace Testing4
{
    [TestClass]
    public class tstTrainerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsTrainerCollection AllTrainers = new clsTrainerCollection();

            Assert.IsNotNull(AllTrainers);
        }

        [TestMethod]
        public void TrainerListOK()
        {
            clsTrainerCollection AllTrainers = new clsTrainerCollection();

            System.Collections.Generic.List<clsTrainer> TestList = new System.Collections.Generic.List<clsTrainer>();

            clsTrainer TestItem = new clsTrainer();

            TestItem.TrainerID = 1;
            TestItem.FullName = "John Doe";
            TestItem.Specialty = "Cardio";
            TestItem.PhoneNumber = "0712345678";

            TestList.Add(TestItem);

            AllTrainers.TrainerList = TestList;

            Assert.AreEqual(AllTrainers.TrainerList, TestList);
        }

        [TestMethod]
        public void ThisTrainerPropertyOK()
        {
            clsTrainerCollection AllTrainers = new clsTrainerCollection();

            clsTrainer TestTrainer = new clsTrainer();

            TestTrainer.TrainerID = 1;
            TestTrainer.FullName = "John Doe";
            TestTrainer.Specialty = "Cardio";
            TestTrainer.PhoneNumber = "0712345678";

            AllTrainers.ThisTrainer = TestTrainer;

            Assert.AreEqual(AllTrainers.ThisTrainer, TestTrainer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsTrainerCollection AllTrainers = new clsTrainerCollection();

            System.Collections.Generic.List<clsTrainer> TestList = new System.Collections.Generic.List<clsTrainer>();

            clsTrainer TestItem = new clsTrainer();

            TestItem.TrainerID = 1;
            TestItem.FullName = "John Doe";
            TestItem.Specialty = "Cardio";
            TestItem.PhoneNumber = "0712345678";

            TestList.Add(TestItem);

            AllTrainers.TrainerList = TestList;

            Assert.AreEqual(AllTrainers.Count, TestList.Count);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsTrainerCollection AllTrainers = new clsTrainerCollection();

            Int32 SomeCount = 2;

            AllTrainers.Count = SomeCount;

            Assert.AreEqual(AllTrainers.Count, SomeCount);
        }
    }
}