using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DormityCFU.App_Code.DAL
{
    public class Room
    {
        public int RowNumb { get; set; }
        public int IdRoom { get; set; }
        public int IdDormitory { get; set; }
        public string RoomStatusNotation { get; set; }
        public int NumberOfResidents { get; set; }
        public int MaxNumberOfResidents { get; set; }
        public int NumbRoom { get; set; }
        public string NameDormitory { get; set; }
        public Room()
        {
            RowNumb = 0;
            IdRoom = 0;
            IdDormitory = 0;
            RoomStatusNotation = string.Empty;
            NumberOfResidents = 0;
            MaxNumberOfResidents = 0;
            NumbRoom = 0;
            NameDormitory = string.Empty;
        }
        public static Room Map(DataRow dataRow)
        {
            Room result = new Room();
            result.IdRoom = (int)dataRow["IdRoom"];
            result.IdDormitory = (int)dataRow["IdDormitory"];
            result.RoomStatusNotation = dataRow["RoomStatusNotation"].ToString();
            result.NumberOfResidents = (int)dataRow["NumberOfResidents"];
            result.MaxNumberOfResidents = (int)dataRow["MaxNumberOfResidents"];
            result.NumbRoom = (int)dataRow["NumbRoom"];
            //result.NameDormitory = dataRow["NameDormitory"].ToString();
            return result;
        }

        public static Room Map(DataRow dataRow, int index)
        {
            Room result = Map(dataRow);
            result.RowNumb = index;
            return result;
        }
    }
}