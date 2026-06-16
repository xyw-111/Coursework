using System;
using ClassLibrary;

public partial class PaymentDataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsPayment APayment = new clsPayment();

        Int32 PaymentID;

        Boolean Found = false;

        PaymentID = Convert.ToInt32(txtPaymentID.Text);

        Found = APayment.Find(PaymentID);

        if (Found == true)
        {
            txtMemberID.Text = APayment.MemberID.ToString();
            txtAmount.Text = APayment.Amount.ToString();
            txtPaymentDate.Text = APayment.PaymentDate.ToShortDateString();
            txtPaymentMethod.Text = APayment.PaymentMethod;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsPayment
        clsPayment APayment = new clsPayment();

        //string variable to store the error message
        String Error = "";

        //capture the data
        string MemberID = txtMemberID.Text;
        string Amount = txtAmount.Text;
        string PaymentDate = txtPaymentDate.Text;
        string PaymentMethod = txtPaymentMethod.Text;

        //validate the data
        Error = APayment.Valid(MemberID, Amount, PaymentDate, PaymentMethod);

        //if there are no errors
        if (Error == "")
        {
            //capture the data
            APayment.MemberID = Convert.ToInt32(MemberID);
            APayment.Amount = Convert.ToDecimal(Amount);
            APayment.PaymentDate = Convert.ToDateTime(PaymentDate);
            APayment.PaymentMethod = PaymentMethod;

            //display success message
            lblError.Text = "Payment details are valid";
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
}