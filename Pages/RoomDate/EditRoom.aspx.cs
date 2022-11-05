using DormityCFU.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DormityCFU.Pages.RoomDate
{
    public partial class EditRoom : System.Web.UI.Page
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
                DropDownListIdDormitory.DataSource = DataAccessor.SelectDormitoryX();
                DropDownListIdDormitory.DataValueField = "IdDormitory";
                DropDownListIdDormitory.DataTextField = "NameDormitory";
                DropDownListIdDormitory.DataBind();
                BindControls();
            }
        }
        private void BindControls()
        {
            Room room = DataAccessor.SelectRoom(id);
            TextBoxMaxNumberOfResidents.Text = room.MaxNumberOfResidents.ToString();
            TextBoxNumberOfResidents.Text = room.NumberOfResidents.ToString();
            TextBoxNumbRoom.Text = room.NumbRoom.ToString();
            DropDownListIdDormitory.SelectedValue = room.IdDormitory.ToString();
            TextBoxRoomStatusNotation.Text = room.RoomStatusNotation.ToString();
        }
        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.IdRoom = id;
            room.MaxNumberOfResidents = int.Parse(TextBoxMaxNumberOfResidents.Text);
            room.NumberOfResidents = int.Parse(TextBoxNumberOfResidents.Text);
            room.NumbRoom = int.Parse(TextBoxNumbRoom.Text);
            room.IdDormitory = int.Parse(DropDownListIdDormitory.SelectedValue);
            room.RoomStatusNotation = TextBoxRoomStatusNotation.Text;
            DataAccessor.UpdateRoom(room);
            Response.Redirect("~/Pages/RoomDate/ListRoom.aspx");
        }
    }
}