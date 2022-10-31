using DormityCFU.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DormityCFU.Pages.Students
{
    public partial class ListStudent : System.Web.UI.Page
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
            GridViewStudent.AutoGenerateColumns = false;
            GridViewStudent.DataSource = DataAccessor.SelectStudentX();
            GridViewStudent.DataBind();
        }

        protected void GridViewStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewStudent.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeleteStudent(id);
            BindGrid();
        }

        protected void GridViewStudent_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[1].Controls[0]).OnClientClick = "return confing('Вы уверены что хотите удалить запись?');";// add any JS you want here
            }
        }

        protected void GridViewStudent_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(GridViewStudent.Rows[e.NewEditIndex].Cells[0].Text);
            Response.Redirect("~/Pages/Students/EditStudent.aspx?id=" + id);
        }
    }
}