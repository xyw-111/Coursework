using System;
using ClassLibrary;

public partial class MembersList : System.Web.UI.Page
{
    //function to populate the list box
    void DisplayMembers()
    {
        //create an instance of the member collection
        clsMemberCollection Members = new clsMemberCollection();

        //set the data source to the list of members in the collection
        lstMembers.DataSource = Members.MemberList;

        //set the name of the primary key
        lstMembers.DataValueField = "MemberID";

        //set the data field to display
        lstMembers.DataTextField = "FirstName";

        //bind the data to the list
        lstMembers.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //populate the list box when the page loads
        if (IsPostBack == false)
        {
            DisplayMembers();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate a new record
        Session["MemberID"] = -1;

        //redirect to the data entry page
        Response.Redirect("MembersDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value
        Int32 MemberID;

        //if a record has been selected from the list
        if (lstMembers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            MemberID = Convert.ToInt32(lstMembers.SelectedValue);

            //store the data in the session object
            Session["MemberID"] = MemberID;

            //redirect to the data entry page
            Response.Redirect("MembersDataEntry.aspx");
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value
        Int32 MemberID;

        //if a record has been selected from the list
        if (lstMembers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            MemberID = Convert.ToInt32(lstMembers.SelectedValue);

            //store the data in the session object
            Session["MemberID"] = MemberID;

            //redirect to the delete page
            Response.Redirect("MembersConfirmDelete.aspx");
        }
    }
}