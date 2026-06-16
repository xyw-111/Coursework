using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsPaymentCollection
    {
        //private data member for the list
        List<clsPayment> mPaymentList = new List<clsPayment>();

        //private data member for ThisPayment
        clsPayment mThisPayment = new clsPayment();

        //private data member for count
        Int32 mCount;

        //constructor for the class
        public clsPaymentCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblPayment_SelectAll");

            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for the payment list
        public List<clsPayment> PaymentList
        {
            get
            {
                return mPaymentList;
            }
            set
            {
                mPaymentList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                return mCount;
            }
            set
            {
                mCount = value;
            }
        }

        //public property for ThisPayment
        public clsPayment ThisPayment
        {
            get
            {
                return mThisPayment;
            }
            set
            {
                mThisPayment = value;
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

            //store the count
            mCount = RecordCount;

            //clear the private array list
            mPaymentList = new List<clsPayment>();

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank payment
                clsPayment APayment = new clsPayment();

                //read in the fields from the current record
                APayment.PaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                APayment.MemberID = Convert.ToInt32(DB.DataTable.Rows[Index]["MemberID"]);
                APayment.Amount = Convert.ToDecimal(DB.DataTable.Rows[Index]["Amount"]);
                APayment.PaymentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["PaymentDate"]);
                APayment.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);

                //add the record to the private data member
                mPaymentList.Add(APayment);

                //point at the next record
                Index++;
            }
        }
    }
}