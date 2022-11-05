using DormityCFU.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DormityCFU.Pages.GroupsDate
{
    public partial class AddDirection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Directions directions = new Directions();
            directions.Direction = TextBoxDirection.Text;
            directions.CodeDirection = TextBoxCodeDirection.Text;
            DataAccessor.InsertDirections(directions);
            Response.Redirect("~/Pages/GroupsDate/ListGroup.aspx");
        }
    }
}