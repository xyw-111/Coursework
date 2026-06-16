using System;
using ClassLibrary;

public partial class PaymentList : System.Web.UI.Page
{
    clsPaymentCollection PaymentCollection = new clsPaymentCollection();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayPayments();
        }
    }

    void DisplayPayments()
    {
        lstPayments.DataSource = PaymentCollection.PaymentList;

        lstPayments.DataValueField = "PaymentID";

        lstPayments.DataTextField = "PaymentMethod";

        lstPayments.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Response.Redirect("PaymentConfirmDelete.aspx");
    }
}