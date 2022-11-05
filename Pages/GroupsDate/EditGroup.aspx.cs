using DormityCFU.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DormityCFU.Pages.GroupsDate
{
    public partial class EditGroup : System.Web.UI.Page
    {
        private int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                LabelMessage.Text = "Id не определено!";
                LabelMessage.ForeColor = Color.Red;
                return;
            }
            LabelMessage.Text = "";
            id = int.Parse(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                DropDownListDirection.DataSource = DataAccessor.SelectDirectionsX();
                DropDownListDirection.DataValueField = "IdDirection";
                DropDownListDirection.DataTextField = "CodeDirection";
                DropDownListDirection.DataBind();
                BindControls();
            }
        }
        private void BindControls()
        {
            Groups groups = DataAccessor.SelectGroups(id);
            DropDownListDirection.SelectedValue = groups.IdDirection.ToString();
            TextBoxCourse.Text = groups.Course.ToString();
            TextBoxCodeGroup.Text = groups.CodeGroup.ToString();
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Groups groups = new Groups();
            groups.IdGroup = id;
            groups.IdDirection = int.Parse(DropDownListDirection.SelectedValue);
            groups.Course = int.Parse(TextBoxCourse.Text);
            groups.CodeGroup = TextBoxCodeGroup.Text;
            DataAccessor.UpdateGroups(groups);
            Response.Redirect("~/Pages/GroupsDate/ListGroup.aspx");
        }
    }
}