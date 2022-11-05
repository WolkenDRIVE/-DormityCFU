using DormityCFU.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DormityCFU.Pages.GroupsDate
{
    public partial class AddGroup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListDirection.DataSource = DataAccessor.SelectDirectionsX();
                DropDownListDirection.DataValueField = "IdDirection";
                DropDownListDirection.DataTextField = "CodeDirection";
                DropDownListDirection.DataBind();
            }
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Groups groups = new Groups();
            groups.IdDirection = int.Parse(DropDownListDirection.SelectedValue);
            groups.Course = int.Parse(TextBoxCourse.Text);
            groups.CodeGroup = TextBoxCodeGroup.Text;
            DataAccessor.InsertGroups(groups);
            Response.Redirect("~/Pages/GroupsDate/ListGroup.aspx");
        }
    }
}