using System;

namespace ClassLibrary
{
    public class clsPayment
    {
        //private data members
        private Int32 mPaymentID;
        private Int32 mMemberID;
        private decimal mAmount;
        private DateTime mPaymentDate;
        private string mPaymentMethod;

        //public properties
        public Int32 PaymentID
        {
            get
            {
                return mPaymentID;
            }
            set
            {
                mPaymentID = value;
            }
        }

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

        public decimal Amount
        {
            get
            {
                return mAmount;
            }
            set
            {
                mAmount = value;
            }
        }

        public DateTime PaymentDate
        {
            get
            {
                return mPaymentDate;
            }
            set
            {
                mPaymentDate = value;
            }
        }

        public string PaymentMethod
        {
            get
            {
                return mPaymentMethod;
            }
            set
            {
                mPaymentMethod = value;
            }
        }

        public bool Find(int PaymentID)
        {
            Int32 Index = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PaymentID", PaymentID);

            DB.Execute("sproc_tblPayment_FilterByPaymentID");

            if (DB.Count == 1)
            {
                mPaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                mMemberID = Convert.ToInt32(DB.DataTable.Rows[Index]["MemberID"]);
                mAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["Amount"]);
                mPaymentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["PaymentDate"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        //validation method
        public string Valid(string MemberID,
                            string Amount,
                            string PaymentDate,
                            string PaymentMethod)
        {
            //string variable to store the error message
            String Error = "";

            //temporary variable for the date value
            DateTime DateTemp;

            //validate member ID
            if (MemberID.Length == 0)
            {
                Error = Error + "The member ID may not be blank : ";
            }

            //validate amount
            if (Amount.Length == 0)
            {
                Error = Error + "The amount may not be blank : ";
            }

            //validate payment method
            if (PaymentMethod.Length == 0)
            {
                Error = Error + "The payment method may not be blank : ";
            }

            if (PaymentMethod.Length > 20)
            {
                Error = Error + "The payment method must be less than 20 characters : ";
            }

            //validate payment date
            try
            {
                //copy the payment date value to DateTemp
                DateTemp = Convert.ToDateTime(PaymentDate);

                //check the payment date is today's date
                if (DateTemp != DateTime.Now.Date)
                {
                    Error = Error + "The date must be today's date : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //return any error messages
            return Error;
        }
    }
}