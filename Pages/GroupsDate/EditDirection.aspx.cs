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
    public partial class EditDirection : System.Web.UI.Page
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
                BindControls();
            }
        }
        private void BindControls()
        {
            Directions directions = DataAccessor.SelectDirections(id);
            TextBoxDirection.Text = directions.Direction.ToString();
            TextBoxCodeDirection.Text = directions.CodeDirection.ToString();
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Directions directions = new Directions();
            directions.IdDirection = id;
            directions.Direction = TextBoxDirection.Text;
            directions.CodeDirection = TextBoxCodeDirection.Text;
            DataAccessor.UpdateDirections(directions);
            Response.Redirect("~/Pages/GroupsDate/ListGroup.aspx");
        }
    }
}