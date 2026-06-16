using System;
using ClassLibrary;

public partial class TrainerList : System.Web.UI.Page
{
    clsTrainerCollection TrainerCollection = new clsTrainerCollection();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayTrainers();
        }
    }

    void DisplayTrainers()
    {
        lstTrainers.DataSource = TrainerCollection.TrainerList;

        lstTrainers.DataValueField = "TrainerID";

        lstTrainers.DataTextField = "FullName";

        lstTrainers.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("TrainerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("TrainerDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Response.Redirect("TrainerDataEntry.aspx");
    }
}