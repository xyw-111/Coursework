using System;
using ClassLibrary;

public partial class MembershipPlanList : System.Web.UI.Page
{
    clsMembershipPlanCollection MembershipPlanCollection =
        new clsMembershipPlanCollection();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayMembershipPlans();
        }
    }

    void DisplayMembershipPlans()
    {
        lstMembershipPlans.DataSource =
            MembershipPlanCollection.MembershipPlanList;

        lstMembershipPlans.DataValueField = "MembershipPlanID";

        lstMembershipPlans.DataTextField = "PlanName";

        lstMembershipPlans.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("MembershipPlanDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("MembershipPlanDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Response.Redirect("MembershipPlanConfirmDelete.aspx");
    }
}