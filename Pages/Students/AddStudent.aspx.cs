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
                DropDownListCourse.DataSource = DataAccessor.SelectGroupsX();
                DropDownListCourse.DataValueField = "IdGroup";
                DropDownListCourse.DataTextField = "Course";
                DropDownListCourse.DataBind();
                DropDownListRoom.DataSource = DataAccessor.SelectRoomX();
                DropDownListRoom.DataValueField = "IdRoom";
                DropDownListRoom.DataTextField = "NumbRoom";
                DropDownListRoom.DataBind();
                DropDownListIdDormitory.DataSource = DataAccessor.SelectDormitoryX();
                DropDownListIdDormitory.DataValueField = "IdDormitory";
                DropDownListIdDormitory.DataTextField = "IdDormitory";
                DropDownListIdDormitory.DataBind();
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.SecondName = TextBoxSecondName.Text;
            student.FirstName = TextBoxFirstName.Text;
            student.Surname = TextBoxSurname.Text;
            student.DateOfBirth = DateTime.Parse(TextBoxDateOfBirth.Text);
            student.IdGroup = int.Parse(DropDownListCourse.SelectedValue);
            student.DateOfRegistr = DateTime.Parse(TextBoxDateOfRegistr.Text);
            student.IdRoom = int.Parse(DropDownListRoom.SelectedValue);
            DataAccessor.InsertStudent(student);
            Response.Redirect("~/Pages/Students/ListStudent.aspx");
        }
    }
}