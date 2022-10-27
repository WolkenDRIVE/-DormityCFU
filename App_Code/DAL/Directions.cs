using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DormityCFU.App_Code.DAL
{
    public class Directions
    {
        public int RowNumb { get; set; }
        public int IdDirection { get; set; }
        public string Direction { get; set; }
        public string CodeDirection { get; set; }
        public Directions()
        {
            RowNumb = 0;
            IdDirection = 0;
            Direction = string.Empty;
            CodeDirection = string.Empty;
        }
        public static Directions Map(DataRow dataRow)
        {
            Directions result = new Directions();
            result.IdDirection = (int)dataRow["IdDirection"];
            result.Direction = dataRow["Direction"].ToString();
            result.CodeDirection = dataRow["CodeDirection"].ToString();
            return result;
        }

        public static Directions Map(DataRow dataRow, int index)
        {
            Directions result = Map(dataRow);
            result.RowNumb = index;
            return result;
        }
    }
}