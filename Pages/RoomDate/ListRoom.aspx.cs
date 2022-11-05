using DormityCFU.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DormityCFU.Pages.RoomDate
{
    public partial class ListRoom : System.Web.UI.Page
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
            GridViewDormitory.AutoGenerateColumns = false;
            GridViewDormitory.DataSource = DataAccessor.SelectDormitoryX();
            GridViewDormitory.DataBind();
            GridViewRoom.AutoGenerateColumns = false;
            GridViewRoom.DataSource = DataAccessor.SelectRoomX();
            GridViewRoom.DataBind();
        }
        protected void GridViewRoom_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewRoom.Rows[e.RowIndex].Cells[3].Text);
            DataAccessor.DeleteRoom(id);
            BindGrid();
        }

        protected void GridViewRoom_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[3].Controls[0]).OnClientClick = "return confing('Вы уверены что хотите удалить запись?');";// add any JS you want here
            }
        }

        protected void GridViewRoom_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(GridViewRoom.Rows[e.NewEditIndex].Cells[0].Text);
            Response.Redirect("~/Pages/RoomDate/EditRoom.aspx?id=" + id);
        }
    }
}