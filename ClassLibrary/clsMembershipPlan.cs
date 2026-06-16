using System;

namespace ClassLibrary
{
    public class clsMembershipPlan
    {
        //private data members
        private Int32 mMembershipPlanID;
        private string mPlanName;
        private Int32 mDuration;
        private decimal mPrice;

        //public properties
        public Int32 MembershipPlanID
        {
            get
            {
                return mMembershipPlanID;
            }
            set
            {
                mMembershipPlanID = value;
            }
        }

        public string PlanName
        {
            get
            {
                return mPlanName;
            }
            set
            {
                mPlanName = value;
            }
        }

        public Int32 Duration
        {
            get
            {
                return mDuration;
            }
            set
            {
                mDuration = value;
            }
        }

        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public bool Find(int MembershipPlanID)
        {
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();

            //add parameter
            DB.AddParameter("@MembershipPlanID", MembershipPlanID);

            //execute stored procedure
            DB.Execute("sproc_tblMembershipPlan_FilterByMembershipPlanID");

            //if record found
            if (DB.Count == 1)
            {
                //copy data
                mMembershipPlanID = Convert.ToInt32(DB.DataTable.Rows[0]["MembershipPlanID"]);
                mPlanName = Convert.ToString(DB.DataTable.Rows[0]["PlanName"]);
                mDuration = Convert.ToInt32(DB.DataTable.Rows[0]["Duration"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);

                //return success
                return true;
            }
            else
            {
                //return failure
                return false;
            }
        }

        public string Valid(string PlanName, string Duration, string Price)
        {
            //string variable to store the error message
            String Error = "";

            //validate PlanName
            if (PlanName.Length == 0)
            {
                Error = Error + "The plan name may not be blank : ";
            }

            if (PlanName.Length > 20)
            {
                Error = Error + "The plan name must be less than 20 characters : ";
            }

            //validate Duration
            Int32 DurationTemp;

            try
            {
                DurationTemp = Convert.ToInt32(Duration);

                if (DurationTemp <= 0)
                {
                    Error = Error + "Duration must be greater than zero : ";
                }
            }
            catch
            {
                Error = Error + "The duration was not a valid number : ";
            }

            //validate Price
            decimal PriceTemp;

            try
            {
                PriceTemp = Convert.ToDecimal(Price);

                if (PriceTemp <= 0)
                {
                    Error = Error + "Price must be greater than zero : ";
                }
            }
            catch
            {
                Error = Error + "The price was not a valid decimal : ";
            }

            //return any error messages
            return Error;
        }
    }
}