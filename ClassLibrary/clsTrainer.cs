using System;

namespace ClassLibrary
{
    public class clsTrainer
    {
        //private data members
        private Int32 mTrainerID;
        private string mFullName;
        private string mSpecialty;
        private string mPhoneNumber;

        //public properties
        public Int32 TrainerID
        {
            get
            {
                return mTrainerID;
            }
            set
            {
                mTrainerID = value;
            }
        }

        public string FullName
        {
            get
            {
                return mFullName;
            }
            set
            {
                mFullName = value;
            }
        }

        public string Specialty
        {
            get
            {
                return mSpecialty;
            }
            set
            {
                mSpecialty = value;
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

        //find method
        public bool Find(int TrainerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the trainer ID to search for
            DB.AddParameter("@TrainerID", TrainerID);

            //execute the stored procedure
            DB.Execute("sproc_tblTrainer_FilterByTrainerID");

            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database
                mTrainerID = Convert.ToInt32(DB.DataTable.Rows[0]["TrainerID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mSpecialty = Convert.ToString(DB.DataTable.Rows[0]["Specialty"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);

                //return success
                return true;
            }
            else
            {
                //return false if no record found
                return false;
            }
        }

        //validation method
        public string Valid(string FullName, string Specialty, string PhoneNumber)
        {
            //string variable to store the error message
            String Error = "";

            //validate full name
            if (FullName.Length == 0)
            {
                Error = Error + "The full name may not be blank : ";
            }

            if (FullName.Length > 50)
            {
                Error = Error + "The full name must be less than 50 characters : ";
            }

            //validate specialty
            if (Specialty.Length == 0)
            {
                Error = Error + "The specialty may not be blank : ";
            }

            if (Specialty.Length > 50)
            {
                Error = Error + "The specialty must be less than 50 characters : ";
            }

            //validate phone number
            if (PhoneNumber.Length == 0)
            {
                Error = Error + "The phone number may not be blank : ";
            }

            if (PhoneNumber.Length > 15)
            {
                Error = Error + "The phone number must be less than 15 characters : ";
            }

            //return any error messages
            return Error;
        }
    }
}