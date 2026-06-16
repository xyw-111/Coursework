using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsMembershipPlanCollection
    {
        //private data member for the list
        List<clsMembershipPlan> mMembershipPlanList = new List<clsMembershipPlan>();

        //private data member for ThisMembershipPlan
        clsMembershipPlan mThisMembershipPlan = new clsMembershipPlan();

        //private data member for count
        Int32 mCount;

        //constructor for the class
        public clsMembershipPlanCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblMembershipPlan_SelectAll");

            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for the membership plan list
        public List<clsMembershipPlan> MembershipPlanList
        {
            get
            {
                return mMembershipPlanList;
            }
            set
            {
                mMembershipPlanList = value;
                mCount = value.Count;
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

        //public property for ThisMembershipPlan
        public clsMembershipPlan ThisMembershipPlan
        {
            get
            {
                return mThisMembershipPlan;
            }
            set
            {
                mThisMembershipPlan = value;
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
            mMembershipPlanList = new List<clsMembershipPlan>();

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank membership plan
                clsMembershipPlan APlan = new clsMembershipPlan();

                //read in the fields from the current record
                APlan.MembershipPlanID = Convert.ToInt32(DB.DataTable.Rows[Index]["MembershipPlanID"]);
                APlan.PlanName = Convert.ToString(DB.DataTable.Rows[Index]["PlanName"]);
                APlan.Duration = Convert.ToInt32(DB.DataTable.Rows[Index]["Duration"]);
                APlan.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);

                //add the record to the private data member
                mMembershipPlanList.Add(APlan);

                //point at the next record
                Index++;
            }
        }
    }
}