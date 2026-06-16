using System;
using ClassLibrary;

public partial class MembershipPlanDataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsMembershipPlan APlan = new clsMembershipPlan();

        Int32 MembershipPlanID;

        Boolean Found = false;

        MembershipPlanID = Convert.ToInt32(txtMembershipPlanID.Text);

        Found = APlan.Find(MembershipPlanID);

        if (Found == true)
        {
            txtPlanName.Text = APlan.PlanName;
            txtDuration.Text = APlan.Duration.ToString();
            txtPrice.Text = APlan.Price.ToString();
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create instance of the class
        clsMembershipPlan APlan = new clsMembershipPlan();

        //string variable to store the error message
        String Error = "";

        //capture the data
        string PlanName = txtPlanName.Text;
        string Duration = txtDuration.Text;
        string Price = txtPrice.Text;

        //validate the data
        Error = APlan.Valid(PlanName, Duration, Price);

        //if no errors
        if (Error == "")
        {
            //capture the data
            APlan.PlanName = PlanName;
            APlan.Duration = Convert.ToInt32(Duration);
            APlan.Price = Convert.ToDecimal(Price);

            //display success
            lblError.Text = "Membership plan details are valid";
        }
        else
        {
            //display errors
            lblError.Text = Error;
        }
    }
}