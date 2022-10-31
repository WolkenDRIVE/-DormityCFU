using DormityCFU.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DormityCFU.Pages.Students
{
    public partial class EditStudent : System.Web.UI.Page
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
                DropDownListDirection.DataTextField = "Direction";
                DropDownListIdDormitory.DataSource = DataAccessor.SelectDormitoryX();
                DropDownListIdDormitory.DataValueField = "IdDormitory";
                DropDownListIdDormitory.DataTextField = "IdDormitory";
                DropDownListDirection.DataBind();
                DropDownListIdDormitory.DataBind();
                BindControls();
            }
        }
        private void BindControls()
        {
            Student student = DataAccessor.SelectStudent(id);
            TextBoxSecondName.Text = student.SecondName.ToString();
            TextBoxFirstName.Text = student.FirstName.ToString();
            TextBoxSurname.Text = student.Surname.ToString();
            DropDownListDirection.SelectedValue = student.IdDirection.ToString();
            TextBoxDateOfBirth.Text = student.DateOfBirth != null ? student.DateOfBirth.Value.ToShortDateString() : string.Empty;
            TextBoxCourse.Text = student.Course.ToString();
            TextBoxDateOfRegistr.Text = student.DateOfRegistr != null ? student.DateOfRegistr.Value.ToShortDateString() : string.Empty;
            DropDownListIdDormitory.SelectedValue = student.IdDormitory.ToString();
            TextBoxNumbRoom.Text = student.NumbRoom.ToString();
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.IdStudent = id;
            student.SecondName = TextBoxSecondName.Text;
            student.FirstName = TextBoxFirstName.Text;
            student.Surname = TextBoxSurname.Text;
            student.IdDirection = int.Parse(DropDownListDirection.SelectedValue);
            student.DateOfBirth = DateTime.Parse(TextBoxDateOfBirth.Text);
            student.Course = int.Parse(TextBoxCourse.Text);
            student.DateOfRegistr = DateTime.Parse(TextBoxDateOfRegistr.Text);
            student.NumbRoom = int.Parse(TextBoxNumbRoom.Text);
            DataAccessor.UpdateStudent(student);
            Response.Redirect("~/Pages/Students/ListStudent.aspx");
        }
    }
}