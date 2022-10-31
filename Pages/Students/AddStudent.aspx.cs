using DormityCFU.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DormityCFU.Pages.Students
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.SecondName = TextBoxSecondName.Text;
            student.FirstName = TextBoxFirstName.Text;
            student.Surname = TextBoxSurname.Text;
            student.IdDirection = int.Parse(DropDownListDirection.SelectedValue);
            student.DateOfBirth = DateTime.Parse(TextBoxDateOfBirth.Text);
            student.Course = int.Parse(TextBoxCourse.Text);
            student.DateOfRegistr = DateTime.Parse(TextBoxDateOfRegistr.Text);
            student.NumbRoom = int.Parse(TextBoxNumbRoom.Text);
            DataAccessor.InsertStudent(student);
            Response.Redirect("~/Pages/Students/ListStudent.aspx");
        }
    }
}