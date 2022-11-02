using DormityCFU.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DormityCFU.Pages.GroupsDate
{
    public partial class ListGroup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        private void BindGrid()
        {
            GridViewDirection.AutoGenerateColumns = false;
            GridViewDirection.DataSource = DataAccessor.SelectDirectionsX();
            GridViewDirection.DataBind();
            GridViewGroup.AutoGenerateColumns = false;
            GridViewGroup.DataSource = DataAccessor.SelectGroupsX();
            GridViewGroup.DataBind();
        }

        protected void GridViewDirection_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewDirection.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeleteDirections(id);
            BindGrid();
        }

        protected void GridViewDirection_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[1].Controls[0]).OnClientClick = "return confing('Вы уверены что хотите удалить запись?');";// add any JS you want here
            }
        }

        protected void GridViewDirection_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(GridViewDirection.Rows[e.NewEditIndex].Cells[0].Text);
            Response.Redirect("~/Pages/GroupsDate/EditDirection.aspx?id=" + id);
        }

        protected void GridViewGroup_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewGroup.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeleteGroups(id);
            BindGrid();
        }

        protected void GridViewGroup_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[1].Controls[0]).OnClientClick = "return confing('Вы уверены что хотите удалить запись?');";// add any JS you want here
            }
        }

        protected void GridViewGroup_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(GridViewGroup.Rows[e.NewEditIndex].Cells[0].Text);
            Response.Redirect("~/Pages/GroupsDate/EditGroup.aspx?id=" + id);
        }
    }
}