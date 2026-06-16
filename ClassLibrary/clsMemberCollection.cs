using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsMemberCollection
    {
        //private data member for the list
        List<clsMember> mMemberList = new List<clsMember>();

        //private data member for ThisMember
        clsMember mThisMember = new clsMember();

        //constructor for the class
        public clsMemberCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblMember_SelectAll");

            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for the member list
        public List<clsMember> MemberList
        {
            get
            {
                return mMemberList;
            }
            set
            {
                mMemberList = value;
            }
        }

        //public read-only property for count
        public int Count
        {
            get
            {
                return mMemberList.Count;
            }
            set
            {
                //later
            }
        }

        //public property for ThisMember
        public clsMember ThisMember
        {
            get
            {
                return mThisMember;
            }
            set
            {
                mThisMember = value;
            }
        }

        //method to populate the array list
        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount;

            //get the count of records
            RecordCount = DB.Count;

            //clear the private array list
            mMemberList = new List<clsMember>();

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank member
                clsMember AMember = new clsMember();

                //read in the fields from the current record
                AMember.MemberID = Convert.ToInt32(DB.DataTable.Rows[Index]["MemberID"]);
                AMember.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AMember.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AMember.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AMember.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AMember.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                AMember.MembershipPlanID = Convert.ToInt32(DB.DataTable.Rows[Index]["MembershipPlanID"]);

                //add the record to the private data member
                mMemberList.Add(AMember);

                //point at the next record
                Index++;
            }
        }
    }
}