using ClassLibrary;
using System;
using System.Data.SqlClient;

public partial class TrainerDataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the trainer class
        clsTrainer ATrainer = new clsTrainer();

        //variable to store the primary key
        Int32 TrainerID;

        //variable to store the result of the find operation
        Boolean Found = false;

        //get the primary key entered by the user
        TrainerID = Convert.ToInt32(txtTrainerID.Text);

        //find the record
        Found = ATrainer.Find(TrainerID);

        //if found
        if (Found == true)
        {
            //display the values of the properties
            txtFullName.Text = ATrainer.FullName;
            txtSpecialty.Text = ATrainer.Specialty;
            txtPhoneNumber.Text = ATrainer.PhoneNumber;

            //store the TrainerID in the session object
            Session["TrainerID"] = txtTrainerID.Text;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of the trainer class
        clsTrainer ATrainer = new clsTrainer();

        //string variable to store any error message
        String Error = "";

        //capture the data
        string FullName = txtFullName.Text;
        string Specialty = txtSpecialty.Text;
        string PhoneNumber = txtPhoneNumber.Text;

        //validate the data
        Error = ATrainer.Valid(FullName, Specialty, PhoneNumber);

        //if there are no errors
        if (Error == "")
        {
            //capture the data
            ATrainer.FullName = FullName;
            ATrainer.Specialty = Specialty;
            ATrainer.PhoneNumber = PhoneNumber;

            //store the data in the session object
            Session["ATrainer"] = ATrainer;

            //redirect to the viewer page
            Response.Redirect("TrainerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
}