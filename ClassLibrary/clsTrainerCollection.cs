using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsTrainerCollection
    {
        //private data member for the list
        List<clsTrainer> mTrainerList = new List<clsTrainer>();

        //private data member for ThisTrainer
        clsTrainer mThisTrainer = new clsTrainer();

        //constructor for the class
        public clsTrainerCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblTrainer_SelectAll");

            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for the trainer list
        public List<clsTrainer> TrainerList
        {
            get
            {
                return mTrainerList;
            }
            set
            {
                mTrainerList = value;
            }
        }

        //public read-only property for count
        public int Count
        {
            get
            {
                return mTrainerList.Count;
            }
            set
            {
                //later
            }
        }

        //public property for ThisTrainer
        public clsTrainer ThisTrainer
        {
            get
            {
                return mThisTrainer;
            }
            set
            {
                mThisTrainer = value;
            }
        }

        //method to populate the array list
        void PopulateArray(clsDataConnection DB)
        {
            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount;

            //get the count of records
            RecordCount = DB.Count;

            //clear the private array list
            mTrainerList = new List<clsTrainer>();

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank trainer
                clsTrainer ATrainer = new clsTrainer();

                //read in the fields from the current record
                ATrainer.TrainerID = Convert.ToInt32(DB.DataTable.Rows[Index]["TrainerID"]);
                ATrainer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                ATrainer.Specialty = Convert.ToString(DB.DataTable.Rows[Index]["Specialty"]);
                ATrainer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);

                //add the record to the private data member
                mTrainerList.Add(ATrainer);

                //point at the next record
                Index++;
            }
        }
    }
}