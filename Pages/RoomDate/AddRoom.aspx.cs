using DormityCFU.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DormityCFU.Pages.RoomDate
{
    public partial class AddRoom : System.Web.UI.Page
    {
        private int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //DropDownListRoomStatusNotation.DataSource = DataAccessor.SelectDirectionsX();
                //DropDownListRoomStatusNotation.DataValueField = "IdRoom";
                //DropDownListRoomStatusNotation.DataTextField = "RoomStatusNotation";
                DropDownListIdDormitory.DataSource = DataAccessor.SelectDormitoryX();
                DropDownListIdDormitory.DataValueField = "IdDormitory";
                DropDownListIdDormitory.DataTextField = "IdDormitory";
                //DropDownListRoomStatusNotation.DataBind();
                DropDownListIdDormitory.DataBind();
            }
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
            DataAccessor.InsertRoom(room);
            Response.Redirect("~/Pages/RoomDate/ListRoom.aspx");
        }
    }
}