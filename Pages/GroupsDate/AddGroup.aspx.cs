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
               
            }
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Groups groups = new Groups();
            groups.IdDirection = int.Parse(TextBoxIdDirection.Text);
            groups.Course = int.Parse(TextBoxCourse.Text);
            groups.CodeGroup = TextBoxCodeGroup.Text;
            DataAccessor.UpdateGroups(groups);
            Response.Redirect("~/Pages/GroupsDate/ListGroup.aspx");
        }
    }
}