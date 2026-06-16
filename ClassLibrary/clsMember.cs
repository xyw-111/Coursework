using System;

namespace ClassLibrary
{
    public class clsMember
    {
        //private data members
        private Int32 mMemberID;
        private string mFirstName;
        private string mLastName;
        private string mPhoneNumber;
        private string mEmail;
        private DateTime mDateJoined;
        private Int32 mMembershipPlanID;

        //public properties
        public Int32 MemberID
        {
            get
            {
                return mMemberID;
            }
            set
            {
                mMemberID = value;
            }
        }

        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public DateTime DateJoined
        {
            get
            {
                return mDateJoined;
            }
            set
            {
                mDateJoined = value;
            }
        }

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
        public bool Find(int MemberID)
        {
            //temporary variable to store the primary key
            Int32 Index = 0;

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the member ID to search for
            DB.AddParameter("@MemberID", MemberID);

            //execute the stored procedure
            DB.Execute("sproc_tblMember_FilterByMemberID");

            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mMemberID = Convert.ToInt32(DB.DataTable.Rows[Index]["MemberID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                mMembershipPlanID = Convert.ToInt32(DB.DataTable.Rows[Index]["MembershipPlanID"]);

                //return that everything worked OK
                return true;
            }
            else
            {
                //return false if no record was found
                return false;
            }
        }

        public string Valid(string firstName, string lastName, string phoneNumber, string email, string dateJoined)
        {
            //create a string variable to store the error
            String Error = "";

            //create temporary date variable
            DateTime DateTemp;

            //validate first name
            if (firstName.Length == 0)
            {
                Error = Error + "First name may not be blank : ";
            }

            if (firstName.Length > 50)
            {
                Error = Error + "First name must be less than 50 characters : ";
            }

            //validate last name
            if (lastName.Length == 0)
            {
                Error = Error + "Last name may not be blank : ";
            }

            if (lastName.Length > 50)
            {
                Error = Error + "Last name must be less than 50 characters : ";
            }

            //validate phone number
            if (phoneNumber.Length == 0)
            {
                Error = Error + "Phone number may not be blank : ";
            }

            if (phoneNumber.Length > 15)
            {
                Error = Error + "Phone number must be less than 15 characters : ";
            }

            //validate email
            if (email.Length == 0)
            {
                Error = Error + "Email may not be blank : ";
            }

            if (email.Length > 50)
            {
                Error = Error + "Email must be less than 50 characters : ";
            }

            //validate date joined
            try
            {
                //copy the dateJoined value to DateTemp
                DateTemp = Convert.ToDateTime(dateJoined);

                //check if the date is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "Date joined cannot be in the past : ";
                }

                //check if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "Date joined cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "Date was not a valid date : ";
            }

            //return any error messages
            return Error;
        }
    }
}