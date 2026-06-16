using System;
using ClassLibrary;

public partial class MembersDataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the member class
        clsMember AMember = new clsMember();

        //find the record using the primary key
        if (AMember.Find(Convert.ToInt32(txtMemberID.Text)))
        {
            //display the values in the text boxes
            txtFirstName.Text = AMember.FirstName;
            txtLastName.Text = AMember.LastName;
            txtPhoneNumber.Text = AMember.PhoneNumber;
            txtEmail.Text = AMember.Email;
            txtDateJoined.Text = AMember.DateJoined.ToShortDateString();
            txtMembershipPlanID.Text = AMember.MembershipPlanID.ToString();

            //store the MemberID in the Session object
            Session["MemberID"] = txtMemberID.Text;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsMember
        clsMember AMember = new clsMember();

        //capture the data entered by the user
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string Email = txtEmail.Text;
        string DateJoined = txtDateJoined.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AMember.Valid(FirstName, LastName, PhoneNumber, Email, DateJoined);

        //if there are no errors
        if (Error == "")
        {
            //capture the member ID
            AMember.MemberID = Convert.ToInt32(txtMemberID.Text);

            //assign the data to the properties
            AMember.FirstName = FirstName;
            AMember.LastName = LastName;
            AMember.PhoneNumber = PhoneNumber;
            AMember.Email = Email;
            AMember.DateJoined = Convert.ToDateTime(DateJoined);
            AMember.MembershipPlanID = Convert.ToInt32(txtMembershipPlanID.Text);

            //store the member ID in the session object
            Session["MemberID"] = AMember.MemberID;

            //redirect to the viewer page
            Response.Redirect("TeamMainMenu.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
}